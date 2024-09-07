using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RendicionGastos.Entities;
using RendicionGastos.Entities.Infos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace RendicionGastos.Repositories.Interfaces
{
    public interface IRendicionRepository : IRepositoryBase<Rendicion>
    {
        Task<ICollection<Rendicion>> ListarAsync();

        Task<(ICollection<RendicionInfo> Collection, int Total)> ListarRendicionesAsync(string? nombre, int? categoriaId, int? situacion, int pagina,
            int filas);

        Task<(ICollection<RendicionInfo> Collection, int Total)> ListarRendicionesHomeAsync(string? nombre, int? instructorId,
            DateOnly? fechaInicio, DateOnly? fechaFin, int pagina, int filas);

         
        Task<RendicionInfo?> ObtenerRendicionHomeAsync(int id);

        Task<ICollection<RendicionPorMesInfo>> ListarRendicionesPorMesAsync(int anio);

        Task<ICollection<RendicionPorEmpleadoInfo>> ListarRendicionesPorEmpleadoAsync(int anio);
    }
}
