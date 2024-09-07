using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RendicionGastos.Entities;

namespace RendicionGastos.DataAccess.Configuraciones
{
    public class ConceptoConfiguration : IEntityTypeConfiguration<Concepto>
    {
        public void Configure(EntityTypeBuilder<Concepto> builder)
        {
            builder.HasQueryFilter(propa => propa.EliminadoBD!);
        }
    }
}
