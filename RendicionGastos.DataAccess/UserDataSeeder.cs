using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RendicionGastos.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.DataAccess
{
    public class UserDataSeeder
    {
        public static async Task Seed(IServiceProvider service)
        {
            // UserManager (Repositorio de Usuarios)
            var userManager = service.GetRequiredService<UserManager<RgIdentityUser>>();
            // RoleManager (Repositorio de Roles)
            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();

            // Crear roles
            var adminRole = new IdentityRole(Constantes.RolAdministrador);
            var empleadoRole = new IdentityRole(Constantes.RolEmpleado);

            await roleManager.CreateAsync(adminRole);

            await roleManager.CreateAsync(empleadoRole);

            // Usuario Administrador
            var adminUser = new RgIdentityUser()
            {
                NombreCompleto = "Administrador del sistema",
                UserName = "admin",
                Email = "admin@gmail.com",
                PhoneNumber = "+1 999 999 999",
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(adminUser, "p4s$W0rD123");
            if (result.Succeeded)
            {
                // Esto me asegura que el usuario se creo correctamente
                adminUser = await userManager.FindByEmailAsync(adminUser.Email);
                if (adminUser is not null)
                    await userManager.AddToRoleAsync(adminUser, Constantes.RolAdministrador);
            }
        }
    }
}
