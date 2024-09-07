﻿using Microsoft.AspNetCore.Mvc;
using RendicionGastos.Services.Interfaces;
using RendicionGastos.Shared.Request;

namespace RendicionGastos.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IUserService service, ILogger<UsersController> logger)
        {
            _service = service;
            _logger = logger;
        }

        // POST: api/Usuarios/Login
        [HttpPost]
        public async Task<IActionResult> Login(LoginDtoRequest request)
        {
            var response = await _service.LoginAsync(request);

            _logger.LogInformation("Se inicio sesion desde {RequestID}", HttpContext.Connection.Id);

            return response.Success ? Ok(response) : Unauthorized(response);
        }

        // POST: api/Usuarios/Register
        [HttpPost]
        public async Task<IActionResult> Register(RegistrarUsuarioDto request)
        {
            var response = await _service.RegisterAsync(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> SendTokenToResetPassword(GenerateTokenToResetDtoRequest request)
        {
            var response = await _service.SendTokenToResetPasswordAsync(request);
            return response.Success ? Ok(response) : BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPassDtoRequest request)
        {
            return Ok(await _service.ResetPasswordAsync(request));
        }

    }
}
