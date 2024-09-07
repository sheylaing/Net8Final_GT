using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RendicionGastos.Entities
{
    public class EntidadBase
    {
       public int Id { get; set; }
        public bool EliminadoBD { get; set; }

        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }

        public DateTime? FechaActualizacion { get; set; }
        public string? UsuarioActualizacion { get; set; }


        protected EntidadBase()
        {
            EliminadoBD = false;
            FechaCreacion = DateTime.Now;
            UsuarioCreacion = Environment.UserName;
        }
    }
}
