using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RendicionGastos.DataAccess;
using RendicionGastos.Repositories.Interfaces;
using RendicionGastos.Services.Interfaces;
using RendicionGastos.Services.Profiles;
using Scrutor;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.Configure<AppSettings>(builder.Configuration);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRazorPages();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RendicionGastosDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebAppDb"));
});

builder.Services.AddDbContext<SecurityDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SecurityDb"));
});


// Configurar y usar ASP.NET Identity
builder.Services.AddIdentity<RgIdentityUser, IdentityRole>(policies =>
{
    policies.Password.RequireDigit = false;
    policies.Password.RequireLowercase = false;
    policies.Password.RequireUppercase = true;
    policies.Password.RequireNonAlphanumeric = true;
    policies.Password.RequiredLength = 8;

    policies.User.RequireUniqueEmail = true;

    // Politica de bloqueo de cuentas
    policies.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromHours(1);
    policies.Lockout.MaxFailedAccessAttempts = 5;
})
    .AddEntityFrameworkStores<SecurityDbContext>()
    .AddDefaultTokenProviders();


// Usando SCRUTOR: Registramos las dependencias de Repositories y Services
builder.Services.Scan(selector => selector
    .FromAssemblies(typeof(ICentroCostoRepository).Assembly,
        typeof(ICentroCostoService).Assembly)
    .AddClasses(publicOnly: false)
    .UsingRegistrationStrategy(RegistrationStrategy.Skip)
    .AsMatchingInterface()
    .WithTransientLifetime()
);

//Usando Libreria AUTOMAPPER
builder.Services.AddAutoMapper(config =>
{
    config.AddProfile<CentroCostoProfile>();
    config.AddProfile<RendicionProfile>();
});

//builder.Services.AddAuthentication(x =>
//{
//    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer(x =>
//{
//    var secretKey = Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SecretKey"] ??
//                                           throw new InvalidOperationException("No se configuro el SecretKey"));

//    x.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateIssuer = true,
//        ValidateAudience = true,
//        ValidateLifetime = true,
//        ValidateIssuerSigningKey = true,
//        ValidIssuer = builder.Configuration["Jwt:Emisor"],
//        ValidAudience = builder.Configuration["Jwt:Audiencia"],
//        IssuerSigningKey = new SymmetricSecurityKey(secretKey)
//    };
//});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");


using (var scope = app.Services.CreateScope())
{
    await UserDataSeeder.Seed(scope.ServiceProvider);
}

app.Run();