using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {

        }
        public DbSet<ToDoItem> ToDoItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().HasData(
                new ToDoItem() { Id = 1, Title = "Cook dinner", Done = false },
                new ToDoItem() { Id = 2, Title = "Exercise", Done = true },
                new ToDoItem() { Id = 3, Title = "Read a book", Done = false },
                new ToDoItem() { Id = 4, Title = "Go shopping", Done = true }
                );
        }
    }
}
