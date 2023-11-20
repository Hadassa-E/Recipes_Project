
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Classes;
namespace BLL.Interfaces
{

    public interface IRecipeBll
    {
        List<RecipeDto> GetAll();
        List<RecipeDto> Delete(int id);
        RecipeDto GetById(int id);
        RecipeDto Add(RecipeDto recipe);
        RecipeDto Update(int id, RecipeDto recipe);

    }
}