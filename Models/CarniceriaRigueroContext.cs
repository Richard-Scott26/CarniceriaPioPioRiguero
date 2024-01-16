using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoBasic.Models
{
    public partial class CarniceriaRigueroContext : DbContext
    {
        public CarniceriaRigueroContext()
        {
        }

        public CarniceriaRigueroContext(DbContextOptions<CarniceriaRigueroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; } = null!;
        public virtual DbSet<Compra> Compras { get; set; } = null!;
        public virtual DbSet<DetalleCompra> DetalleCompras { get; set; } = null!;
        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;
        public virtual DbSet<Subcategoria> Subcategorias { get; set; } = null!;
        public virtual DbSet<Venta> Ventas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=PC_Scott;Initial Catalog=CarniceriaRiguero;Integrated Security=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.Idcategoria)
                    .HasName("PK__Categori__ADC0E719870C18D0");

                entity.ToTable("Categorias", "Produccion");

                entity.Property(e => e.Idcategoria).HasColumnName("IDCATEGORIA");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.Idcompra)
                    .HasName("PK__Compras__DC4C123ADD0050CE");

                entity.ToTable("Compras", "Compras");

                entity.Property(e => e.Idcompra).HasColumnName("IDCOMPRA");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DESCUENTO");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Idproveedor).HasColumnName("IDPROVEEDOR");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SUBTOTAL");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TOTAL");

                entity.HasOne(d => d.IdproveedorNavigation)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.Idproveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Compras__IDPROVE__38996AB5");
            });

            modelBuilder.Entity<DetalleCompra>(entity =>
            {
                entity.HasKey(e => new { e.Iddetallecompra, e.Idcompra })
                    .HasName("PK__DetalleC__2E278F15FA7A14FA");

                entity.ToTable("DetalleCompras", "Compras");

                entity.Property(e => e.Iddetallecompra)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDDETALLECOMPRA");

                entity.Property(e => e.Idcompra).HasColumnName("IDCOMPRA");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DESCUENTO");

                entity.Property(e => e.Idproducto).HasColumnName("IDPRODUCTO");

                entity.Property(e => e.Preciocompra)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRECIOCOMPRA");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SUBTOTAL");

                entity.HasOne(d => d.IdcompraNavigation)
                    .WithMany(p => p.DetalleCompras)
                    .HasForeignKey(d => d.Idcompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleCo__IDCOM__3B75D760");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.DetalleCompras)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleCo__IDPRO__3C69FB99");
            });

            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.HasKey(e => new { e.Iddetalleventa, e.Idventa })
                    .HasName("PK__DetalleV__D99254E18056946C");

                entity.ToTable("DetalleVentas", "Ventas");

                entity.Property(e => e.Iddetalleventa)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDDETALLEVENTA");

                entity.Property(e => e.Idventa).HasColumnName("IDVENTA");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DESCUENTO");

                entity.Property(e => e.Idproducto).HasColumnName("IDPRODUCTO");

                entity.Property(e => e.Precioventa)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRECIOVENTA");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SUBTOTAL");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleVe__IDPRO__32E0915F");

                entity.HasOne(d => d.IdventaNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.Idventa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleVe__IDVEN__31EC6D26");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Idproducto)
                    .HasName("PK__Producto__7D8DC0F174511ACB");

                entity.ToTable("Productos", "Produccion");

                entity.HasIndex(e => e.Codigo, "UQ__Producto__CC87E126507C5B0B")
                    .IsUnique();

                entity.Property(e => e.Idproducto).HasColumnName("IDPRODUCTO");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(255)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Existencia).HasColumnName("EXISTENCIA");

                entity.Property(e => e.Idsubcategoria).HasColumnName("IDSUBCATEGORIA");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Numero)
                    .HasMaxLength(100)
                    .HasColumnName("NUMERO");

                entity.Property(e => e.PrecioCompra)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRECIO_COMPRA");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRECIO_VENTA");

                entity.HasOne(d => d.IdsubcategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Idsubcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Productos__IDSUB__2C3393D0");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.Idproveedor)
                    .HasName("PK__Proveedo__4EB245E4D5AF766D");

                entity.ToTable("Proveedores", "Compras");

                entity.Property(e => e.Idproveedor).HasColumnName("IDPROVEEDOR");

                entity.Property(e => e.Celular)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CELULAR")
                    .IsFixedLength();

                entity.Property(e => e.Compañia)
                    .HasMaxLength(100)
                    .HasColumnName("COMPAÑIA");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombrecontacto)
                    .HasMaxLength(100)
                    .HasColumnName("NOMBRECONTACTO");

                entity.Property(e => e.Paginaweb)
                    .HasMaxLength(200)
                    .HasColumnName("PAGINAWEB");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO")
                    .IsFixedLength();

                entity.Property(e => e.Titulocontacto)
                    .HasMaxLength(100)
                    .HasColumnName("TITULOCONTACTO");
            });

            modelBuilder.Entity<Subcategoria>(entity =>
            {
                entity.HasKey(e => e.Idsubcategoria)
                    .HasName("PK__Subcateg__361848F7927FC8B1");

                entity.ToTable("Subcategorias", "Produccion");

                entity.Property(e => e.Idsubcategoria).HasColumnName("IDSUBCATEGORIA");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Idcategoria).HasColumnName("IDCATEGORIA");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("NOMBRE");

                entity.HasOne(d => d.IdcategoriaNavigation)
                    .WithMany(p => p.Subcategoria)
                    .HasForeignKey(d => d.Idcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Subcatego__IDCAT__276EDEB3");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.Idventa)
                    .HasName("PK__Ventas__2849CB577A0AE3F7");

                entity.ToTable("Ventas", "Ventas");

                entity.Property(e => e.Idventa).HasColumnName("IDVENTA");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DESCUENTO");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SUBTOTAL");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TOTAL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
