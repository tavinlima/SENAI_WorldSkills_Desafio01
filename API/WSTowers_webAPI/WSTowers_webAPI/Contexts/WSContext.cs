using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WSTowers_webAPI.Domains;

#nullable disable

namespace WSTowers_webAPI.Contexts
{
    public partial class WSContext : DbContext
    {
        public WSContext()
        {
        }

        public WSContext(DbContextOptions<WSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Estoque> Estoques { get; set; }
        public virtual DbSet<Loja> Lojas { get; set; }
        public virtual DbSet<Participante> Participantes { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Regiao> Regiaos { get; set; }
        public virtual DbSet<Venda> Vendas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8FOKHBA\\SQLEXPRESS; initial catalog=WSTowers; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.ToTable("categoria");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(255)
                    .HasColumnName("categoria");
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.ToTable("cidade");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cidade1)
                    .HasMaxLength(255)
                    .HasColumnName("cidade");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Cidades)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_cidade_estado");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.ToTable("estado");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Estado1)
                    .HasMaxLength(255)
                    .HasColumnName("estado");

                entity.Property(e => e.Regiao).HasColumnName("regiao");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(255)
                    .HasColumnName("sigla");

                entity.HasOne(d => d.RegiaoNavigation)
                    .WithMany(p => p.Estados)
                    .HasForeignKey(d => d.Regiao)
                    .HasConstraintName("FK_estado_regiao");
            });

            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.ToTable("estoque");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Loja).HasColumnName("loja");

                entity.Property(e => e.Produto).HasColumnName("produto");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.HasOne(d => d.ProdutoNavigation)
                    .WithMany(p => p.Estoques)
                    .HasForeignKey(d => d.Produto)
                    .HasConstraintName("FK_estoque_produto");
            });

            modelBuilder.Entity<Loja>(entity =>
            {
                entity.ToTable("loja");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Loja1)
                    .HasMaxLength(255)
                    .HasColumnName("loja");
            });

            modelBuilder.Entity<Participante>(entity =>
            {
                entity.ToTable("participante");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cidade).HasColumnName("cidade");

                entity.Property(e => e.Genero)
                    .HasMaxLength(255)
                    .HasColumnName("genero");

                entity.Property(e => e.Idade).HasColumnName("idade");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .HasColumnName("nome");

                entity.HasOne(d => d.CidadeNavigation)
                    .WithMany(p => p.Participantes)
                    .HasForeignKey(d => d.Cidade)
                    .HasConstraintName("FK_participante_cidade");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("produto");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Categoria).HasColumnName("categoria");

                entity.Property(e => e.Produto1)
                    .HasMaxLength(255)
                    .HasColumnName("produto");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.CategoriaNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.Categoria)
                    .HasConstraintName("FK_produto_categoria");
            });

            modelBuilder.Entity<Regiao>(entity =>
            {
                entity.ToTable("regiao");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Regiao1)
                    .HasMaxLength(255)
                    .HasColumnName("regiao");
            });

            modelBuilder.Entity<Venda>(entity =>
            {
                entity.ToTable("vendas");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Hora)
                    .HasColumnType("datetime")
                    .HasColumnName("hora");

                entity.Property(e => e.Loja).HasColumnName("loja");

                entity.Property(e => e.Participante).HasColumnName("participante");

                entity.Property(e => e.Produto).HasColumnName("produto");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.Property(e => e.Transacao).HasColumnName("transacao");

                entity.HasOne(d => d.LojaNavigation)
                    .WithMany(p => p.Venda)
                    .HasForeignKey(d => d.Loja)
                    .HasConstraintName("FK_vendas_loja");

                entity.HasOne(d => d.ParticipanteNavigation)
                    .WithMany(p => p.Venda)
                    .HasForeignKey(d => d.Participante)
                    .HasConstraintName("FK_vendas_participante");

                entity.HasOne(d => d.ProdutoNavigation)
                    .WithMany(p => p.Venda)
                    .HasForeignKey(d => d.Produto)
                    .HasConstraintName("FK_vendas_produto");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
