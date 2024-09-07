using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.Entities
{
    public class Rendicion :EntidadBase
    {
        public Empleado Empleado { get; set; } = default!;
        public int EmpleadoId { get; set; }
        public DateOnly FechaRendicion { get; set; }
        public string Glosa { get; set; } = null!;
        public float MontoAsignado { get; set; }
        public EstadoRendicion Estado { get; set; }
        //public float MontoRendido { get; set; }
        //public float Saldo { get; set; }


        public ICollection<RendicionDetalle> DetalleRendicion { get; set; } = new List<RendicionDetalle>();
                
    }
}
