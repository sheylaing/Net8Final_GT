using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.Shared.Response
{
    public class GastoPorCecoDtoResponse
    {
        public string CecoDescripcion { get; set; } = default!;
        public float Monto { get; set; }

    }
}
