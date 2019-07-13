namespace MVC_HW.Models
{
    using System.Data.Entity;

    public partial class AccountBookEntity : DbContext
    {
        public AccountBookEntity()
            : base("name=AccountBookEntity")
        {
        }

        public virtual DbSet<AccountBook> AccountBook { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}