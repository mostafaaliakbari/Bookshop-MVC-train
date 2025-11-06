using Microsoft.EntityFrameworkCore;
using UI_MVC.Entitis;
using UI_MVC.Inferastructure.config;

namespace UI_MVC.Inferastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-A0067M7\\SQLEXPRESS;Initial Catalog=BookShopDB;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new CategoriesConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());

            modelBuilder.Entity<Book>().HasData(new List<Book>() {
            new Book(){
            Id = 1,
            Title = "مردی که میخندد",
            Author ="ویکتور هوگو",
            PageCount = 300,
            Price = 350,
            CategoryId = 1,
            ImgAddress ="address"
        
            },
            new Book(){
            Id = 2,
            Title = "نبرد من",
            Author ="آدولف هیتلر",
            PageCount = 300,
            Price = 410,
            CategoryId = 2,
            ImgAddress ="address"

            }

            });
            modelBuilder.Entity<Category>().HasData(new List<Category>()
            {
                new Category(){ Id = 1,
                Name = "رمان",
                //ImgAddress="address",




            },
                new Category(){ Id = 2,
                Name = "تاریخی",
               // ImgAddress="address"

                } }
                );
            }
    }
}
