using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FiszkiDataBase;

public partial class Foryoutube2Context : DbContext
{
    public Foryoutube2Context()
    {
    }

    public Foryoutube2Context(DbContextOptions<Foryoutube2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<DictionaryTypeAnswer> DictionaryTypeAnswers { get; set; }

    public virtual DbSet<DictionaryTypeContent> DictionaryTypeContents { get; set; }

    public virtual DbSet<Fiche> Fiches { get; set; }

    public virtual DbSet<FicheAnswer> FicheAnswers { get; set; }

    public virtual DbSet<FicheResponse> FicheResponses { get; set; }

    public virtual DbSet<FicheTeachState> FicheTeachStates { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<SetsFiche> SetsFiches { get; set; }

    public virtual DbSet<TeachBag> TeachBags { get; set; }

    public virtual DbSet<TeachSetsFiche> TeachSetsFiches { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=foryoutube2;Integrated Security=SSPI;Trusted_Connection=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DictionaryTypeAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Dictiona__3214EC07B7D4D22D");

            entity.ToTable("DictionaryTypeAnswer");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DictionaryTypeContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Dictiona__3214EC07F86D7FEA");

            entity.ToTable("DictionaryTypeContent");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Fiche>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fiche__3214EC077185F5EA");

            entity.ToTable("Fiche");

            entity.Property(e => e.Prompt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Response)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdFileNavigation).WithMany(p => p.Fiches)
                .HasForeignKey(d => d.IdFile)
                .HasConstraintName("FK__Fiche__IdFile__3C69FB99");

            entity.HasOne(d => d.IdSetFicheNavigation).WithMany(p => p.Fiches)
                .HasForeignKey(d => d.IdSetFiche)
                .HasConstraintName("FK__Fiche__IdSetFich__3B75D760");

            entity.HasOne(d => d.TypePromptNavigation).WithMany(p => p.Fiches)
                .HasForeignKey(d => d.TypePrompt)
                .HasConstraintName("FK__Fiche__TypePromp__3A81B327");
        });

        modelBuilder.Entity<FicheAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FicheAns__3214EC07EC6B5CEF");

            entity.ToTable("FicheAnswer");

            entity.Property(e => e.DateAnswering).HasColumnType("datetime");
        });

        modelBuilder.Entity<FicheResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FicheRes__3214EC0757D0C7DD");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdFicheNavigation).WithMany(p => p.FicheResponses)
                .HasForeignKey(d => d.IdFiche)
                .HasConstraintName("FK__FicheResp__IdFic__3F466844");

            entity.HasOne(d => d.IdFileNavigation).WithMany(p => p.FicheResponses)
                .HasForeignKey(d => d.IdFile)
                .HasConstraintName("FK__FicheResp__IdFil__3E52440B");

            entity.HasOne(d => d.TypePromptNavigation).WithMany(p => p.FicheResponses)
                .HasForeignKey(d => d.TypePrompt)
                .HasConstraintName("FK__FicheResp__TypeP__3D5E1FD2");
        });

        modelBuilder.Entity<FicheTeachState>(entity =>
        {
            entity.HasKey(e => new { e.IdTeachSet, e.IdFiche }).HasName("PK__FicheTea__6D05EC33244D6B63");

            entity.ToTable("FicheTeachState");

            entity.Property(e => e.NextTry).HasColumnType("datetime");

            entity.HasOne(d => d.IdFicheNavigation).WithMany(p => p.FicheTeachStates)
                .HasForeignKey(d => d.IdFiche)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FicheTeac__IdFic__403A8C7D");

            entity.HasOne(d => d.IdTeachSetNavigation).WithMany(p => p.FicheTeachStates)
                .HasForeignKey(d => d.IdTeachSet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FicheTeac__IdTea__412EB0B6");
        });

        modelBuilder.Entity<File>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__File__3214EC07ADBF8066");

            entity.ToTable("File");

            entity.Property(e => e.FileExtension)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SetsFiche>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SetsFich__3214EC0719F640B8");

            entity.ToTable("SetsFiche");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.SetsFiches)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_PersonOrder");
        });

        modelBuilder.Entity<TeachBag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TeachBag__3214EC07DFE4CDB2");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdTeachSetNavigation).WithMany(p => p.TeachBags)
                .HasForeignKey(d => d.IdTeachSet)
                .HasConstraintName("FK_IdTeachFiche");

            entity.HasOne(d => d.TypeAnswerNavigation).WithMany(p => p.TeachBags)
                .HasForeignKey(d => d.TypeAnswer)
                .HasConstraintName("FK_TeachBag");
        });

        modelBuilder.Entity<TeachSetsFiche>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TeachSet__3214EC074AF16EBD");

            entity.ToTable("TeachSetsFiche");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.FirstTypeAnswerNavigation).WithMany(p => p.TeachSetsFiches)
                .HasForeignKey(d => d.FirstTypeAnswer)
                .HasConstraintName("FK__TeachSets__First__45F365D3");

            entity.HasOne(d => d.IdSetFicheNavigation).WithMany(p => p.TeachSetsFiches)
                .HasForeignKey(d => d.IdSetFiche)
                .HasConstraintName("FK_TeachSetFiche");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC075668D08A");

            entity.HasIndex(e => e.Login, "UQ__Users__5E55825B7500623E").IsUnique();

            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
