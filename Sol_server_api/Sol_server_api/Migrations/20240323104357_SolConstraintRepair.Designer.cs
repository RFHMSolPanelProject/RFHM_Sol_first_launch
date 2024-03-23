﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sol_server_api.Data;

#nullable disable

namespace Sol_server_api.Migrations
{
    [DbContext(typeof(SolContext))]
    [Migration("20240323104357_SolConstraintRepair")]
    partial class SolConstraintRepair
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoworkerProject", b =>
                {
                    b.Property<string>("CoworkersCoworkerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProjectID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CoworkersCoworkerID", "ProjectID");

                    b.HasIndex("ProjectID");

                    b.ToTable("CoworkerProject");
                });

            modelBuilder.Entity("Sol_server_api.Entities.Compartment", b =>
                {
                    b.Property<string>("CompartmentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Bracket")
                        .HasColumnType("int");

                    b.Property<int>("Col")
                        .HasColumnType("int");

                    b.Property<string>("FKComponentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaximumPiece")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.Property<string>("StoragedComponentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StoragedPiece")
                        .HasColumnType("int");

                    b.HasKey("CompartmentID");

                    b.HasIndex("FKComponentID")
                        .IsUnique()
                        .HasFilter("[FKComponentID] IS NOT NULL");

                    b.ToTable("rekesz", (string)null);
                });

            modelBuilder.Entity("Sol_server_api.Entities.Component", b =>
                {
                    b.Property<string>("ComponentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompartmentID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComponentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FKPackageID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("StockStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComponentID");

                    b.HasIndex("FKPackageID");

                    b.ToTable("alkatresz", (string)null);
                });

            modelBuilder.Entity("Sol_server_api.Entities.Coworker", b =>
                {
                    b.Property<string>("CoworkerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CoworkerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLKLoginID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PLKPermission")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PLKTelNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CoworkerID");

                    b.ToTable("munkatars_fo", (string)null);
                });

            modelBuilder.Entity("Sol_server_api.Entities.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("megrendelo", (string)null);
                });

            modelBuilder.Entity("Sol_server_api.Entities.Login", b =>
                {
                    b.Property<string>("LoginID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginID");

                    b.ToTable("login", (string)null);
                });

            modelBuilder.Entity("Sol_server_api.Entities.Permission", b =>
                {
                    b.Property<string>("PermissionName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FKPermissionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PermissionDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermissionID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermissionName");

                    b.HasIndex("FKPermissionName")
                        .IsUnique();

                    b.ToTable("jogosultsag", (string)null);
                });

            modelBuilder.Entity("Sol_server_api.Entities.PersonalData", b =>
                {
                    b.Property<string>("TelNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TelNumber");

                    b.ToTable("szemelyi_adat", (string)null);
                });

            modelBuilder.Entity("Sol_server_api.Entities.Process", b =>
                {
                    b.Property<string>("ProcessID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FKProcess")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProcessID");

                    b.HasIndex("FKProcess")
                        .IsUnique();

                    b.ToTable("folyamat", (string)null);
                });

            modelBuilder.Entity("Sol_server_api.Entities.Project", b =>
                {
                    b.Property<string>("ProjectID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FKCustomerID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("projectDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectID");

                    b.HasIndex("FKCustomerID");

                    b.ToTable("projekt", (string)null);
                });

            modelBuilder.Entity("Sol_server_api.Entities.ProjectPackage", b =>
                {
                    b.Property<string>("PackageID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FKProjectID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RequiredComponentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequiredPiece")
                        .HasColumnType("int");

                    b.HasKey("PackageID");

                    b.HasIndex("FKProjectID")
                        .IsUnique();

                    b.ToTable("projekt_csomag", (string)null);
                });

            modelBuilder.Entity("CoworkerProject", b =>
                {
                    b.HasOne("Sol_server_api.Entities.Coworker", null)
                        .WithMany()
                        .HasForeignKey("CoworkersCoworkerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sol_server_api.Entities.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sol_server_api.Entities.Compartment", b =>
                {
                    b.HasOne("Sol_server_api.Entities.Component", null)
                        .WithOne("Compartment")
                        .HasForeignKey("Sol_server_api.Entities.Compartment", "FKComponentID");
                });

            modelBuilder.Entity("Sol_server_api.Entities.Component", b =>
                {
                    b.HasOne("Sol_server_api.Entities.ProjectPackage", null)
                        .WithMany("Components")
                        .HasForeignKey("FKPackageID");
                });

            modelBuilder.Entity("Sol_server_api.Entities.Login", b =>
                {
                    b.HasOne("Sol_server_api.Entities.Coworker", null)
                        .WithOne("Login")
                        .HasForeignKey("Sol_server_api.Entities.Login", "LoginID")
                        .HasPrincipalKey("Sol_server_api.Entities.Coworker", "PLKLoginID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sol_server_api.Entities.Permission", b =>
                {
                    b.HasOne("Sol_server_api.Entities.Coworker", null)
                        .WithOne("Permission")
                        .HasForeignKey("Sol_server_api.Entities.Permission", "FKPermissionName")
                        .HasPrincipalKey("Sol_server_api.Entities.Coworker", "PLKPermission")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sol_server_api.Entities.PersonalData", b =>
                {
                    b.HasOne("Sol_server_api.Entities.Coworker", null)
                        .WithOne("PersonalData")
                        .HasForeignKey("Sol_server_api.Entities.PersonalData", "TelNumber")
                        .HasPrincipalKey("Sol_server_api.Entities.Coworker", "PLKTelNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sol_server_api.Entities.Process", b =>
                {
                    b.HasOne("Sol_server_api.Entities.Project", null)
                        .WithOne("Process")
                        .HasForeignKey("Sol_server_api.Entities.Process", "FKProcess")
                        .HasPrincipalKey("Sol_server_api.Entities.Project", "ProcessStatus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sol_server_api.Entities.Project", b =>
                {
                    b.HasOne("Sol_server_api.Entities.Customer", null)
                        .WithMany("Projects")
                        .HasForeignKey("FKCustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sol_server_api.Entities.ProjectPackage", b =>
                {
                    b.HasOne("Sol_server_api.Entities.Project", null)
                        .WithOne("ProjectPackage")
                        .HasForeignKey("Sol_server_api.Entities.ProjectPackage", "FKProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sol_server_api.Entities.Component", b =>
                {
                    b.Navigation("Compartment");
                });

            modelBuilder.Entity("Sol_server_api.Entities.Coworker", b =>
                {
                    b.Navigation("Login")
                        .IsRequired();

                    b.Navigation("Permission")
                        .IsRequired();

                    b.Navigation("PersonalData")
                        .IsRequired();
                });

            modelBuilder.Entity("Sol_server_api.Entities.Customer", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Sol_server_api.Entities.Project", b =>
                {
                    b.Navigation("Process")
                        .IsRequired();

                    b.Navigation("ProjectPackage")
                        .IsRequired();
                });

            modelBuilder.Entity("Sol_server_api.Entities.ProjectPackage", b =>
                {
                    b.Navigation("Components");
                });
#pragma warning restore 612, 618
        }
    }
}