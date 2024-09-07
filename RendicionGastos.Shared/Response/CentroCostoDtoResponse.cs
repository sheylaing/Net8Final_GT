using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.Shared.Response
{
    public class CentroCostoDtoResponse
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = default!;
    }
}
