using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppEntVC.Models;

namespace AppEntVC.Data
{
    public class CadMap : IEntityTypeConfiguration<CadSimples>
    {
        public void Configure (EntityTypeBuilder<CadSimples> builder)
        {
            builder.ToTable("CadSimples");
            builder.HasKey(x => x.Id);
            builder.Property(x =>x.CPF).IsRequired().HasMaxLength(15).HasColumnType("varchar(15)");
            builder.Property(x =>x.Nome).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(x =>x.Endereco).HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(x =>x.Telefone).HasMaxLength(18).HasColumnType("varchar(18)");
            builder.Property(x =>x.Genero).HasColumnType("int").HasDefaultValue(3);
        }
    }
}