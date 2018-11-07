using System;
using Microsoft.EntityFrameworkCore;
using RecipeManager.Api.Entities;

namespace RecipeManager.Api.Context
{
    public class RecipesContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }

        public RecipesContext(DbContextOptions<RecipesContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe()
                {
                    Id = Guid.Parse("e28d1220-fd16-4f4b-b33b-494f108d8798"),
                    Title = "Mexican street salad",
                    FoodImage = "",
                    CookingDescription = "tristique nulla aliquet enim tortor at auctor urna nunc id cursus metus aliquam eleifend mi in nulla posuere sollicitudin aliquam ultrices sagittis orci a scelerisque"
                },
                new Recipe()
                {
                    Id = Guid.Parse("0d458067-0aa2-4fe3-96b2-18332ec0ace5"),
                    Title = "Mexican chicken tenders tray bake",
                    FoodImage = "",
                    CookingDescription = "nisl rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui sapien eget mi proin sed libero enim sed faucibus turpis in eu mi bibendum"
                },
                new Recipe()
                {
                    Id = Guid.Parse("9af1ef0a-2b38-47ca-9244-0de85bf28bf7"),
                    Title = "Sweet and spicy chicken dippers with creamy dipping sauce",
                    FoodImage = "",
                    CookingDescription = "a scelerisque purus semper eget duis at tellus at urna condimentum mattis pellentesque id nibh tortor id aliquet lectus proin nibh nisl condimentum id venenatis"
                },
                new Recipe()
                {
                    Id = Guid.Parse("eeb31370-9b51-4990-9d50-ba9924ecb877"),
                    Title = "Mexican chicken with black bean salsa",
                    FoodImage = "",
                    CookingDescription = "eu ultrices vitae auctor eu augue ut lectus arcu bibendum at varius vel pharetra vel turpis nunc eget lorem dolor sed viverra ipsum nunc aliquet"
                }
            );

            base.OnModelCreating(modelBuilder);
        }


    }
}
