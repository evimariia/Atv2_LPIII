using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.MODEL;
//namespace CashFlow.DAL.DBContext;

public partial class CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext : DbContext
{
    public CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext()
    {
    }

    public CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext(DbContextOptions<CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Extrato> Extratos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Atv2_LPIII\\CashFlow.DAL\\database\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC0742EC34EA");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Extrato>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Extrato__3214EC072D22678D");

            entity.ToTable("Extrato");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Data)
                .HasColumnType("date")
                .HasColumnName("data");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("valor");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Extratos)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK2_extrato_ToTable");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Extratos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_extrato_ToTable");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC0795EC9C0C");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Login)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Senha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("senha");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
