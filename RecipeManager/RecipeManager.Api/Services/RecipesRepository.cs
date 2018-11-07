using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeManager.Api.Context;
using RecipeManager.Api.Entities;

namespace RecipeManager.Api.Services
{
    public class RecipesRepository : IRecipesRepository, IDisposable
    {
        private RecipesContext _recipiesContext;
        public RecipesRepository(RecipesContext recipesContext)
        {
            _recipiesContext = recipesContext ?? throw new ArgumentNullException(nameof(recipesContext));
        }

        public void AddRecipe(Recipe recipe)
        {
            if (recipe == null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }
            _recipiesContext.Add(recipe);
        }

        public async Task<Recipe> GetRecipeAsync(Guid id)
        {
            return await _recipiesContext.Recipes.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<IEnumerable<Recipe>> GetRecipesAsync()
        {
            return await _recipiesContext.Recipes.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            // return true if 1 or more entities were changed
            return (await _recipiesContext.SaveChangesAsync() > 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_recipiesContext != null)
                {
                    _recipiesContext.Dispose();
                    _recipiesContext = null;
                }
            }
        }
    }
}
