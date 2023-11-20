using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Recipe
{
    public int RecipeId { get; set; }

    public string RecipeName { get; set; } = null!;

    public string? Pic { get; set; }

    public string? Level { get; set; }

    public int? Time { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<IngToRecipe> IngToRecipes { get; set; } = new List<IngToRecipe>();

    public virtual User User { get; set; } = null!;
}
