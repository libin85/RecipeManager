using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipeManager.Api.Services
{
    public interface IRecipesRepository
    {
        Task<IEnumerable<Entities.Recipe>> GetRecipesAsync();

        Task<Entities.Recipe> GetRecipeAsync(Guid id);

        void AddRecipe(Entities.Recipe recipe);

        Task<bool> SaveChangesAsync();
    }
}
