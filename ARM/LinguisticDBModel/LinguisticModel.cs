namespace ARM.LinguisticDBModel
{
    using System.Data.Entity;

    public partial class LinguisticModel : DbContext
    {
        public LinguisticModel()
            : base("name=LinguisticModel")
        {
        }

        public virtual DbSet<Число_носителей_языков> Число_носителей_языков { get; set; }
        public virtual DbSet<Этнографические_организации> Этнографические_организации { get; set; }
        public virtual DbSet<Языки> Языки { get; set; }
        public virtual DbSet<Языковые_макросемьи> Языковые_макросемьи { get; set; }
        public virtual DbSet<Языковые_семьи> Языковые_семьи { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Этнографические_организации>()
                .HasMany(e => e.Число_носителей_языков)
                .WithRequired(e => e.Этнографические_организации)
                .HasForeignKey(e => e.ID_организации__производившей_подсчет)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Языки>()
                .HasMany(e => e.Число_носителей_языков)
                .WithRequired(e => e.Языки)
                .HasForeignKey(e => e.ID_языка)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Языковые_макросемьи>()
                .HasMany(e => e.Языковые_семьи)
                .WithOptional(e => e.Языковые_макросемьи)
                .HasForeignKey(e => e.ID_языковой_макросемьи);

            modelBuilder.Entity<Языковые_семьи>()
                .HasMany(e => e.Языки)
                .WithRequired(e => e.Языковые_семьи)
                .HasForeignKey(e => e.ID_языковой_семьи)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Число_носителей_языков>()
                .HasKey(lcRecord => new
                {
                    lcRecord.ID_языка,
                    lcRecord.Дата_подсчёта,
                    lcRecord.ID_организации__производившей_подсчет
                });
        }
    }
}