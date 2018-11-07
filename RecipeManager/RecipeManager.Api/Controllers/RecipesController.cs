using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RecipeManager.Api.Models;
using RecipeManager.Api.Services;

namespace RecipeManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private IRecipesRepository _recipesRepository;
        private readonly IMapper _mapper;
        public RecipesController(IRecipesRepository recipesRepository,
                               IMapper mapper)
        {
            _recipesRepository = recipesRepository ?? throw new ArgumentNullException(nameof(recipesRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET: api/recipes
        [HttpGet]
        public async Task<IActionResult> GetRecipes()
        {
            var recipes = await _recipesRepository.GetRecipesAsync();
            return Ok(recipes);
        }

        //GET api/recipes/5
        [HttpGet("{id}")]
        [Route("{id}", Name = "GetRecipe")]
        public async Task<IActionResult> GetRecipe(Guid id)
        {
            var recipe = await _recipesRepository.GetRecipeAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return Ok(recipe);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecipe([FromBody]RecipeCreateDto recipe)
        {
            var recipeEntity = _mapper.Map<Entities.Recipe>(recipe);
            _recipesRepository.AddRecipe(recipeEntity);
            await _recipesRepository.SaveChangesAsync();

            await _recipesRepository.GetRecipeAsync(recipeEntity.Id);

            return CreatedAtRoute("GetRecipe",
                new { id = recipeEntity.Id },
                recipeEntity);
        }
    }
}
