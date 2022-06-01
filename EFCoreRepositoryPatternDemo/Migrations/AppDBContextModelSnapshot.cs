﻿// <auto-generated />
using EFCoreRepositoryPatternDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreRepositoryPatternDemo.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreRepositoryPatternDemo.Models.ClsEmployee", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CellNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpID");

                    b.ToTable("coreEmployees");

                    b.HasData(
                        new
                        {
                            EmpID = 1,
                            CellNumber = "(660) 663-4518",
                            Email = "aron.hawkins@aol.com",
                            FirstName = "Aaron",
                            LastName = "Hawkins",
                            Password = "arron@123"
                        },
                        new
                        {
                            EmpID = 2,
                            CellNumber = "(608) 265-2215",
                            Email = "hedy.greene@aol.com",
                            FirstName = "Hedy",
                            LastName = "Greene",
                            Password = "hedy@123"
                        },
                        new
                        {
                            EmpID = 3,
                            CellNumber = "(959) 119-8364",
                            Email = "melvin.porter@aol.com",
                            FirstName = "Melvin",
                            LastName = "Porter",
                            Password = "melvin@123"
                        });
                });

            modelBuilder.Entity("EFCoreRepositoryPatternDemo.Models.ClsSkill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpID")
                        .HasColumnType("int");

                    b.Property<int>("ExperienceInYears")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.HasIndex("EmpID");

                    b.ToTable("coreSkill");

                    b.HasData(
                        new
                        {
                            SkillId = 1,
                            EmpID = 1,
                            ExperienceInYears = 2,
                            Role = "Business Analyst",
                            SkillName = "Microsoft Office Suite"
                        },
                        new
                        {
                            SkillId = 2,
                            EmpID = 1,
                            ExperienceInYears = 3,
                            Role = "Developer",
                            SkillName = "Testing"
                        },
                        new
                        {
                            SkillId = 3,
                            EmpID = 1,
                            ExperienceInYears = 4,
                            Role = "Project Lead",
                            SkillName = "Stakeholder Management"
                        });
                });

            modelBuilder.Entity("EFCoreRepositoryPatternDemo.Models.ClsSkill", b =>
                {
                    b.HasOne("EFCoreRepositoryPatternDemo.Models.ClsEmployee", "ClsEmployee")
                        .WithMany("ClsSkills")
                        .HasForeignKey("EmpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClsEmployee");
                });

            modelBuilder.Entity("EFCoreRepositoryPatternDemo.Models.ClsEmployee", b =>
                {
                    b.Navigation("ClsSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
