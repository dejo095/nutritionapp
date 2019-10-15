using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionLibrary.Models
{
    public class IngredientModel
    {
        public int Id { get; set; }
        public int Food_id { get; set; }
        public int Style_Id { get; set; }
        public int ServingSize_Id { get; set; }
        public int Type_Id { get; set; }
        public decimal Quantity { get; set; }
        public int Unit_Id { get; set; }
        public string Notes { get; set; }
    }
}
