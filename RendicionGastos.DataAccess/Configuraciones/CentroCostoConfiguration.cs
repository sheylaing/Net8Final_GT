using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RendicionGastos.Entities;

namespace RendicionGastos.DataAccess.Configuraciones
{
    public class CentroCostoConfiguration : IEntityTypeConfiguration<CentroCosto>
    {
        public void Configure(EntityTypeBuilder<CentroCosto> builder)
        {
            var fecha = DateTime.Parse("2024-09-01");
            var usuario = "admin";

            builder.HasData(new List<CentroCosto>
        {
            new() { Id = 1, Descripcion = "Produccion", FechaCreacion = fecha, UsuarioCreacion = usuario},
            new() { Id = 2, Descripcion = "Administracion", FechaCreacion = fecha, UsuarioCreacion = usuario },
            new() { Id = 3, Descripcion = "Ventas", FechaCreacion = fecha, UsuarioCreacion = usuario },
            new() { Id = 4, Descripcion = "Finanzas", FechaCreacion = fecha, UsuarioCreacion = usuario },            
        });

            builder.HasQueryFilter(p => p.EliminadoBD!);
        }
    }
}
