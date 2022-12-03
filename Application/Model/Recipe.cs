using Application.Model;

namespace Application;

public class Recipe
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public string PreparationInstructions { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; }
}
