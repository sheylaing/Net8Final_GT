using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.Entities
{
    public class Empleado :EntidadBase
    {
        public string NroDNI { get; set; } = null!;
        public string ApellidoPaterno { get; set; } = null!;
        public string ApellidoMaterno { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public string Sexo { get; set; } = "N";
        public float Salario { get; set; }
        public DateOnly FechaIngreso { get; set; }

        //
        public ICollection<Rendicion> Rendicion { get; set; } = new List<Rendicion>();
    }
}
