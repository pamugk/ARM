namespace ARM.UsersDBModel
{
    using System.Data.Entity;

    public partial class UsersModel : DbContext
    {
        public UsersModel()
            : base("name=UsersModel")
        {
        }

        public virtual DbSet<Пользователи> Пользователи { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Пользователи>()
                .Property(e => e.Хэш_пароля)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Пользователи>()
                .Property(e => e.Соль)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}