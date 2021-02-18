using GerenciadorDeCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominios.DAL.Mapeamentos
{
    public class HistoricoRecursoMap : IEntityTypeConfiguration<HistoricoRecurso>
    {
        public void Configure(EntityTypeBuilder<HistoricoRecurso> builder)
        {
            builder.HasKey(hr => hr.HistoricoRecursoId);
            builder.Property(hr => hr.Valor).IsRequired();
            builder.Property(hr => hr.Tipo).IsRequired();
            builder.Property(hr => hr.Dia).IsRequired();

            builder.Property(hr => hr.MesId).IsRequired();
            builder.HasOne(hr => hr.Mes).WithMany(hr => hr.HistoricoRecursos).HasForeignKey(hr => hr.MesId);

            builder.Property(hr => hr.Ano).IsRequired();

            builder.ToTable("HistoricoRecursos");
        }
    }
}
