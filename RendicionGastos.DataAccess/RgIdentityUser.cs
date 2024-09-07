using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.DataAccess
{
    public class RgIdentityUser :IdentityUser
    {
        public string NombreCompleto { get; set; } = default!;
    }
}
