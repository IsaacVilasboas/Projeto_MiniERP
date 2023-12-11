using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjetoMiniERP
{
    public partial class MiniERPContext : DbContext
    {
        public MiniERPContext()
        {
        }

        public MiniERPContext(DbContextOptions<MiniERPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Fornecedore> Fornecedores { get; set; } = null!;
        public virtual DbSet<Nota> Notas { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost; initial Catalog=MiniERP;User ID=sa;password=Senha1234#;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cpf)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cpf");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Fornecedore>(entity =>
            {
                entity.ToTable("fornecedores");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cnpj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cnpj");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Nota>(entity =>
            {
                entity.ToTable("notas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FkClientes).HasColumnName("fk_clientes");

                entity.Property(e => e.FkProdutos).HasColumnName("fk_produtos");

                entity.HasOne(d => d.FkClientesNavigation)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.FkClientes)
                    .HasConstraintName("FK__notas__fk_client__3F466844");

                entity.HasOne(d => d.FkProdutosNavigation)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.FkProdutos)
                    .HasConstraintName("FK__notas__fk_produt__3E52440B");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("produtos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FkFornecedores).HasColumnName("fk_fornecedores");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Preco).HasColumnName("preco");

                entity.HasOne(d => d.FkFornecedoresNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.FkFornecedores)
                    .HasConstraintName("FK__produtos__fk_for__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
