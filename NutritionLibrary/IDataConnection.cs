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
        // for getting food styles we will use to populate combobox
        List<StyleModel> Styles_GetAll();

        // for getting serving sizes we will use to populate combobox
        List<ServingSizeModel> ServingSizes_GetAll();

        // for getting type id which woill be used in saving ingredient data
        List<TypeModel> Types_GetByName(string name);

        // for getting Unit id which woill be used in saving ingredient data
        List<UnitModel> Units_GetByName(string name);

        List<UnitModel> Units_GetAll();

        FoodModel InsertFood(FoodModel food);

        bool InsertIngredientsForFood(List<IngredientModel> ingredients);

        int Foods_GetSum();

        void Foods_Remove(FoodModel food);

        ServingSizeModel ServingSizes_Insert(ServingSizeModel model);

        StyleModel Styles_Insert(StyleModel model);
    }
}
