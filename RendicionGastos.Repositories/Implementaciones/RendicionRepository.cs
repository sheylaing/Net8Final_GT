using Microsoft.EntityFrameworkCore;
using RendicionGastos.DataAccess;
using RendicionGastos.Entities;
using RendicionGastos.Entities.Infos;
using RendicionGastos.Repositories.Interfaces;
using System.Data;
using System.Globalization;
//using Dapper;

namespace RendicionGastos.Repositories.Implementaciones
{
    public class RendicionRepository(RendicionGastosDbContext context)
    : RepositoryBase<Rendicion>(context), IRendicionRepository
    {
        public async Task<ICollection<Rendicion>> ListarAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<(ICollection<RendicionInfo> Collection, int Total)> ListarRendicionesAsync(string? nombre, int? categoriaId, int? situacion, int pagina, int filas)
        {
            throw new NotImplementedException();
        }

        public async Task<(ICollection<RendicionInfo> Collection, int Total)> ListarRendicionesHomeAsync(string? nombre, int? instructorId, DateOnly? fechaInicio, DateOnly? fechaFin, int pagina, int filas)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<RendicionPorEmpleadoInfo>> ListarRendicionesPorEmpleadoAsync(int anio)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<RendicionPorMesInfo>> ListarRendicionesPorMesAsync(int anio)
        {
            throw new NotImplementedException();
        }

        public async Task<RendicionInfo?> ObtenerRendicionHomeAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
