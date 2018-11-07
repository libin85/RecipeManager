using System;
namespace RecipeManager.Api.Models
{
    public class RecipeCreateDto
    {
        public string Title { get; set; }

        public string CookingDescription { get; set; }
    }
}
