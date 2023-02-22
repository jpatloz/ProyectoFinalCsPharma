﻿// <auto-generated />
using System;
using DAL.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(CspharmaInformacionalContext))]
    [Migration("20230222105738_csPharma")]
    partial class csPharma
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DAL.Modelo.TdcCatEstadosDevolucionPedido", b =>
                {
                    b.Property<string>("CodEstadoDevolucion")
                        .HasColumnType("character varying")
                        .HasColumnName("cod_estado_devolucion");

                    b.Property<string>("DesEstadoDevolucion")
                        .HasColumnType("character varying")
                        .HasColumnName("des_estado_devolucion");

                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("MdDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("md_date");

                    b.Property<string>("MdUuid")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("md_uuid");

                    b.HasKey("CodEstadoDevolucion")
                        .HasName("tdc_cat_estados_devolucion_pedido_pkey");

                    b.ToTable("tdc_cat_estados_devolucion_pedido", "dwh_torrecontrol");
                });

            modelBuilder.Entity("DAL.Modelo.TdcCatEstadosEnvioPedido", b =>
                {
                    b.Property<string>("CodEstadoEnvio")
                        .HasColumnType("character varying")
                        .HasColumnName("cod_estado_envio");

                    b.Property<string>("DesEstadoEnvio")
                        .HasColumnType("character varying")
                        .HasColumnName("des_estado_envio");

                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("MdDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("md_date");

                    b.Property<string>("MdUuid")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("md_uuid");

                    b.HasKey("CodEstadoEnvio")
                        .HasName("tdc_cat_estados_envio_pedido_pkey");

                    b.ToTable("tdc_cat_estados_envio_pedido", "dwh_torrecontrol");
                });

            modelBuilder.Entity("DAL.Modelo.TdcCatEstadosPagoPedido", b =>
                {
                    b.Property<string>("CodEstadoPago")
                        .HasColumnType("character varying")
                        .HasColumnName("cod_estado_pago");

                    b.Property<string>("DesEstadoPago")
                        .HasColumnType("character varying")
                        .HasColumnName("des_estado_pago");

                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("MdDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("md_date");

                    b.Property<string>("MdUuid")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("md_uuid");

                    b.HasKey("CodEstadoPago")
                        .HasName("tdc_cat_estados_pago_pedido_pkey");

                    b.ToTable("tdc_cat_estados_pago_pedido", "dwh_torrecontrol");
                });

            modelBuilder.Entity("DAL.Modelo.TdcCatLineasDistribucion", b =>
                {
                    b.Property<string>("CodLinea")
                        .HasColumnType("character varying")
                        .HasColumnName("cod_linea");

                    b.Property<string>("CodBarrio")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("cod_barrio");

                    b.Property<string>("CodMunicipio")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("cod_municipio");

                    b.Property<string>("CodProvincia")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("cod_provincia");

                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("MdDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("md_date");

                    b.Property<string>("MdUuid")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("md_uuid");

                    b.HasKey("CodLinea")
                        .HasName("tdc_cat_lineas_distribucion_pkey");

                    b.ToTable("tdc_cat_lineas_distribucion", "dwh_torrecontrol");
                });

            modelBuilder.Entity("DAL.Modelo.TdcTchEstadoPedido", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CodEstadoDevolucion")
                        .HasColumnType("character varying")
                        .HasColumnName("Cod_estado_devolucion");

                    b.Property<string>("CodEstadoEnvio")
                        .HasColumnType("character varying")
                        .HasColumnName("Cod_estado_envio");

                    b.Property<string>("CodEstadoPago")
                        .HasColumnType("character varying")
                        .HasColumnName("Cod_estado_pago");

                    b.Property<string>("CodLinea")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("Cod_linea");

                    b.Property<string>("CodPedido")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Cod_pedido");

                    b.Property<DateTime>("MdDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("Md_date");

                    b.Property<string>("MdUuid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Md_uuid");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CodEstadoDevolucion" }, "IX_tdc_tch_estado_pedidos_Cod_estado_devolucion");

                    b.HasIndex(new[] { "CodEstadoEnvio" }, "IX_tdc_tch_estado_pedidos_Cod_estado_envio");

                    b.HasIndex(new[] { "CodEstadoPago" }, "IX_tdc_tch_estado_pedidos_Cod_estado_pago");

                    b.HasIndex(new[] { "CodLinea" }, "IX_tdc_tch_estado_pedidos_Cod_linea");

                    b.ToTable("tdc_tch_estado_pedidos", "dwh_torrecontrol");
                });

            modelBuilder.Entity("DAL.Modelo.TdcTchEstadoPedido", b =>
                {
                    b.HasOne("DAL.Modelo.TdcCatEstadosDevolucionPedido", "CodEstadoDevolucionNavigation")
                        .WithMany("TdcTchEstadoPedido")
                        .HasForeignKey("CodEstadoDevolucion")
                        .HasConstraintName("FK_Tdc_tch_estado_pedidos_Tdc_cat_estados_devolucion_pedido_Co~");

                    b.HasOne("DAL.Modelo.TdcCatEstadosEnvioPedido", "CodEstadoEnvioNavigation")
                        .WithMany("TdcTchEstadoPedido")
                        .HasForeignKey("CodEstadoEnvio")
                        .HasConstraintName("FK_Tdc_tch_estado_pedidos_Tdc_cat_estados_envio_pedido_Cod_est~");

                    b.HasOne("DAL.Modelo.TdcCatEstadosPagoPedido", "CodEstadoPagoNavigation")
                        .WithMany("TdcTchEstadoPedido")
                        .HasForeignKey("CodEstadoPago")
                        .HasConstraintName("FK_Tdc_tch_estado_pedidos_Tdc_cat_estados_pago_pedido_Cod_esta~");

                    b.HasOne("DAL.Modelo.TdcCatLineasDistribucion", "CodLineaNavigation")
                        .WithMany("TdcTchEstadoPedido")
                        .HasForeignKey("CodLinea")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodEstadoDevolucionNavigation");

                    b.Navigation("CodEstadoEnvioNavigation");

                    b.Navigation("CodEstadoPagoNavigation");

                    b.Navigation("CodLineaNavigation");
                });

            modelBuilder.Entity("DAL.Modelo.TdcCatEstadosDevolucionPedido", b =>
                {
                    b.Navigation("TdcTchEstadoPedido");
                });

            modelBuilder.Entity("DAL.Modelo.TdcCatEstadosEnvioPedido", b =>
                {
                    b.Navigation("TdcTchEstadoPedido");
                });

            modelBuilder.Entity("DAL.Modelo.TdcCatEstadosPagoPedido", b =>
                {
                    b.Navigation("TdcTchEstadoPedido");
                });

            modelBuilder.Entity("DAL.Modelo.TdcCatLineasDistribucion", b =>
                {
                    b.Navigation("TdcTchEstadoPedido");
                });
#pragma warning restore 612, 618
        }
    }
}