using System.Reflection;
using Microsoft.EntityFrameworkCore;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         //   optionsBuilder.UseSqlite("app.db");
           optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DB_RefHub_EFCore_Sample1;Integrated Security=True;Multiple Active Result Sets=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(AppDbContext)));
            base.OnModelCreating(modelBuilder);
        }

        #region Tables


        public DbSet<Another> Another { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookToAnother> BookToAnother { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CommentToBlog> CommentToBlog { get; set; }
        public DbSet<CommentToBook> CommentToBook { get; set; }
        public DbSet<FileManager> FileManager { get; set; }
        public DbSet<FileToBlog> FileToBlog { get; set; }
        public DbSet<FileToBook> FileToBook { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<PersonLevel> PersonLevel { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<TagToBlog> TagToBlog { get; set; }
        public DbSet<TagToBook> TagToBook { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddress { get; set; }
        public DbSet<UserToRole> UserToRole { get; set; }
        #endregion


        #region UpdateAutoProperty


        public override int SaveChanges()
        {

            UpdateShadowProperties();

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            UpdateShadowProperties();
            return base.SaveChangesAsync(cancellationToken);

        }

        private void UpdateShadowProperties()
        {
            foreach (var entry in ChangeTracker.Entries().Where(e => e.State == EntityState.Modified))
            {
                entry.Property("UpdateDate").CurrentValue = DateTime.Now;
            }
        }

        #endregion
    }
}
