using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer.Mappings
{
    public class RegistroEstacionamentoMapConfiguration : IEntityTypeConfiguration<RegistroEstacionamento>
    {
        public void Configure(EntityTypeBuilder<RegistroEstacionamento> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.HasOne(prop => prop.Veiculo)
                .WithMany()
                .HasForeignKey(prop => prop.Id);
        }
    }
}
