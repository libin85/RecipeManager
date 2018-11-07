using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeManager.Api.Entities
{
    [Table("Recipes")]
    public class Recipe
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(750)]
        public string Title { get; set; }

        public string FoodImage { get; set; }

        [Required]
        [MaxLength(250)]
        public string CookingDescription { get; set; }
    }
}
