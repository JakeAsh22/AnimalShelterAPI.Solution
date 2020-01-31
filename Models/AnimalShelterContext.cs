using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Solution.Models
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
                    new Animal { AnimalId = 1, Name = "Matilda", Species = "Cat", Age = 7, Gender = "Female", Description = "Freindly cat that loves getting pet" },
                    new Animal { AnimalId = 2, Name = "Rexie", Species = "Cat", Age = 10, Gender = "Female", Description = "A cat with a personaility, and she will let you know how she is feeling" },
                    new Animal { AnimalId = 3, Name = "Matilda", Species = "Dog", Age = 2, Gender = "Female", Description = "Friendly dog that lives to cuddle and hang out with people" },
                    new Animal { AnimalId = 4, Name = "Pip", Species = "Dog", Age = 4, Gender = "Male", Description = "A ball of energy who loves to play anytime possible" },
                    new Animal { AnimalId = 5, Name = "Bartholomew", Species = "Dog", Age = 12, Gender = "Male", Description = "Was found on the streets, shy at first but once he warms up with you he'll never leave your side" }
                );
        }
    }
}