using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.Shared.Response
{
    public class RendicionPorEmpleadoDtoResponse
    {
        public string EmpleadoNombre { get; set; } = default!;
        public int Cantidad { get; set; }
    }
}
