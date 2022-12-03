using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application
{
    public class RecipeQuery
    {
        public IEnumerable<Recipe> GetRecipes() => Seed.GetData();

        public Recipe GetRecipe(Guid id) => Seed.GetRecipe(id);
    }
}