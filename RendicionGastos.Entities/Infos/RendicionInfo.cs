using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.Entities.Infos
{
    public class RendicionInfo
    {
        public string EmpleadoNombre { get; set; } = default!;
        public DateOnly FechaRendicion { get; set; }
        public string Glosa { get; set; } = default!;
        public float MontoAsignado { get; set; }
        public string EstadoDescripcion { get; set; }
    }
}
