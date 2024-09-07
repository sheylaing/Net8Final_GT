using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.Entities
{
    public class RendicionDetalle :EntidadBase
    {
        public Rendicion Rendicion { get; set; } = default!;
        public int RendicionId { get; set; }
        public DateOnly FechaDocumento { get; set; }
        public TipoDocumento TipoDoc { get; set; } 
        public string NumeroDocumento { get; set; } = null!;
        public string Proveedor { get; set; } = default!;
        public Concepto Concepto { get; set; } = default!;
        public int ConceptoId { get; set; }
        public string? GlosaDetalle { get; set; }
        public float Monto { get; set; }
        
    }    
}
