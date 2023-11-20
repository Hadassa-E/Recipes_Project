using System;
using System.Collections.Generic;

namespace DTO.Classes;

public partial class RecipeDto
{
    public int RecipeId { get; set; }

    public string RecipeName { get; set; } = null!;

    public string? Pic { get; set; }

    public string? Level { get; set; }

    public int? Time { get; set; }

    public int UserId { get; set; }

   

   
}
