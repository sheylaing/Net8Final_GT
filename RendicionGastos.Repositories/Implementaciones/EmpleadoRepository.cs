using RendicionGastos.DataAccess;
using RendicionGastos.Entities;
using RendicionGastos.Repositories.Interfaces;

namespace RendicionGastos.Repositories.Implementaciones
{
    public class EmpleadoRepository : RepositoryBase<Empleado>, IEmpleadoRepository
    {
        public EmpleadoRepository(RendicionGastosDbContext context) : base(context)
        {
        }
    }
}
