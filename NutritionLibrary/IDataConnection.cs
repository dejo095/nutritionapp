using NutritionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionLibrary
{
    public interface IDataConnection
    {
        List<TypeModel> Types_GetByName(string name);


        UnitModel Units_Insert(UnitModel model);

        List<UnitModel> Units_GetByName(string name);

        List<UnitModel> Units_GetAll();


        FoodModel InsertFood(FoodModel food);

        int Foods_GetSum();

        List<FoodModel> Foods_GetAll();

        List<FoodModel> Foods_FindAll(string name);

        void Foods_Remove(FoodModel food);
        bool InsertIngredientsForFood(List<IngredientModel> ingredients);


        ServingSizeModel ServingSizes_Insert(ServingSizeModel model);
        List<ServingSizeModel> ServingSizes_GetAll();


        StyleModel Styles_Insert(StyleModel model);
        List<StyleModel> Styles_GetAll();


    }
}
