using System;
using AutoMapper;

namespace RecipeManager.Api.Profiles
{
    public class RecipesProfile : Profile
    {
        public RecipesProfile()
        {
            CreateMap<Models.RecipeCreateDto, Entities.Recipe>();
        }
    }
}
