using AutoMapper;
using RendicionGastos.Entities;
using RendicionGastos.Shared.Request;
using RendicionGastos.Shared.Response;

namespace RendicionGastos.Services.Profiles
{
    public class CentroCostoProfile :Profile
    {
        public CentroCostoProfile()
        {
            CreateMap<CentroCosto, CentroCostoDtoResponse>();

            CreateMap<CentroCostoDtoRequest, CentroCosto>()
                .ReverseMap();
        }
    }
}
