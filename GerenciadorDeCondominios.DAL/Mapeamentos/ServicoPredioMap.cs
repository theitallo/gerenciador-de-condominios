using GerenciadorDeCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominios.DAL.Mapeamentos
{
    public class ServicoPredioMap : IEntityTypeConfiguration<ServicoPredio>
    {
        public void Configure(EntityTypeBuilder<ServicoPredio> builder)
        {
            builder.HasKey(sp => sp.ServicoPredioId);

            builder.Property(sp => sp.ServicoId).IsRequired();
            builder.HasOne(sp => sp.Servico).WithMany(sp => sp.ServicosPredio).HasForeignKey(sp => sp.ServicoId);

            builder.Property(sp => sp.DataExecucao).IsRequired();

            builder.ToTable("ServicosPredio");
        }
    }
}
