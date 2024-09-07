using RendicionGastos.Shared.Request;
using RendicionGastos.Shared.Response;


namespace RendicionGastos.Services.Interfaces
{
    public interface ICentroCostoService
    {
        Task<ResponseBaseGeneric<ICollection<CentroCostoDtoResponse>>> ListAsync();
        Task<ResponseBaseGeneric<CentroCostoDtoRequest>> FindByIdAsync(int id);
        Task<ResponseBase> AddAsync(CentroCostoDtoRequest request, string usuario);
        Task<ResponseBase> UpdateAsync(int id, CentroCostoDtoRequest request, string usuario);
        Task<ResponseBase> DeleteAsync(int id);

    }
}
