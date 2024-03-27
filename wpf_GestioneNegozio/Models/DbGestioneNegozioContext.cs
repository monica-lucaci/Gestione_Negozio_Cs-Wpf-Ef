using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace wpf_GestioneNegozio.Models;

public partial class DbGestioneNegozioContext : DbContext
{
    public DbGestioneNegozioContext()
    {
    }

    public DbGestioneNegozioContext(DbContextOptions<DbGestioneNegozioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Ordine> Ordines { get; set; }

    public virtual DbSet<OrdineVariazione> OrdineVariaziones { get; set; }

    public virtual DbSet<Prodotto> Prodottos { get; set; }

    public virtual DbSet<Utente> Utentes { get; set; }

    public virtual DbSet<Variazione> Variaziones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ACADEMY-01\\SQLEXPRESS;Database=db_GestioneNegozio;User Id=academy;Password=academy1;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__Categori__6378C020860B6ACB");

            entity.HasIndex(e => e.Nome, "UQ__Categori__6F71C0DC985D19B0").IsUnique();

            entity.Property(e => e.CategoriaId).HasColumnName("categoriaID");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Ordine>(entity =>
        {
            entity.HasKey(e => e.OrdineId).HasName("PK__Ordine__8F87D0E5F095DF94");

            entity.ToTable("Ordine");

            entity.Property(e => e.OrdineId).HasColumnName("ordineID");
            entity.Property(e => e.DataOrdine)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("dataOrdine");
            entity.Property(e => e.StatoOrdine)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("statoOrdine");
            entity.Property(e => e.UtenteRif).HasColumnName("utenteRif");

            entity.HasOne(d => d.UtenteRifNavigation).WithMany(p => p.Ordines)
                .HasForeignKey(d => d.UtenteRif)
                .HasConstraintName("FK__Ordine__utenteRi__47DBAE45");
        });

        modelBuilder.Entity<OrdineVariazione>(entity =>
        {
            entity.HasKey(e => e.OrdineVariazione1).HasName("PK__OrdineVa__3534A60D40109B35");

            entity.ToTable("OrdineVariazione");

            entity.Property(e => e.OrdineVariazione1).HasColumnName("ordineVariazione");
            entity.Property(e => e.OrdineRif).HasColumnName("ordineRif");
            entity.Property(e => e.Quantita).HasColumnName("quantita");
            entity.Property(e => e.VariazioneRif).HasColumnName("variazioneRif");

            entity.HasOne(d => d.OrdineRifNavigation).WithMany(p => p.OrdineVariaziones)
                .HasForeignKey(d => d.OrdineRif)
                .HasConstraintName("FK__OrdineVar__ordin__4AB81AF0");

            entity.HasOne(d => d.VariazioneRifNavigation).WithMany(p => p.OrdineVariaziones)
                .HasForeignKey(d => d.VariazioneRif)
                .HasConstraintName("FK__OrdineVar__varia__4BAC3F29");
        });

        modelBuilder.Entity<Prodotto>(entity =>
        {
            entity.HasKey(e => e.ProdottoId).HasName("PK__Prodotto__3AB65975369D4D80");

            entity.ToTable("Prodotto");

            entity.HasIndex(e => e.Nome, "UQ__Prodotto__6F71C0DCB945F417").IsUnique();

            entity.Property(e => e.ProdottoId).HasColumnName("prodottoID");
            entity.Property(e => e.CategoriaRif).HasColumnName("categoriaRif");
            entity.Property(e => e.Descrizione)
                .HasColumnType("text")
                .HasColumnName("descrizione");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.CategoriaRifNavigation).WithMany(p => p.Prodottos)
                .HasForeignKey(d => d.CategoriaRif)
                .HasConstraintName("FK__Prodotto__catego__3B75D760");
        });

        modelBuilder.Entity<Utente>(entity =>
        {
            entity.HasKey(e => e.UtenteId).HasName("PK__Utente__CA5C2253FF90D91A");

            entity.ToTable("Utente");

            entity.HasIndex(e => e.Email, "UQ__Utente__AB6E616466F36A21").IsUnique();

            entity.Property(e => e.UtenteId).HasColumnName("utenteID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Indirizzo)
                .HasColumnType("text")
                .HasColumnName("indirizzo");
            entity.Property(e => e.Nominativo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nominativo");
        });

        modelBuilder.Entity<Variazione>(entity =>
        {
            entity.HasKey(e => e.VariazioneId).HasName("PK__Variazio__54F6EA5AF17D1DDE");

            entity.ToTable("Variazione");

            entity.HasIndex(e => e.Codice, "UQ__Variazio__40F9C18B78193D59").IsUnique();

            entity.Property(e => e.VariazioneId).HasColumnName("variazioneID");
            entity.Property(e => e.Codice)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Colore)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("colore");
            entity.Property(e => e.DataFineOfferta).HasColumnName("dataFineOfferta");
            entity.Property(e => e.DataInizioOfferta).HasColumnName("dataInizioOfferta");
            entity.Property(e => e.LinkImmagine)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("linkImmagine");
            entity.Property(e => e.Prezzo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("prezzo");
            entity.Property(e => e.PrezzoOfferta)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("prezzoOfferta");
            entity.Property(e => e.ProdottoRif).HasColumnName("prodottoRif");
            entity.Property(e => e.Quantita).HasColumnName("quantita");
            entity.Property(e => e.Taglia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("taglia");

            entity.HasOne(d => d.ProdottoRifNavigation).WithMany(p => p.Variaziones)
                .HasForeignKey(d => d.ProdottoRif)
                .HasConstraintName("FK__Variazion__linkI__412EB0B6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
