using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RendicionGastos.Services.Interfaces;
using RendicionGastos.Shared.Configuracion;
using RendicionGastos.Shared.Request;
using RendicionGastos.Shared.Response;
using RendicionGastos.Shared;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using RendicionGastos.DataAccess;

namespace RendicionGastos.Services.Implementaciones
{
    public class UserService : IUserService
    {
        private readonly UserManager<RgIdentityUser> _userManager;
        private readonly ILogger<UserService> _logger;
        private readonly IOptions<AppSettings> _options;
        //private readonly IEmpleadoRepository _empleadoRepository;
        private readonly IEmailService _emailService;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        public async Task<LoginDtoResponse> LoginAsync(LoginDtoRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseBase> RegisterAsync(RegistrarUsuarioDto request)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseBase> ResetPasswordAsync(ResetPassDtoRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseBase> SendTokenToResetPasswordAsync(GenerateTokenToResetDtoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
