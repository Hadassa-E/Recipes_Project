using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Ing
{
    public int IngId { get; set; }

    public string IngName { get; set; } = null!;

    public virtual ICollection<IngToRecipe> IngToRecipes { get; set; } = new List<IngToRecipe>();
}
