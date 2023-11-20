using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class IngToRecipe
{
    public int Id { get; set; }

    public int RecipeId { get; set; }

    public int IngId { get; set; }

    public double Quantity { get; set; }

    public virtual Ing Ing { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;
}
