using Application.Model;

namespace Application
{
    public class Seed
    {
        public IEnumerable<Recipe> GetData() => _data;

        public Recipe GetRecipe(Guid id) => _data.FirstOrDefault(r => r.Id == id) ?? throw new Exception("Recipe not found");


        private IEnumerable<Recipe> _data = new List<Recipe>
        {
            new Recipe
            {
                Id = new Guid("8ce71d94-a51d-41ec-ba85-8316414208ce"),
                Name = "Scrumbled eggs",
                Description = "Yummy scrumbled eggs",
                PreparationInstructions = "Cut the bacon into small cubes, fry it on the pan until the fat melts out. Then add cut onion to the bacon. Fry until it gets the golden color. Add eggs and the pinch of vegeta and then fry for a minute or 2 untill you get prefered consistence.",
                Ingredients = new List<Ingredient> {
                    new Ingredient
                        {
                            Name = "Egg",
                            Amount = 3,
                            AmountUnit = AmountUnit.Unit
                        },
                    new Ingredient
                        {
                            Name = "Onion",
                            Amount = 0.5,
                            AmountUnit = AmountUnit.Unit
                        },
                    new Ingredient
                        {
                            Name = "Bacon",
                            Amount = 100,
                            AmountUnit = AmountUnit.Gram
                        },
                    new Ingredient
                        {
                            Name = "Vegeta",
                            Amount = 1,
                            AmountUnit = AmountUnit.Pinch
                        },

                },
            },
            new Recipe
            {
                Id = new Guid("a669c09f-461c-4175-ba9b-e94127880d3a"),
                Name = "Sandwich",
                Description = "A regular sandwich",
                PreparationInstructions = "Butter the bread, add ham, cheese and tomato. Sprinkle with onion, black pepper and salt",
                Ingredients = new List<Ingredient> {
                    new Ingredient
                        {
                            Name = "Bread",
                            Amount = 1,
                            AmountUnit = AmountUnit.Slice
                        },
                    new Ingredient
                        {
                            Name = "Onion",
                            Amount = 1,
                            AmountUnit = AmountUnit.Pinch
                        },
                    new Ingredient
                        {
                            Name = "Ham",
                            Amount = 1,
                            AmountUnit = AmountUnit.Slice
                        },
                    new Ingredient
                        {
                            Name = "Cheese",
                            Amount = 1,
                            AmountUnit = AmountUnit.Slice
                        },
                    new Ingredient
                        {
                            Name = "Tomato",
                            Amount = 2,
                            AmountUnit = AmountUnit.Slice
                        },

                },
            },
            new Recipe
            {
                Id = new Guid("4ca866d0-a58f-4111-944a-776cc2bc59ee"),
                Name = "Chicken soup",
                Description = "Delicious chicken broth",
                PreparationInstructions = "Pour water into the pot and boil it. Add salt. When the water starts boiling turn the fire down and throw in the chicken legs. Boil for about 15min. Cut the ingredients and throw them in. The broth should boil just a little bit for about 1-2h.",
                Ingredients = new List<Ingredient> {
                    new Ingredient
                        {
                            Name = "Water",
                            Amount = 1,
                            AmountUnit = AmountUnit.Litre
                        },
                    new Ingredient
                        {
                            Name = "Chicken legs",
                            Amount = 2,
                            AmountUnit = AmountUnit.Unit
                        },
                    new Ingredient
                        {
                            Name = "Carrot",
                            Amount = 1,
                            AmountUnit = AmountUnit.Unit
                        },
                    new Ingredient
                        {
                            Name = "Onion",
                            Amount = 1,
                            AmountUnit = AmountUnit.Unit
                        },
                    new Ingredient
                        {
                            Name = "Celery",
                            Amount = 1,
                            AmountUnit = AmountUnit.Unit
                        },
                    new Ingredient
                        {
                            Name= "salt",
                            Amount = 1,
                            AmountUnit = AmountUnit.Pinch
                        },
                    new Ingredient
                        {
                            Name= "Black pepper",
                            Amount = 1,
                            AmountUnit = AmountUnit.Pinch
                        }

                },
            }
        };
    }
}