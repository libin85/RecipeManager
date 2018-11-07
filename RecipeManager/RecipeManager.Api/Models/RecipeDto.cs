using System;
namespace RecipeManager.Api.Models
{
    public class RecipeDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string FoodImage { get; set; }

        public string CookingDescription { get; set; }
    }
}
