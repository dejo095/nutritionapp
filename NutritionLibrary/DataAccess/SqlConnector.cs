using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using NutritionLibrary.Models;

namespace NutritionLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string dbName = "nutritionapp";

        // Here goes methods that will execute stored procedures
        // Methods used here are the ones from IDataConnection interface, so first declare them there

        public List<StyleModel> Styles_GetAll()
        {
            List<StyleModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                output = connection.Query<StyleModel>("dbo.spStyles_GetAll").ToList();
            }

            return output;
        }

        public List<ServingSizeModel> ServingSizes_GetAll()
        {
            List<ServingSizeModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                output = connection.Query<ServingSizeModel>("dbo.spServingSizes_GetAll").ToList();
            }

            return output;
        }

        public List<TypeModel> Types_GetByName(string name)
        {
            List<TypeModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                var p = new DynamicParameters();
                p.Add("@name", name);
                output = connection.Query<TypeModel>("dbo.spTypes_GetByName", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<UnitModel> Units_GetByName(string name)
        {
            List<UnitModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                var p = new DynamicParameters();
                p.Add("@name", name);
                output = connection.Query<UnitModel>("dbo.spUnits_GetByName", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public FoodModel InsertFood(FoodModel food)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                var p = new DynamicParameters();

                p.Add("@Name", food.Name);
                p.Add("@Notes", food.Notes);

                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spFoods_Insert", p, commandType: CommandType.StoredProcedure);

                food.Id = p.Get<int>("@Id");

                return food;
            }
        }

        public bool InsertIngredientsForFood(List<IngredientModel> ingredients)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                
                foreach (IngredientModel ingredient in ingredients)
                {
                    var p = new DynamicParameters();

                    p.Add("@Food_Id", ingredient.Food_id);
                    p.Add("@Style_Id", ingredient.Style_Id);
                    p.Add("@ServingSize_Id", ingredient.ServingSize_Id);
                    p.Add("@Type_Id", ingredient.Type_Id);
                    p.Add("@Quantity", ingredient.Quantity);
                    p.Add("@Unit_Id", ingredient.Unit_Id);
                    p.Add("@Notes", ingredient.Notes);

                    try
                    {
                        connection.Execute("dbo.spIngredients_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                    catch (Exception)
                    {
                        throw new Exception("Error with adding ingredient");
                    }

                }
                               
                return true;
            }
        }

        public int Foods_GetSum()
        {
            int output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                var p = new DynamicParameters();

                p.Add("@Sum", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spFoods_GetSum", p, commandType: CommandType.StoredProcedure);

                output = p.Get<int>("@Sum");

                return output;
            }

        }

        public void Foods_Remove(FoodModel food)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", food.Id);
                connection.Query<FoodModel>("dbo.spFoods_Remove", p, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
