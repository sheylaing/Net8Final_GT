using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RendicionGastos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendicionGastos.DataAccess.Configuraciones
{    
    public class RendicionConfiguration : IEntityTypeConfiguration<Rendicion>
    {
        public void Configure(EntityTypeBuilder<Rendicion> builder)
        {
            builder.HasQueryFilter(p => p.EliminadoBD!);
        }
    }
}
