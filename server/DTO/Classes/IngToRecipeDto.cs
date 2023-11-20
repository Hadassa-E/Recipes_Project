using DTO.Classes;
using System;
using System.Collections.Generic;

namespace DTO.Classes;

public partial class IngToRecipeDto
{
    public int Id { get; set; }

    public int RecipeId { get; set; }

    //public string RecipeName { get; set; }
    public int IngId { get; set; }

    public double Quantity { get; set; }

   

    
}
