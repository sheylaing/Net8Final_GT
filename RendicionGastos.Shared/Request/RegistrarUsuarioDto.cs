using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.Shared.Request
{
    public  class RegistrarUsuarioDto
    {
        [Required]
        public string Usuario { get; set; } = default!;

        [Required]
        public string NombresCompleto { get; set; } = default!;

        [EmailAddress]
        public string Email { get; set; } = default!;

        [Required]
        public string Telefono { get; set; } = default!;

        [Required]
        public string NroDocumento { get; set; } = default!;

        [Required]
        public string Password { get; set; } = default!;

        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = default!;

    }
}
