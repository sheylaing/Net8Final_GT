using RendicionGastos.DataAccess;
using RendicionGastos.Entities;
using RendicionGastos.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.Repositories.Implementaciones
{
    public class CentroCostoRepository : RepositoryBase<CentroCosto>, ICentroCostoRepository
    {
        public CentroCostoRepository(RendicionGastosDbContext context) : base(context)
        { 
        }
    }
}
