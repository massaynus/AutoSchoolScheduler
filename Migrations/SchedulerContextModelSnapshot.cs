﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scheduler;

namespace Scheduler.Migrations
{
    [DbContext(typeof(SchedulerContext))]
    partial class SchedulerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Scheduler.Branche", b =>
                {
                    b.Property<int>("BrancheID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrancheName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrancheID");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Scheduler.BrancheModule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrancheID")
                        .HasColumnType("int");

                    b.Property<int>("ModuleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BrancheID");

                    b.HasIndex("ModuleID");

                    b.ToTable("BrancheModules");
                });

            modelBuilder.Entity("Scheduler.ClassRoom", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomID");

                    b.ToTable("ClassRooms");
                });

            modelBuilder.Entity("Scheduler.ClassRoomEquipement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EquipementID")
                        .HasColumnType("int");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<int>("UsedCount")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EquipementID");

                    b.HasIndex("RoomID");

                    b.ToTable("ClassRoomEquipements");
                });

            modelBuilder.Entity("Scheduler.Equipement", b =>
                {
                    b.Property<int>("EquipementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipementID");

                    b.ToTable("Equipements");
                });

            modelBuilder.Entity("Scheduler.Groupe", b =>
                {
                    b.Property<int>("GroupeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupeID");

                    b.ToTable("Groupes");
                });

            modelBuilder.Entity("Scheduler.Module", b =>
                {
                    b.Property<int>("ModuleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("ModuleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuleID");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("Scheduler.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GSM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("People");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("Scheduler.TeacherModule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ModuleID")
                        .HasColumnType("int");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ModuleID");

                    b.HasIndex("TeacherID");

                    b.ToTable("TeacherModules");
                });

            modelBuilder.Entity("Scheduler.Student", b =>
                {
                    b.HasBaseType("Scheduler.Person");

                    b.Property<int?>("GroupeID")
                        .HasColumnType("int");

                    b.Property<string>("Matricule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentGSM")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("GroupeID");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Scheduler.Teacher", b =>
                {
                    b.HasBaseType("Scheduler.Person");

                    b.Property<string>("RIB")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("Scheduler.BrancheModule", b =>
                {
                    b.HasOne("Scheduler.Branche", "Branche")
                        .WithMany("Modules")
                        .HasForeignKey("BrancheID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scheduler.Module", "Module")
                        .WithMany("Branches")
                        .HasForeignKey("ModuleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Scheduler.ClassRoomEquipement", b =>
                {
                    b.HasOne("Scheduler.Equipement", "Equipement")
                        .WithMany("ClassRooms")
                        .HasForeignKey("EquipementID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scheduler.ClassRoom", "Room")
                        .WithMany("Equipements")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Scheduler.TeacherModule", b =>
                {
                    b.HasOne("Scheduler.Module", "Module")
                        .WithMany("ModuleTeachers")
                        .HasForeignKey("ModuleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scheduler.Teacher", "Teacher")
                        .WithMany("ModuleTeachers")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Scheduler.Student", b =>
                {
                    b.HasOne("Scheduler.Groupe", "Groupe")
                        .WithMany("Students")
                        .HasForeignKey("GroupeID");
                });
#pragma warning restore 612, 618
        }
    }
}
