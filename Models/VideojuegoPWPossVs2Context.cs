using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApiWpossVideojuegos.Models
{
    public partial class VideojuegoPWPossVs2Context : DbContext
    {
        public VideojuegoPWPossVs2Context()
        {
        }

        public VideojuegoPWPossVs2Context(DbContextOptions<VideojuegoPWPossVs2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetalleVentum> DetalleVenta { get; set; }
        public virtual DbSet<VentaAlquiler> VentaAlquilers { get; set; }
        public virtual DbSet<VideoJuego> VideoJuegos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-5LDDOSM;Database=VideojuegoPWPossVs2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .HasColumnName("direccion");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Nit)
                    .HasMaxLength(50)
                    .HasColumnName("nit");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<DetalleVentum>(entity =>
            {
                entity.HasKey(e => e.IdDetalle);

                entity.Property(e => e.IdDetalle).HasColumnName("idDetalle");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("descuento");

                entity.Property(e => e.FechaVenta)
                    .HasColumnType("date")
                    .HasColumnName("fechaVenta");

                entity.Property(e => e.IdVenta).HasColumnName("idVenta");

                entity.Property(e => e.IdVideoGame).HasColumnName("idVideoGame");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("precio");

                entity.Property(e => e.TipoVenta).HasColumnName("tipoVenta");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.IdVenta)
                    .HasConstraintName("FK__DetalleVe__idVen__3F466844");

                entity.HasOne(d => d.IdVideoGameNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.IdVideoGame)
                    .HasConstraintName("FK__DetalleVe__idVid__3E52440B");
            });

            modelBuilder.Entity<VentaAlquiler>(entity =>
            {
                entity.HasKey(e => e.IdVenta);

                entity.ToTable("VentaAlquiler");

                entity.Property(e => e.IdVenta).HasColumnName("idVenta");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("date")
                    .HasColumnName("fechaEntrega");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Impuesto)
                    .HasMaxLength(10)
                    .HasColumnName("impuesto")
                    .IsFixedLength(true);

                entity.Property(e => e.NumComprobante)
                    .HasMaxLength(50)
                    .HasColumnName("numComprobante");

                entity.Property(e => e.SerieComprobante)
                    .HasMaxLength(50)
                    .HasColumnName("serieComprobante");

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(50)
                    .HasColumnName("tipoComprobante");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.VentaAlquilers)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__VentaAlqu__idCli__3D5E1FD2");
            });

            modelBuilder.Entity<VideoJuego>(entity =>
            {
                entity.HasKey(e => e.IdVideoJuego);

                entity.Property(e => e.IdVideoJuego).HasColumnName("idVideoJuego");

                entity.Property(e => e.Año)
                    .HasMaxLength(50)
                    .HasColumnName("año");

                entity.Property(e => e.Director)
                    .HasMaxLength(50)
                    .HasColumnName("director");

                entity.Property(e => e.IdDetalle).HasColumnName("idDetalle");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("imagen");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Productor)
                    .HasMaxLength(50)
                    .HasColumnName("productor");

                entity.Property(e => e.Protagonista)
                    .HasMaxLength(50)
                    .HasColumnName("protagonista");

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.Property(e => e.Tecnologia)
                    .HasMaxLength(50)
                    .HasColumnName("tecnologia");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(50)
                    .HasColumnName("titulo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
