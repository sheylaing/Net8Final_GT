using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.Shared.Request
{
    public  class CentroCostoDtoRequest
    {
        [Required(ErrorMessage = Constantes.CampoRequerido)]
        [StringLength(100, ErrorMessage = Constantes.CampoLargo)]
        public string Descripcion { get; set; } = default!;
    }
}
