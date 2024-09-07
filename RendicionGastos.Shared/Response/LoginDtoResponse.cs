using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.Shared.Response
{
    public class LoginDtoResponse : ResponseBase
    {
        public string NombresCompletos { get; set; } = default!;
        public string Token { get; set; } = default!;

        public List<string> Roles { get; set; } = default!;
    }
}
