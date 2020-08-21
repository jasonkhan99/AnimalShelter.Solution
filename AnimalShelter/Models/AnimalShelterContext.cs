using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId = 1, Name = "Matilda", Type = "Cat", Age = 7, Gender = "Female" },
            new Animal { AnimalId = 2, Name = "Rexie", Type = "Dog", Age = 10, Gender = "Female" },
            new Animal { AnimalId = 3, Name = "Matilda", Type = "Dog", Age = 2, Gender = "Female" },
            new Animal { AnimalId = 4, Name = "Pip", Type = "Cat", Age = 4, Gender = "Male" },
            new Animal { AnimalId = 5, Name = "Bartholomew", Type = "Dog", Age = 5, Gender = "Male" }
          );
        }
    }
}