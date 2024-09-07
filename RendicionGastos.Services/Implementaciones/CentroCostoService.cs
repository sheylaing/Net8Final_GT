using AutoMapper;
using Microsoft.Extensions.Logging;
using RendicionGastos.Entities;
using RendicionGastos.Repositories.Interfaces;
using RendicionGastos.Services.Interfaces;
using RendicionGastos.Services.Utiles;
using RendicionGastos.Shared.Request;
using RendicionGastos.Shared.Response;

namespace RendicionGastos.Services.Implementaciones
{
    public class CentroCostoService : ICentroCostoService
    {

        private readonly ICentroCostoRepository _repository;
        private readonly ILogger<CentroCostoService> _logger;
        private readonly IMapper _mapper;
        public CentroCostoService(ICentroCostoRepository repository, ILogger<CentroCostoService> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseBaseGeneric<ICollection<CentroCostoDtoResponse>>> ListAsync()
        {
            var response = new ResponseBaseGeneric<ICollection<CentroCostoDtoResponse>>();
            try
            {
                var collection = await _repository.ListAsync();
                response.Data = _mapper.Map<ICollection<CentroCostoDtoResponse>>(collection);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Error al listar los centros de costo";
                _logger.LogCritical(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }
            return response;
        }

        public async Task<ResponseBaseGeneric<CentroCostoDtoRequest>> FindByIdAsync(int id)
        {
            var response = new ResponseBaseGeneric<CentroCostoDtoRequest>();
            try
            {
                var entity = await _repository.FindByIdAsync(id);
                if (entity is null)
                {
                    response.ErrorMessage = "No se encontró el registro";
                    return response;
                }

                response.Data = _mapper.Map<CentroCostoDtoRequest>(entity);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Error al encontrar el centro de costo";
                _logger.LogCritical(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }
            return response;
        }

        public async Task<ResponseBase> AddAsync(CentroCostoDtoRequest request, string usuario)
        {
            var response = new ResponseBase();

            try
            {
                var entity = _mapper.Map<CentroCosto>(request);
                entity.InsertarAuditoria(usuario);
                await _repository.AddAsync(entity);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Error al agregar el centro costo";
                _logger.LogCritical(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }

            return response;
        }
        
        public async Task<ResponseBase> UpdateAsync(int id, CentroCostoDtoRequest request, string usuario)
        {
            var response = new ResponseBase();

            try
            {
                var entity = await _repository.FindByIdAsync(id);
                if (entity is null)
                {
                    response.ErrorMessage = "No se encontro el centro de costo";
                    return response;
                }

                _mapper.Map(request, entity);
                entity.ActualizarAuditoria(usuario);
                await _repository.UpdateAsync();
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Error al actualizar el centro costo";
                _logger.LogCritical(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }

            return response;
        }
        public async Task<ResponseBase> DeleteAsync(int id)
        {
            var response = new ResponseBase();

            try
            {
                await _repository.DeleteAsync(id);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Error al eliminar el centro de costo";
                _logger.LogCritical(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }

            return response;
        }
    }
}
