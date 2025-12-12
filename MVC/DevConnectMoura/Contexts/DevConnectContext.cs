using System;
using System.Collections.Generic;
using DevConnectMoura.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Contexts;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbComentario> TbComentario { get; set; }

    public virtual DbSet<TbCurtida> TbCurtida { get; set; }

    public virtual DbSet<TbPublicacao> TbPublicacao { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_Windows");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbComentario>(entity =>
        {
            entity.HasKey(e => e.IdComentario).HasName("PK__tb_comen__1BA6C6F478BE2CB3");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbComentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_coment__id_pu__5070F446");
        });

        modelBuilder.Entity<TbCurtida>(entity =>
        {
            entity.HasKey(e => e.IdCurtida).HasName("PK__tb_curti__0AC033CACD0584F6");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbCurtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__id_pu__5441852A");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbCurtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__id_us__534D60F1");
        });

        modelBuilder.Entity<TbPublicacao>(entity =>
        {
            entity.HasKey(e => e.IdPublicacao).HasName("PK__tb_publi__EA81BC3A34115A02");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbPublicacao).HasConstraintName("FK__tb_public__id_us__4D94879B");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__tb_usuar__4E3E04AD2FB2E1B0");

            entity.HasMany(d => d.IdSeguidor).WithMany(p => p.IdSeguindo)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_se__571DF1D5"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdSeguindo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_se__5812160E"),
                    j =>
                    {
                        j.HasKey("IdSeguindo", "IdSeguidor").HasName("PK__tb_segui__48B8147568DEEE3C");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdSeguindo").HasColumnName("id_seguindo");
                        j.IndexerProperty<int>("IdSeguidor").HasColumnName("id_seguidor");
                    });

            entity.HasMany(d => d.IdSeguindo).WithMany(p => p.IdSeguidor)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdSeguindo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_se__5812160E"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_se__571DF1D5"),
                    j =>
                    {
                        j.HasKey("IdSeguindo", "IdSeguidor").HasName("PK__tb_segui__48B8147568DEEE3C");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdSeguindo").HasColumnName("id_seguindo");
                        j.IndexerProperty<int>("IdSeguidor").HasColumnName("id_seguidor");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
