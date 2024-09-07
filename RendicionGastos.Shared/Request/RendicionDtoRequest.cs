using RendicionGastos.Entities;

namespace RendicionGastos.Shared.Request
{
    public class RendicionDtoRequest
    {
        public Empleado Empleado { get; set; } = default!;
        public int EmpleadoId { get; set; }
        public DateOnly FechaRendicion { get; set; }
        public string Glosa { get; set; } = null!;
        public float MontoAsignado { get; set; }
        public EstadoRendicion Estado { get; set; }
    }
}
