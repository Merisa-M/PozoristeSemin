﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pozoriste;

namespace Pozoriste.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Pozoriste.EntityModels.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnickiNalogID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.HasIndex("KorisnickiNalogID");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            AdminID = 1,
                            Ime = "Admin",
                            KorisnickiNalogID = 1,
                            Prezime = "Admin"
                        });
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Glumac", b =>
                {
                    b.Property<int>("GlumacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdresaSlike")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojUgovora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GlumacID");

                    b.ToTable("Glumac");

                    b.HasData(
                        new
                        {
                            GlumacID = 1,
                            BrojUgovora = "1234",
                            DatumRodjenja = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sefif@gmail.com",
                            Ime = "Šerif",
                            Prezime = "Aljić"
                        },
                        new
                        {
                            GlumacID = 2,
                            BrojUgovora = "1233",
                            DatumRodjenja = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "amela@gmail.com",
                            Ime = "Amela",
                            Prezime = "Kreso"
                        },
                        new
                        {
                            GlumacID = 3,
                            BrojUgovora = "3344",
                            DatumRodjenja = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bojan@gmail.com",
                            Ime = "Bojan",
                            Prezime = "Beribaka"
                        },
                        new
                        {
                            GlumacID = 4,
                            BrojUgovora = "4455",
                            DatumRodjenja = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "maja@gmail.com",
                            Ime = "Maja",
                            Prezime = "Zećo"
                        },
                        new
                        {
                            GlumacID = 5,
                            BrojUgovora = "5577",
                            DatumRodjenja = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "emir@gmail.com",
                            Ime = "Emir",
                            Prezime = "Spahić"
                        },
                        new
                        {
                            GlumacID = 6,
                            BrojUgovora = "9933",
                            DatumRodjenja = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "goran@gmail.com",
                            Ime = "Goran",
                            Prezime = "Lazo"
                        },
                        new
                        {
                            GlumacID = 7,
                            BrojUgovora = "4567",
                            DatumRodjenja = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "vedran@gmail.com",
                            Ime = "Vedran",
                            Prezime = "Vedran"
                        });
                });

            modelBuilder.Entity("Pozoriste.EntityModels.GlumacPredstava", b =>
                {
                    b.Property<int>("GlumacPredstavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GlumacID")
                        .HasColumnType("int");

                    b.Property<int>("PredstavaID")
                        .HasColumnType("int");

                    b.HasKey("GlumacPredstavaID");

                    b.HasIndex("GlumacID");

                    b.HasIndex("PredstavaID");

                    b.ToTable("GlumacPredstava");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradID");

                    b.ToTable("Grad");

                    b.HasData(
                        new
                        {
                            GradID = 1,
                            Naziv = "Sarajevo"
                        },
                        new
                        {
                            GradID = 2,
                            Naziv = "Zagreb"
                        },
                        new
                        {
                            GradID = 3,
                            Naziv = "Mostar"
                        },
                        new
                        {
                            GradID = 4,
                            Naziv = "Bihac"
                        },
                        new
                        {
                            GradID = 5,
                            Naziv = "Split"
                        },
                        new
                        {
                            GradID = 6,
                            Naziv = "Konjic"
                        },
                        new
                        {
                            GradID = 7,
                            Naziv = "Tuzla"
                        },
                        new
                        {
                            GradID = 8,
                            Naziv = "Sanski most"
                        },
                        new
                        {
                            GradID = 9,
                            Naziv = "Livno"
                        },
                        new
                        {
                            GradID = 10,
                            Naziv = "Trebinje"
                        },
                        new
                        {
                            GradID = 11,
                            Naziv = "Banja luka"
                        });
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Komentar", b =>
                {
                    b.Property<int>("KomentarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("KupacID")
                        .HasColumnType("int");

                    b.Property<bool>("Odobren")
                        .HasColumnType("bit");

                    b.Property<int>("PredstavaID")
                        .HasColumnType("int");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VrijemeKreiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("KomentarID");

                    b.HasIndex("KupacID");

                    b.HasIndex("PredstavaID");

                    b.ToTable("Komentar");

                    b.HasData(
                        new
                        {
                            KomentarID = 1,
                            KupacID = 2,
                            Odobren = true,
                            PredstavaID = 1,
                            Sadrzaj = "Super",
                            VrijemeKreiranja = new DateTime(2022, 4, 11, 17, 2, 2, 127, DateTimeKind.Local).AddTicks(3835)
                        },
                        new
                        {
                            KomentarID = 2,
                            KupacID = 3,
                            Odobren = true,
                            PredstavaID = 1,
                            Sadrzaj = "Lose",
                            VrijemeKreiranja = new DateTime(2022, 4, 11, 17, 2, 2, 129, DateTimeKind.Local).AddTicks(8864)
                        });
                });

            modelBuilder.Entity("Pozoriste.EntityModels.KorisnickiNalog", b =>
                {
                    b.Property<int>("KorisnickiNalogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnickiNalogID");

                    b.ToTable("KorisnickiNalog");

                    b.HasData(
                        new
                        {
                            KorisnickiNalogID = 1,
                            Password = "admin",
                            Username = "admin"
                        },
                        new
                        {
                            KorisnickiNalogID = 2,
                            Password = "test",
                            Username = "test"
                        });
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Kupac", b =>
                {
                    b.Property<int>("KupacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnickiNalogID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KupacID");

                    b.HasIndex("GradID");

                    b.HasIndex("KorisnickiNalogID");

                    b.ToTable("Kupac");

                    b.HasData(
                        new
                        {
                            KupacID = 1,
                            BrojTelefona = "061111111",
                            Email = "prezime1.ime1@gmail.com",
                            GradID = 2,
                            Ime = "Ime1",
                            KorisnickiNalogID = 2,
                            Prezime = "Prezime1"
                        },
                        new
                        {
                            KupacID = 2,
                            BrojTelefona = "061222111",
                            Email = "prezime2.ime2@gmail.com",
                            GradID = 3,
                            Ime = "Ime2",
                            KorisnickiNalogID = 2,
                            Prezime = "Prezime2"
                        },
                        new
                        {
                            KupacID = 3,
                            BrojTelefona = "061223331",
                            Email = "prezime3.ime4@gmail.com",
                            GradID = 4,
                            Ime = "Ime3",
                            KorisnickiNalogID = 2,
                            Prezime = "Prezime3"
                        },
                        new
                        {
                            KupacID = 4,
                            BrojTelefona = "061222331",
                            Email = "prezime4.ime4@gmail.com",
                            GradID = 8,
                            Ime = "Ime4",
                            KorisnickiNalogID = 2,
                            Prezime = "Prezime4"
                        });
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Novosti", b =>
                {
                    b.Property<int>("NovostiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AdminID")
                        .HasColumnType("int");

                    b.Property<string>("AdresaSlike")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumVrijemeObjave")
                        .HasColumnType("datetime2");

                    b.Property<string>("KratkiSadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NovostiID");

                    b.HasIndex("AdminID");

                    b.ToTable("Novosti");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Predstava", b =>
                {
                    b.Property<int>("PredstavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProsjecnaOcjena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Reziser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Trajanje")
                        .HasColumnType("int");

                    b.Property<int>("ZanrID")
                        .HasColumnType("int");

                    b.HasKey("PredstavaID");

                    b.HasIndex("ZanrID");

                    b.ToTable("Predstava");

                    b.HasData(
                        new
                        {
                            PredstavaID = 1,
                            Naziv = "dervis i smrt",
                            Opis = "Opis",
                            ProsjecnaOcjena = 0m,
                            Reziser = "Reziser",
                            Trajanje = 60,
                            ZanrID = 2
                        });
                });

            modelBuilder.Entity("Pozoriste.EntityModels.PredstavaKupac", b =>
                {
                    b.Property<int>("PredstavaKupacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("KupacID")
                        .HasColumnType("int");

                    b.Property<decimal>("Ocjena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PredstavaID")
                        .HasColumnType("int");

                    b.HasKey("PredstavaKupacID");

                    b.HasIndex("KupacID");

                    b.HasIndex("PredstavaID");

                    b.ToTable("PredstavaKupac");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Prikazivanje", b =>
                {
                    b.Property<int>("PrikazivanjeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DatumPrikazivanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("PredstavaID")
                        .HasColumnType("int");

                    b.Property<int>("SalaID")
                        .HasColumnType("int");

                    b.HasKey("PrikazivanjeID");

                    b.HasIndex("PredstavaID");

                    b.HasIndex("SalaID");

                    b.ToTable("Prikazivanje");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Rezervacija", b =>
                {
                    b.Property<int>("RezervacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DatumIsteka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumRezervacije")
                        .HasColumnType("datetime2");

                    b.Property<int>("KupacID")
                        .HasColumnType("int");

                    b.Property<bool>("Odobrena")
                        .HasColumnType("bit");

                    b.Property<int>("PrikazivanjeID")
                        .HasColumnType("int");

                    b.HasKey("RezervacijaID");

                    b.HasIndex("KupacID");

                    b.HasIndex("PrikazivanjeID");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Sala", b =>
                {
                    b.Property<int>("SalaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Kapacitet")
                        .HasColumnType("int");

                    b.Property<bool>("Klimatizacija")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalaID");

                    b.ToTable("Sala");

                    b.HasData(
                        new
                        {
                            SalaID = 1,
                            Kapacitet = 50,
                            Klimatizacija = true,
                            Naziv = "Sala 1"
                        },
                        new
                        {
                            SalaID = 2,
                            Kapacitet = 70,
                            Klimatizacija = false,
                            Naziv = "Sala 2"
                        },
                        new
                        {
                            SalaID = 3,
                            Kapacitet = 80,
                            Klimatizacija = true,
                            Naziv = "Sala 3"
                        },
                        new
                        {
                            SalaID = 4,
                            Kapacitet = 30,
                            Klimatizacija = true,
                            Naziv = "Sala 3"
                        },
                        new
                        {
                            SalaID = 5,
                            Kapacitet = 100,
                            Klimatizacija = false,
                            Naziv = "Sala 3"
                        });
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Sjediste", b =>
                {
                    b.Property<int>("SjedisteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Kolona")
                        .HasColumnType("int");

                    b.Property<int>("Red")
                        .HasColumnType("int");

                    b.Property<int>("SalaID")
                        .HasColumnType("int");

                    b.HasKey("SjedisteID");

                    b.HasIndex("SalaID");

                    b.ToTable("Sjediste");

                    b.HasData(
                        new
                        {
                            SjedisteID = 1,
                            Kolona = 1,
                            Red = 1,
                            SalaID = 1
                        },
                        new
                        {
                            SjedisteID = 2,
                            Kolona = 2,
                            Red = 1,
                            SalaID = 1
                        },
                        new
                        {
                            SjedisteID = 3,
                            Kolona = 3,
                            Red = 2,
                            SalaID = 2
                        },
                        new
                        {
                            SjedisteID = 4,
                            Kolona = 5,
                            Red = 3,
                            SalaID = 2
                        },
                        new
                        {
                            SjedisteID = 5,
                            Kolona = 4,
                            Red = 4,
                            SalaID = 3
                        },
                        new
                        {
                            SjedisteID = 6,
                            Kolona = 7,
                            Red = 5,
                            SalaID = 4
                        },
                        new
                        {
                            SjedisteID = 7,
                            Kolona = 3,
                            Red = 7,
                            SalaID = 5
                        },
                        new
                        {
                            SjedisteID = 8,
                            Kolona = 2,
                            Red = 5,
                            SalaID = 4
                        });
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Ulaznica", b =>
                {
                    b.Property<int>("UlaznicaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("KupacID")
                        .HasColumnType("int");

                    b.Property<int>("PrikazivanjeID")
                        .HasColumnType("int");

                    b.Property<int>("RezervacijaID")
                        .HasColumnType("int");

                    b.Property<int>("SjedisteID")
                        .HasColumnType("int");

                    b.HasKey("UlaznicaID");

                    b.HasIndex("KupacID");

                    b.HasIndex("PrikazivanjeID");

                    b.HasIndex("RezervacijaID");

                    b.HasIndex("SjedisteID");

                    b.ToTable("Ulaznica");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Zanr", b =>
                {
                    b.Property<int>("ZanrID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZanrID");

                    b.ToTable("Zanr");

                    b.HasData(
                        new
                        {
                            ZanrID = 1,
                            Naziv = "Drame"
                        },
                        new
                        {
                            ZanrID = 2,
                            Naziv = "Lutkarske"
                        },
                        new
                        {
                            ZanrID = 3,
                            Naziv = "Klasicne"
                        },
                        new
                        {
                            ZanrID = 4,
                            Naziv = "Tragične"
                        },
                        new
                        {
                            ZanrID = 5,
                            Naziv = "Mjuzikli"
                        });
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Admin", b =>
                {
                    b.HasOne("Pozoriste.EntityModels.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiNalog");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.GlumacPredstava", b =>
                {
                    b.HasOne("Pozoriste.EntityModels.Glumac", "Glumac")
                        .WithMany()
                        .HasForeignKey("GlumacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pozoriste.EntityModels.Predstava", "Predstava")
                        .WithMany()
                        .HasForeignKey("PredstavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Glumac");

                    b.Navigation("Predstava");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Komentar", b =>
                {
                    b.HasOne("Pozoriste.EntityModels.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pozoriste.EntityModels.Predstava", "Predstava")
                        .WithMany()
                        .HasForeignKey("PredstavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kupac");

                    b.Navigation("Predstava");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Kupac", b =>
                {
                    b.HasOne("Pozoriste.EntityModels.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pozoriste.EntityModels.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grad");

                    b.Navigation("KorisnickiNalog");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Novosti", b =>
                {
                    b.HasOne("Pozoriste.EntityModels.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Predstava", b =>
                {
                    b.HasOne("Pozoriste.EntityModels.Zanr", "Zanr")
                        .WithMany()
                        .HasForeignKey("ZanrID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zanr");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.PredstavaKupac", b =>
                {
                    b.HasOne("Pozoriste.EntityModels.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pozoriste.EntityModels.Predstava", "Predstava")
                        .WithMany()
                        .HasForeignKey("PredstavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kupac");

                    b.Navigation("Predstava");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Prikazivanje", b =>
                {
                    b.HasOne("Pozoriste.EntityModels.Predstava", "Predstava")
                        .WithMany()
                        .HasForeignKey("PredstavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pozoriste.EntityModels.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predstava");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Rezervacija", b =>
                {
                    b.HasOne("Pozoriste.EntityModels.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pozoriste.EntityModels.Prikazivanje", "Prikazivanje")
                        .WithMany()
                        .HasForeignKey("PrikazivanjeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kupac");

                    b.Navigation("Prikazivanje");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Sjediste", b =>
                {
                    b.HasOne("Pozoriste.EntityModels.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("Pozoriste.EntityModels.Ulaznica", b =>
                {
                    b.HasOne("Pozoriste.EntityModels.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pozoriste.EntityModels.Prikazivanje", "Prikazivanje")
                        .WithMany()
                        .HasForeignKey("PrikazivanjeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pozoriste.EntityModels.Rezervacija", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("RezervacijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pozoriste.EntityModels.Sjediste", "Sjediste")
                        .WithMany()
                        .HasForeignKey("SjedisteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kupac");

                    b.Navigation("Prikazivanje");

                    b.Navigation("Rezervacija");

                    b.Navigation("Sjediste");
                });
#pragma warning restore 612, 618
        }
    }
}
