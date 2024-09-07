using RendicionGastos.Shared.Request;
using RendicionGastos.Shared.Response;

namespace RendicionGastos.Services.Interfaces
{
    public interface IUserService
    {
        Task<LoginDtoResponse> LoginAsync(LoginDtoRequest request);

        Task<ResponseBase> RegisterAsync(RegistrarUsuarioDto request);

        Task<ResponseBase> SendTokenToResetPasswordAsync(GenerateTokenToResetDtoRequest request);

        Task<ResponseBase> ResetPasswordAsync(ResetPassDtoRequest request);
    }
}
