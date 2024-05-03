using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings
{
    public class VigenciaPrecoMapConfiguration : IEntityTypeConfiguration<VigenciaPreco>
    {
        public void Configure(EntityTypeBuilder<VigenciaPreco> builder)
        {
            builder.HasKey(prop => prop.Id);
        }
    }
}
