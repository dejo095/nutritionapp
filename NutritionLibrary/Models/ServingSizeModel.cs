using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionLibrary.Models
{
    public class ServingSizeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal DataValue { get; set; }
        public int UnitId { get; set; }
    }
}
