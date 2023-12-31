﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentRecordSystem.Data;

#nullable disable

namespace StudentRecordSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230531103553_ChangetheNameOfIdInSchoolModel")]
    partial class ChangetheNameOfIdInSchoolModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentRecordSystem.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FacultyYears")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FacultyYears = 5,
                            Name = "Faculty of Engineering"
                        },
                        new
                        {
                            Id = 2,
                            FacultyYears = 7,
                            Name = "Faculty of Medicine"
                        },
                        new
                        {
                            Id = 3,
                            FacultyYears = 4,
                            Name = "Faculty of Computers and Artificial Intelligence"
                        },
                        new
                        {
                            Id = 4,
                            FacultyYears = 5,
                            Name = "Faculty of Pharmacy"
                        },
                        new
                        {
                            Id = 5,
                            FacultyYears = 4,
                            Name = "Faculty of Agriculture "
                        },
                        new
                        {
                            Id = 6,
                            FacultyYears = 4,
                            Name = "Faculty of Science"
                        },
                        new
                        {
                            Id = 7,
                            FacultyYears = 4,
                            Name = "Faculty of Economics and Political Science"
                        },
                        new
                        {
                            Id = 8,
                            FacultyYears = 4,
                            Name = "Faculty of Mass Communication"
                        },
                        new
                        {
                            Id = 9,
                            FacultyYears = 4,
                            Name = "Faculty of Archaeology "
                        },
                        new
                        {
                            Id = 10,
                            FacultyYears = 4,
                            Name = "Faculty of Arts"
                        },
                        new
                        {
                            Id = 11,
                            FacultyYears = 4,
                            Name = "Faculty of Commerce"
                        },
                        new
                        {
                            Id = 12,
                            FacultyYears = 4,
                            Name = "Faculty of Specific Education"
                        },
                        new
                        {
                            Id = 13,
                            FacultyYears = 4,
                            Name = "Faculty of Nursing"
                        },
                        new
                        {
                            Id = 14,
                            FacultyYears = 4,
                            Name = "Faculty of Law"
                        },
                        new
                        {
                            Id = 15,
                            FacultyYears = 4,
                            Name = "Faculty of Physical Therapy"
                        },
                        new
                        {
                            Id = 16,
                            FacultyYears = 4,
                            Name = "Faculty of Oral and Dental Medicine"
                        },
                        new
                        {
                            Id = 17,
                            FacultyYears = 4,
                            Name = "Faculty of Dar El-Ulum"
                        });
                });

            modelBuilder.Entity("StudentRecordSystem.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Qaluobia",
                            Location = "15 Damnhor Shobra Elkima ",
                            Name = "Shobra-ElKhima",
                            Type = "Elementary School"
                        },
                        new
                        {
                            Id = 2,
                            City = "Giza",
                            Location = "jazira warraq el-hadr",
                            Name = "El-yosr",
                            Type = "Middle School"
                        },
                        new
                        {
                            Id = 3,
                            City = "Cairo",
                            Location = "shobra street",
                            Name = "El-Tawfikia elthanawya banen",
                            Type = "High School"
                        });
                });

            modelBuilder.Entity("StudentRecordSystem.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentRecordSystem.Models.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstablishmentDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Universities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Giza",
                            Description = "Cairo University (Arabic: جامعة القاهرة, romanized: Jāmi‘a al-Qāhira), also known as the Egyptian University from 1908 to 1940, and King Fuad I University and Fu'ād al-Awwal University from 1940 to 1952, is Egypt's premier public university. Its main campus is in Giza, immediately across the Nile from Cairo. It was founded on 21 December 1908;however, after being housed in various parts of Cairo, its faculties, beginning with the Faculty of Arts, were established on its current main campus in Giza in October 1929. It is the second oldest institution of higher education in Egypt after Al-Azhar University, notwithstanding the pre-existing higher professional schools that later became constituent colleges of the university. It was founded and funded as the Egyptian University by a committee of private citizens with royal patronage in 1908 and became a state institution under King Fuad I in 1925. In 1940, four years following his death, the university was renamed King Fuad I University in his honor. It was renamed a second time after the 1952 Egyptian Revolution. The university currently enrolls approximately 155,000 students in 20 faculties and 3 institutions. It counts three Nobel Laureates among its graduates and is one of the 50 largest institutions of higher education in the world by enrollment.",
                            EstablishmentDate = "December 21, 1908",
                            ImageUrl = "https://uni-find.com/en/wp-content/uploads/2020/03/Cairo-University.png",
                            Location = "1 University Street, Giza 12613",
                            Name = "Cairo Univeristy"
                        },
                        new
                        {
                            Id = 2,
                            City = "Cairo",
                            Description = "Ain Shams University, as the third Egyptian university, was founded in July 1950 under the name of 'Ibrahim Pasha University'. It participated with the two earlier universities, 'Cairo University' (Fua'd the 1st ) and 'Alexandria University' (Farouk the 1st) in fulfilling the message of universities and meeting the increasing demand of youth for higher education. When it was first established, Ain Shams University comprised a number of distinguished faculties and academic institutes, which were later developed into university",
                            EstablishmentDate = "July 1950",
                            ImageUrl = "https://www.asu.edu.eg/storage//uploads/2022/slider/nUIegg3j.jpg",
                            Location = "El-Khalyfa El-Mamoun Street Abbasya, Cairo , Eygpt",
                            Name = "Ain Shams University"
                        },
                        new
                        {
                            Id = 3,
                            City = "Helwan",
                            Description = "Helwan University is a member of the Egyptian Supreme Council of Universities. It was established on July 26, 1980 by Act No. 70 of 1975 over 350 acres of land. It is the youngest of 3 major governmental universities in Cairo.However, it goes back to the 19th century during the reign of Muhammad Ali of Egypt who established “The Operations School”. The fields of that school were the basis of many institutes that formed Helwan University later.Although Helwan University is the most recent of 3 major governmental universities in Cairo, it encompasses some of the oldest faculties not only in Egypt but also in the Middle East. The Faculty of Applied Arts, for example, was established in 1839, while the Faculty of Fine Arts and Art Education were established in 1908 and 1936 respectively.",
                            EstablishmentDate = "July 26, 1980",
                            ImageUrl = "https://www.egypttoday.com/siteimages/Larg/20211207032202222.jpg",
                            Location = "Al Sikka Al Hadid Al Gharbeya, Qism Helwan",
                            Name = "Helwan University"
                        });
                });

            modelBuilder.Entity("StudentRecordSystem.Models.Student", b =>
                {
                    b.HasOne("StudentRecordSystem.Models.University", "University")
                        .WithMany()
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("University");
                });
#pragma warning restore 612, 618
        }
    }
}
