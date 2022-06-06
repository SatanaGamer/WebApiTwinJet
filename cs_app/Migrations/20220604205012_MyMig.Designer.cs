﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using cs_app.Data;

#nullable disable

namespace cs_app.Migrations
{
    [DbContext(typeof(EducationContext))]
    [Migration("20220604205012_MyMig")]
    partial class MyMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AviaBooking", b =>
                {
                    b.Property<long>("AviasId")
                        .HasColumnType("bigint")
                        .HasColumnName("avias_id");

                    b.Property<long>("BookingsId")
                        .HasColumnType("bigint")
                        .HasColumnName("bookings_id");

                    b.HasKey("AviasId", "BookingsId")
                        .HasName("pk_avia_booking");

                    b.HasIndex("BookingsId")
                        .HasDatabaseName("ix_avia_booking_bookings_id");

                    b.ToTable("avia_booking", (string)null);
                });

            modelBuilder.Entity("AviaPassenger", b =>
                {
                    b.Property<long>("AviasId")
                        .HasColumnType("bigint")
                        .HasColumnName("avias_id");

                    b.Property<long>("PassengersId")
                        .HasColumnType("bigint")
                        .HasColumnName("passengers_id");

                    b.HasKey("AviasId", "PassengersId")
                        .HasName("pk_avia_passenger");

                    b.HasIndex("PassengersId")
                        .HasDatabaseName("ix_avia_passenger_passengers_id");

                    b.ToTable("avia_passenger", (string)null);
                });

            modelBuilder.Entity("BookingPassenger", b =>
                {
                    b.Property<long>("BookingsId")
                        .HasColumnType("bigint")
                        .HasColumnName("bookings_id");

                    b.Property<long>("PassengersId")
                        .HasColumnType("bigint")
                        .HasColumnName("passengers_id");

                    b.HasKey("BookingsId", "PassengersId")
                        .HasName("pk_booking_passenger");

                    b.HasIndex("PassengersId")
                        .HasDatabaseName("ix_booking_passenger_passengers_id");

                    b.ToTable("booking_passenger", (string)null);
                });

            modelBuilder.Entity("cs_app.Data.Models.Avia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasColumnOrder(1);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("country");

                    b.Property<string>("Dest")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("dest");

                    b.Property<int>("Flight")
                        .HasColumnType("integer")
                        .HasColumnName("flight");

                    b.Property<int>("NumPass")
                        .HasColumnType("integer")
                        .HasColumnName("num_pass");

                    b.Property<int>("Place")
                        .HasColumnType("integer")
                        .HasColumnName("place");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.HasKey("Id")
                        .HasName("pk_avias");

                    b.ToTable("avias", (string)null);
                });

            modelBuilder.Entity("cs_app.Data.Models.Booking", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasColumnOrder(1);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("car_name");

                    b.Property<string>("GuideName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("guide_name");

                    b.Property<string>("Hotel")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("hotel");

                    b.Property<int>("Room")
                        .HasColumnType("integer")
                        .HasColumnName("room");

                    b.HasKey("Id")
                        .HasName("pk_bookings");

                    b.ToTable("bookings", (string)null);
                });

            modelBuilder.Entity("cs_app.Data.Models.Passenger", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasColumnOrder(1);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<int>("Doc")
                        .HasColumnType("integer")
                        .HasColumnName("doc");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("SecName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("sec_name");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.HasKey("Id")
                        .HasName("pk_passengers");

                    b.ToTable("passengers", (string)null);
                });

            modelBuilder.Entity("AviaBooking", b =>
                {
                    b.HasOne("cs_app.Data.Models.Avia", null)
                        .WithMany()
                        .HasForeignKey("AviasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_avia_booking_avias_avias_id");

                    b.HasOne("cs_app.Data.Models.Booking", null)
                        .WithMany()
                        .HasForeignKey("BookingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_avia_booking_bookings_bookings_id");
                });

            modelBuilder.Entity("AviaPassenger", b =>
                {
                    b.HasOne("cs_app.Data.Models.Avia", null)
                        .WithMany()
                        .HasForeignKey("AviasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_avia_passenger_avias_avias_id");

                    b.HasOne("cs_app.Data.Models.Passenger", null)
                        .WithMany()
                        .HasForeignKey("PassengersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_avia_passenger_passengers_passengers_id");
                });

            modelBuilder.Entity("BookingPassenger", b =>
                {
                    b.HasOne("cs_app.Data.Models.Booking", null)
                        .WithMany()
                        .HasForeignKey("BookingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_booking_passenger_bookings_bookings_id");

                    b.HasOne("cs_app.Data.Models.Passenger", null)
                        .WithMany()
                        .HasForeignKey("PassengersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_booking_passenger_passengers_passengers_id");
                });
#pragma warning restore 612, 618
        }
    }
}
