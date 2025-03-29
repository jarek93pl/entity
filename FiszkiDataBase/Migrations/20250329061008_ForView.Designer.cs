﻿// <auto-generated />
using System;
using FiszkiDataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FiszkiDataBase.Migrations
{
    [DbContext(typeof(Foryoutube2Context))]
    [Migration("20250329061008_ForView")]
    partial class ForView
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FiszkiDataBase.DictionaryTypeAnswer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Dictiona__3214EC07B7D4D22D");

                    b.ToTable("DictionaryTypeAnswer", (string)null);
                });

            modelBuilder.Entity("FiszkiDataBase.DictionaryTypeContent", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Dictiona__3214EC07F86D7FEA");

                    b.ToTable("DictionaryTypeContent", (string)null);
                });

            modelBuilder.Entity("FiszkiDataBase.Fiche", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdFile")
                        .HasColumnType("int");

                    b.Property<int?>("IdSetFiche")
                        .HasColumnType("int");

                    b.Property<string>("Prompt")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Response")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("TypePrompt")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Fiche__3214EC077185F5EA");

                    b.HasIndex("IdFile");

                    b.HasIndex("IdSetFiche");

                    b.HasIndex("TypePrompt");

                    b.ToTable("Fiche", (string)null);
                });

            modelBuilder.Entity("FiszkiDataBase.FicheAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateAnswering")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdFiche")
                        .HasColumnType("int");

                    b.Property<int?>("IdTeachSet")
                        .HasColumnType("int");

                    b.Property<bool?>("IsCorrect")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("PK__FicheAns__3214EC07EC6B5CEF");

                    b.ToTable("FicheAnswer", (string)null);
                });

            modelBuilder.Entity("FiszkiDataBase.FicheResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdFiche")
                        .HasColumnType("int");

                    b.Property<int?>("IdFile")
                        .HasColumnType("int");

                    b.Property<bool?>("IsCorect")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("TypePrompt")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__FicheRes__3214EC0757D0C7DD");

                    b.HasIndex("IdFiche");

                    b.HasIndex("IdFile");

                    b.HasIndex("TypePrompt");

                    b.ToTable("FicheResponses");
                });

            modelBuilder.Entity("FiszkiDataBase.FicheTeachState", b =>
                {
                    b.Property<int>("IdTeachSet")
                        .HasColumnType("int");

                    b.Property<int>("IdFiche")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDone")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("NextTry")
                        .HasColumnType("datetime");

                    b.Property<int?>("NumberCorect")
                        .HasColumnType("int");

                    b.HasKey("IdTeachSet", "IdFiche")
                        .HasName("PK__FicheTea__6D05EC33244D6B63");

                    b.HasIndex("IdFiche");

                    b.ToTable("FicheTeachState", (string)null);
                });

            modelBuilder.Entity("FiszkiDataBase.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FileExtension")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id")
                        .HasName("PK__File__3214EC07ADBF8066");

                    b.ToTable("File", (string)null);
                });

            modelBuilder.Entity("FiszkiDataBase.SetsFiche", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__SetsFich__3214EC0719F640B8");

                    b.HasIndex("UserId");

                    b.ToTable("SetsFiche", (string)null);
                });

            modelBuilder.Entity("FiszkiDataBase.TeachBag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdTeachSet")
                        .HasColumnType("int");

                    b.Property<int?>("LimitTimeSek")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Number")
                        .HasColumnType("int");

                    b.Property<TimeOnly?>("PeriodTime")
                        .HasColumnType("time");

                    b.Property<int?>("TypeAnswer")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__TeachBag__3214EC07DFE4CDB2");

                    b.HasIndex("IdTeachSet");

                    b.HasIndex("TypeAnswer");

                    b.ToTable("TeachBags");
                });

            modelBuilder.Entity("FiszkiDataBase.TeachSetsFiche", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<int?>("FirstTypeAnswer")
                        .HasColumnType("int");

                    b.Property<int?>("IdSetFiche")
                        .HasColumnType("int");

                    b.Property<int?>("LimitTimeSek")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__TeachSet__3214EC074AF16EBD");

                    b.HasIndex("FirstTypeAnswer");

                    b.HasIndex("IdSetFiche");

                    b.ToTable("TeachSetsFiche", (string)null);
                });

            modelBuilder.Entity("FiszkiDataBase.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Password")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id")
                        .HasName("PK__Users__3214EC075668D08A");

                    b.HasIndex(new[] { "Login" }, "UQ__Users__5E55825B7500623E")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FiszkiDataBase.Fiche", b =>
                {
                    b.HasOne("FiszkiDataBase.File", "IdFileNavigation")
                        .WithMany("Fiches")
                        .HasForeignKey("IdFile")
                        .HasConstraintName("FK__Fiche__IdFile__3C69FB99");

                    b.HasOne("FiszkiDataBase.SetsFiche", "IdSetFicheNavigation")
                        .WithMany("Fiches")
                        .HasForeignKey("IdSetFiche")
                        .HasConstraintName("FK__Fiche__IdSetFich__3B75D760");

                    b.HasOne("FiszkiDataBase.DictionaryTypeContent", "TypePromptNavigation")
                        .WithMany("Fiches")
                        .HasForeignKey("TypePrompt")
                        .HasConstraintName("FK__Fiche__TypePromp__3A81B327");

                    b.Navigation("IdFileNavigation");

                    b.Navigation("IdSetFicheNavigation");

                    b.Navigation("TypePromptNavigation");
                });

            modelBuilder.Entity("FiszkiDataBase.FicheResponse", b =>
                {
                    b.HasOne("FiszkiDataBase.Fiche", "IdFicheNavigation")
                        .WithMany("FicheResponses")
                        .HasForeignKey("IdFiche")
                        .HasConstraintName("FK__FicheResp__IdFic__3F466844");

                    b.HasOne("FiszkiDataBase.File", "IdFileNavigation")
                        .WithMany("FicheResponses")
                        .HasForeignKey("IdFile")
                        .HasConstraintName("FK__FicheResp__IdFil__3E52440B");

                    b.HasOne("FiszkiDataBase.DictionaryTypeContent", "TypePromptNavigation")
                        .WithMany("FicheResponses")
                        .HasForeignKey("TypePrompt")
                        .HasConstraintName("FK__FicheResp__TypeP__3D5E1FD2");

                    b.Navigation("IdFicheNavigation");

                    b.Navigation("IdFileNavigation");

                    b.Navigation("TypePromptNavigation");
                });

            modelBuilder.Entity("FiszkiDataBase.FicheTeachState", b =>
                {
                    b.HasOne("FiszkiDataBase.Fiche", "IdFicheNavigation")
                        .WithMany("FicheTeachStates")
                        .HasForeignKey("IdFiche")
                        .IsRequired()
                        .HasConstraintName("FK__FicheTeac__IdFic__403A8C7D");

                    b.HasOne("FiszkiDataBase.TeachSetsFiche", "IdTeachSetNavigation")
                        .WithMany("FicheTeachStates")
                        .HasForeignKey("IdTeachSet")
                        .IsRequired()
                        .HasConstraintName("FK__FicheTeac__IdTea__412EB0B6");

                    b.Navigation("IdFicheNavigation");

                    b.Navigation("IdTeachSetNavigation");
                });

            modelBuilder.Entity("FiszkiDataBase.SetsFiche", b =>
                {
                    b.HasOne("FiszkiDataBase.User", "User")
                        .WithMany("SetsFiches")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_PersonOrder");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FiszkiDataBase.TeachBag", b =>
                {
                    b.HasOne("FiszkiDataBase.TeachSetsFiche", "IdTeachSetNavigation")
                        .WithMany("TeachBags")
                        .HasForeignKey("IdTeachSet")
                        .HasConstraintName("FK_IdTeachFiche");

                    b.HasOne("FiszkiDataBase.DictionaryTypeAnswer", "TypeAnswerNavigation")
                        .WithMany("TeachBags")
                        .HasForeignKey("TypeAnswer")
                        .HasConstraintName("FK_TeachBag");

                    b.Navigation("IdTeachSetNavigation");

                    b.Navigation("TypeAnswerNavigation");
                });

            modelBuilder.Entity("FiszkiDataBase.TeachSetsFiche", b =>
                {
                    b.HasOne("FiszkiDataBase.DictionaryTypeAnswer", "FirstTypeAnswerNavigation")
                        .WithMany("TeachSetsFiches")
                        .HasForeignKey("FirstTypeAnswer")
                        .HasConstraintName("FK__TeachSets__First__45F365D3");

                    b.HasOne("FiszkiDataBase.SetsFiche", "IdSetFicheNavigation")
                        .WithMany("TeachSetsFiches")
                        .HasForeignKey("IdSetFiche")
                        .HasConstraintName("FK_TeachSetFiche");

                    b.Navigation("FirstTypeAnswerNavigation");

                    b.Navigation("IdSetFicheNavigation");
                });

            modelBuilder.Entity("FiszkiDataBase.DictionaryTypeAnswer", b =>
                {
                    b.Navigation("TeachBags");

                    b.Navigation("TeachSetsFiches");
                });

            modelBuilder.Entity("FiszkiDataBase.DictionaryTypeContent", b =>
                {
                    b.Navigation("FicheResponses");

                    b.Navigation("Fiches");
                });

            modelBuilder.Entity("FiszkiDataBase.Fiche", b =>
                {
                    b.Navigation("FicheResponses");

                    b.Navigation("FicheTeachStates");
                });

            modelBuilder.Entity("FiszkiDataBase.File", b =>
                {
                    b.Navigation("FicheResponses");

                    b.Navigation("Fiches");
                });

            modelBuilder.Entity("FiszkiDataBase.SetsFiche", b =>
                {
                    b.Navigation("Fiches");

                    b.Navigation("TeachSetsFiches");
                });

            modelBuilder.Entity("FiszkiDataBase.TeachSetsFiche", b =>
                {
                    b.Navigation("FicheTeachStates");

                    b.Navigation("TeachBags");
                });

            modelBuilder.Entity("FiszkiDataBase.User", b =>
                {
                    b.Navigation("SetsFiches");
                });
#pragma warning restore 612, 618
        }
    }
}
