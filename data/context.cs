namespace domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class context : DbContext
    {
        public context()
            : base("name=context")
        {
        }

        public virtual DbSet<avis> avis { get; set; }
        public virtual DbSet<commentaire> commentaire { get; set; }
        public virtual DbSet<critere> critere { get; set; }
        public virtual DbSet<document> document { get; set; }
        public virtual DbSet<employe> employe { get; set; }
        public virtual DbSet<evaluation> evaluation { get; set; }
        public virtual DbSet<evaluation360> evaluation360 { get; set; }
        public virtual DbSet<formateur> formateur { get; set; }
        public virtual DbSet<formation> formation { get; set; }
        public virtual DbSet<invetation> invetation { get; set; }
        public virtual DbSet<participation> participation { get; set; }
        public virtual DbSet<post> post { get; set; }
        public virtual DbSet<projet> projet { get; set; }
        public virtual DbSet<question> question { get; set; }
        public virtual DbSet<reponce> reponce { get; set; }
        public virtual DbSet<skills> skills { get; set; }
        public virtual DbSet<tache> tache { get; set; }
        public virtual DbSet<test> test { get; set; }
        public virtual DbSet<document_employe> document_employe { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<avis>()
                .Property(e => e.contenu)
                .IsUnicode(false);

            modelBuilder.Entity<critere>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<critere>()
                .Property(e => e.niveau)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .Property(e => e.nomdoc)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .HasMany(e => e.document_employe)
                .WithRequired(e => e.document)
                .HasForeignKey(e => e.documents_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.isActif)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.EM_Password)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.codeqr)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.avis)
                .WithOptional(e => e.employe)
                .HasForeignKey(e => e.employe_id);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.commentaire)
                .WithOptional(e => e.employe)
                .HasForeignKey(e => e.employecommentaire_id);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.evaluation)
                .WithOptional(e => e.employe)
                .HasForeignKey(e => e.evaluationEmploye_id);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.evaluation360)
                .WithOptional(e => e.employe)
                .HasForeignKey(e => e.evaluationEmploye360_id);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .HasMany(e => e.avis)
                .WithOptional(e => e.evaluation)
                .HasForeignKey(e => e.evaluation_id);

            modelBuilder.Entity<evaluation>()
                .HasMany(e => e.critere)
                .WithOptional(e => e.evaluation)
                .HasForeignKey(e => e.emlployeid);

            modelBuilder.Entity<evaluation360>()
                .HasMany(e => e.commentaire)
                .WithOptional(e => e.evaluation360)
                .HasForeignKey(e => e.commentaireEvzl360_id);

            modelBuilder.Entity<formateur>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .Property(e => e.nomPrenom)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .Property(e => e.specialiste)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .HasMany(e => e.formation)
                .WithOptional(e => e.formateur)
                .HasForeignKey(e => e.formateur_id);

            modelBuilder.Entity<formateur>()
                .HasMany(e => e.skills)
                .WithMany(e => e.formateur)
                .Map(m => m.ToTable("formateur_skills").MapLeftKey("formateurs_id").MapRightKey("skillss_id"));

            modelBuilder.Entity<formation>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .HasMany(e => e.invetation)
                .WithRequired(e => e.formation)
                .HasForeignKey(e => e.idFormation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<formation>()
                .HasMany(e => e.participation)
                .WithRequired(e => e.formation)
                .HasForeignKey(e => e.idFormation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<formation>()
                .HasMany(e => e.test)
                .WithOptional(e => e.formation)
                .HasForeignKey(e => e.formation_id);

            modelBuilder.Entity<invetation>()
                .Property(e => e.etat_Invitation)
                .IsUnicode(false);

            modelBuilder.Entity<post>()
                .Property(e => e.body)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .HasMany(e => e.tache)
                .WithOptional(e => e.projet)
                .HasForeignKey(e => e.projet_id);

            modelBuilder.Entity<question>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .Property(e => e.libelle)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .HasMany(e => e.reponce)
                .WithOptional(e => e.question)
                .HasForeignKey(e => e.question_id);

            modelBuilder.Entity<reponce>()
                .Property(e => e.libelle)
                .IsUnicode(false);

            modelBuilder.Entity<skills>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<skills>()
                .Property(e => e.level)
                .IsUnicode(false);

            modelBuilder.Entity<skills>()
                .HasMany(e => e.formation)
                .WithMany(e => e.skills)
                .Map(m => m.ToTable("formation_skills").MapLeftKey("skillss_id").MapRightKey("formations_id"));

            modelBuilder.Entity<tache>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<tache>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<tache>()
                .HasMany(e => e.skills)
                .WithMany(e => e.tache)
                .Map(m => m.ToTable("tache_skills", "advyteam").MapLeftKey("taches_id").MapRightKey("skillss_id"));

            modelBuilder.Entity<test>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<test>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<test>()
                .HasMany(e => e.formation1)
                .WithOptional(e => e.test1)
                .HasForeignKey(e => e.test_id);

            modelBuilder.Entity<test>()
                .HasMany(e => e.question)
                .WithOptional(e => e.test)
                .HasForeignKey(e => e.test_id);
        }
    }
}
