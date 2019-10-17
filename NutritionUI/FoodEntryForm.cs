using NutritionLibrary;
using NutritionLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionUI
{
    public partial class FoodEntryForm : Form
    {
        private string foodName = null;
        private string foodNotes = "";
        private decimal GI = 0;
        private decimal completnessScore = 0;
        private decimal aminoAcidScore = 0;
        private decimal calories = 0;
        private decimal proteins = 0;
        private decimal carbs = 0;
        private decimal sugars = 0;
        private decimal starch = 0;
        private decimal cholesterol = 0;
        private decimal fiber = 0;
        private decimal dietaryFiber = 0;
        private decimal totalFat = 0;
        private decimal saturatedFat = 0;
        private decimal monoUnsaturatedFat = 0;
        private decimal polyUnsaturatedFat = 0;
        private decimal transFat = 0;
        private decimal omega3Fat = 0;
        private decimal omega6Fat = 0;
        private decimal vitA = 0;
        private decimal vitB6 = 0;
        private decimal vitB12 = 0;
        private decimal vitC = 0;
        private decimal vitD = 0;
        private decimal vitE = 0;
        private decimal vitK = 0;
        private decimal thiamin = 0;
        private decimal riboflavin = 0;
        private decimal niacin = 0;
        private decimal folate = 0;
        private decimal panthothenicAcid = 0;
        private decimal calcium = 0;
        private decimal iron = 0;
        private decimal magnesium = 0;
        private decimal phosphorus = 0;
        private decimal potassium = 0;
        private decimal sodium = 0;
        private decimal zinc = 0;
        private decimal copper = 0;
        private decimal manganese = 0;
        private decimal selenium = 0;

        private List<StyleModel> FoodStylesList = new List<StyleModel>();
        private List<ServingSizeModel> ServingSizeList = new List<ServingSizeModel>();
        private List<IngredientModel> Ingredients = new List<IngredientModel>();

        public FoodEntryForm()
        {
            InitializeComponent();
            populateComboboxes();

            this.foodNameTextbox.Enter += new System.EventHandler(this.foodNameTextbox_Enter);
            this.foodNameTextbox.Leave += new System.EventHandler(this.foodNameTextbox_Leave);

            this.GITextbox.Enter += new System.EventHandler(this.GITextbox_Enter);
            this.GITextbox.Leave += new System.EventHandler(this.GITextbox_Leave);

            this.completnessScoreTextbox.Enter += new System.EventHandler(this.completnessScoreTextbox_Enter);
            this.completnessScoreTextbox.Leave += new System.EventHandler(this.completnessScoreTextbox_Leave);

            this.aminoAcidScoreTextbox.Enter += new System.EventHandler(this.aminoAcidScoreTextbox_Enter);
            this.aminoAcidScoreTextbox.Leave += new System.EventHandler(this.aminoAcidScoreTextbox_Leave);

            this.caloriesTextbox.Enter += new System.EventHandler(this.caloriesTextbox_Enter);
            this.caloriesTextbox.Leave += new System.EventHandler(this.caloriesTextbox_Leave);

            this.proteinsTextbox.Enter += new System.EventHandler(this.proteinsTextbox_Enter);
            this.proteinsTextbox.Leave += new System.EventHandler(this.proteinsTextbox_Leave);

            this.carbsTextbox.Enter += new System.EventHandler(this.carbsTextbox_Enter);
            this.carbsTextbox.Leave += new System.EventHandler(this.carbsTextbox_Leave);

            this.sugarsTextbox.Enter += new System.EventHandler(this.sugarsTextbox_Enter);
            this.sugarsTextbox.Leave += new System.EventHandler(this.sugarsTextbox_Leave);

            this.starchTextbox.Enter += new System.EventHandler(this.starchTextbox_Enter);
            this.starchTextbox.Leave += new System.EventHandler(this.starchTextbox_Leave);

            this.cholesterolTextbox.Enter += new System.EventHandler(this.cholesterolTextbox_Enter);
            this.cholesterolTextbox.Leave += new System.EventHandler(this.cholesterolTextbox_Leave);

            this.fiberTextbox.Enter += new System.EventHandler(this.fiberTextbox_Enter);
            this.fiberTextbox.Leave += new System.EventHandler(this.fiberTextbox_Leave);

            this.dietaryFiberTextbox.Enter += new System.EventHandler(this.dietaryFiberTextbox_Enter);
            this.dietaryFiberTextbox.Leave += new System.EventHandler(this.dietaryFiberTextbox_Leave);

            this.totalFatTextbox.Enter += new System.EventHandler(this.totalFatTextbox_Enter);
            this.totalFatTextbox.Leave += new System.EventHandler(this.totalFatTextbox_Leave);

            this.saturatedFatTextbox.Enter += new System.EventHandler(this.saturatedFatTextbox_Enter);
            this.saturatedFatTextbox.Leave += new System.EventHandler(this.saturatedFatTextbox_Leave);

            this.monoUnsaturatedFatTextbox.Enter += new System.EventHandler(this.monoUnsaturatedFatTextbox_Enter);
            this.monoUnsaturatedFatTextbox.Leave += new System.EventHandler(this.monoUnsaturatedFatTextbox_Leave);

            this.polyUnsaturatedFatTextbox.Enter += new System.EventHandler(this.polyUnsaturatedFatTextbox_Enter);
            this.polyUnsaturatedFatTextbox.Leave += new System.EventHandler(this.polyUnsaturatedFatTextbox_Leave);

            this.transFatTextbox.Enter += new System.EventHandler(this.transFatTextbox_Enter);
            this.transFatTextbox.Leave += new System.EventHandler(this.transFatTextbox_Leave);

            this.omega3FatTextbox.Enter += new System.EventHandler(this.omega3FatTextbox_Enter);
            this.omega3FatTextbox.Leave += new System.EventHandler(this.omega3FatTextbox_Leave);

            this.omega6FatTextbox.Enter += new System.EventHandler(this.omega6FatTextbox_Enter);
            this.omega6FatTextbox.Leave += new System.EventHandler(this.omega6FatTextbox_Leave);

            this.vitATextbox.Enter += new System.EventHandler(this.vitATextbox_Enter);
            this.vitATextbox.Leave += new System.EventHandler(this.vitATextbox_Leave);

            this.vitB6Textbox.Enter += new System.EventHandler(this.vitB6Textbox_Enter);
            this.vitB6Textbox.Leave += new System.EventHandler(this.vitB6Textbox_Leave);

            this.vitB12Textbox.Enter += new System.EventHandler(this.vitB12Textbox_Enter);
            this.vitB12Textbox.Leave += new System.EventHandler(this.vitB12Textbox_Leave);

            this.vitCTextbox.Enter += new System.EventHandler(this.vitCTextbox_Enter);
            this.vitCTextbox.Leave += new System.EventHandler(this.vitCTextbox_Leave);

            this.vitDTextbox.Enter += new System.EventHandler(this.vitDTextbox_Enter);
            this.vitDTextbox.Leave += new System.EventHandler(this.vitDTextbox_Leave);

            this.vitETextbox.Enter += new System.EventHandler(this.vitETextbox_Enter);
            this.vitETextbox.Leave += new System.EventHandler(this.vitETextbox_Leave);

            this.vitKTextbox.Enter += new System.EventHandler(this.vitKTextbox_Enter);
            this.vitKTextbox.Leave += new System.EventHandler(this.vitKTextbox_Leave);

            this.thiaminTextbox.Enter += new System.EventHandler(this.thiaminTextbox_Enter);
            this.thiaminTextbox.Leave += new System.EventHandler(this.thiaminTextbox_Leave);

            this.riboflavinTextbox.Enter += new System.EventHandler(this.riboflavinTextbox_Enter);
            this.riboflavinTextbox.Leave += new System.EventHandler(this.riboflavinTextbox_Leave);

            this.niacinTextbox.Enter += new System.EventHandler(this.niacinTextbox_Enter);
            this.niacinTextbox.Leave += new System.EventHandler(this.niacinTextbox_Leave);

            this.folateTextbox.Enter += new System.EventHandler(this.folateTextbox_Enter);
            this.folateTextbox.Leave += new System.EventHandler(this.folateTextbox_Leave);

            this.panthothenicAcidTextbox.Enter += new System.EventHandler(this.panthothenicAcidTextbox_Enter);
            this.panthothenicAcidTextbox.Leave += new System.EventHandler(this.panthothenicAcidTextbox_Leave);

            this.calciumTextbox.Enter += new System.EventHandler(this.calciumTextbox_Enter);
            this.calciumTextbox.Leave += new System.EventHandler(this.calciumTextbox_Leave);

            this.ironTextbox.Enter += new System.EventHandler(this.ironTextbox_Enter);
            this.ironTextbox.Leave += new System.EventHandler(this.ironTextbox_Leave);

            this.magnesiumTextbox.Enter += new System.EventHandler(this.magnesiumTextbox_Enter);
            this.magnesiumTextbox.Leave += new System.EventHandler(this.magnesiumTextbox_Leave);

            this.phosphorusTextbox.Enter += new System.EventHandler(this.phosphorusTextbox_Enter);
            this.phosphorusTextbox.Leave += new System.EventHandler(this.phosphorusTextbox_Leave);

            this.potassiumTextbox.Enter += new System.EventHandler(this.potassiumTextbox_Enter);
            this.potassiumTextbox.Leave += new System.EventHandler(this.potassiumTextbox_Leave);

            this.sodiumTextbox.Enter += new System.EventHandler(this.sodiumTextbox_Enter);
            this.sodiumTextbox.Leave += new System.EventHandler(this.sodiumTextbox_Leave);

            this.zincTextbox.Enter += new System.EventHandler(this.zincTextbox_Enter);
            this.zincTextbox.Leave += new System.EventHandler(this.zincTextbox_Leave);

            this.copperTextbox.Enter += new System.EventHandler(this.copperTextbox_Enter);
            this.copperTextbox.Leave += new System.EventHandler(this.copperTextbox_Leave);

            this.manganeseTextbox.Enter += new System.EventHandler(this.manganeseTextbox_Enter);
            this.manganeseTextbox.Leave += new System.EventHandler(this.manganeseTextbox_Leave);

            this.seleniumTextbox.Enter += new System.EventHandler(this.seleniumTextbox_Enter);
            this.seleniumTextbox.Leave += new System.EventHandler(this.seleniumTextbox_Leave);

            this.foodNotesTextbox.Enter += new System.EventHandler(this.foodNotesTextbox_Enter);
            this.foodNotesTextbox.Leave += new System.EventHandler(this.foodNotesTextbox_Leave);
        }

        private void populateComboboxes()
        {
            foodStyleCombobox.DataSource = null;
            servingSizeCombobox.DataSource = null;

            // call method that executes stored procedure on db
            FoodStylesList = GlobalConfig.Connection.Styles_GetAll();
            foodStyleCombobox.DataSource = FoodStylesList;
            foodStyleCombobox.DisplayMember = "Name";

            ServingSizeList = GlobalConfig.Connection.ServingSizes_GetAll();
            servingSizeCombobox.DataSource = ServingSizeList;
            servingSizeCombobox.DisplayMember = "Name";

        }

        private void foodNameTextbox_Enter(object sender, EventArgs e)
        {
            foodNameTextbox.Text = "";

        }
        private void foodNameTextbox_Leave(object sender, EventArgs e)
        {
            if (foodNameTextbox.Text.Length != 0) foodName = foodNameTextbox.Text;
            else
            {
                MessageBox.Show("Please enter food name");
                foodNameTextbox.Focus();
            }
        }

        private void GITextbox_Enter(object sender, EventArgs e)
        {
            GITextbox.Text = "";
        }
        private void GITextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(GITextbox.Text, out GI);
            if (!res) GITextbox.Text = "";
        }

        private void completnessScoreTextbox_Enter(object sender, EventArgs e)
        {
            completnessScoreTextbox.Text = "";
        }
        private void completnessScoreTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(completnessScoreTextbox.Text, out completnessScore);
            if (!res) completnessScoreTextbox.Text = "";
        }

        private void aminoAcidScoreTextbox_Enter(object sender, EventArgs e)
        {
            aminoAcidScoreTextbox.Text = "";
        }
        private void aminoAcidScoreTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(aminoAcidScoreTextbox.Text, out aminoAcidScore);
            if (!res) aminoAcidScoreTextbox.Text = "";
        }

        private void caloriesTextbox_Enter(object sender, EventArgs e)
        {
            caloriesTextbox.Text = "";
        }
        private void caloriesTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(caloriesTextbox.Text, out calories);
            if (!res) caloriesTextbox.Text = "";
        }

        private void proteinsTextbox_Enter(object sender, EventArgs e)
        {
            proteinsTextbox.Text = "";
        }
        private void proteinsTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(proteinsTextbox.Text, out proteins);
            if (!res) proteinsTextbox.Text = "";
        }

        private void carbsTextbox_Enter(object sender, EventArgs e)
        {
            carbsTextbox.Text = "";
        }
        private void carbsTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(carbsTextbox.Text, out carbs);
            if (!res) carbsTextbox.Text = "";
        }

        private void sugarsTextbox_Enter(object sender, EventArgs e)
        {
            sugarsTextbox.Text = "";
        }
        private void sugarsTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(sugarsTextbox.Text, out sugars);
            if (!res) sugarsTextbox.Text = "";
        }

        private void starchTextbox_Enter(object sender, EventArgs e)
        {
            starchTextbox.Text = "";
        }
        private void starchTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(starchTextbox.Text, out starch);
            if (!res) starchTextbox.Text = "";
        }

        private void cholesterolTextbox_Enter(object sender, EventArgs e)
        {
            cholesterolTextbox.Text = "";
        }
        private void cholesterolTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(cholesterolTextbox.Text, out cholesterol);
            if (!res) cholesterolTextbox.Text = "";
        }

        private void fiberTextbox_Enter(object sender, EventArgs e)
        {
            fiberTextbox.Text = "";
        }
        private void fiberTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(fiberTextbox.Text, out fiber);
            if (!res) fiberTextbox.Text = "";
        }

        private void dietaryFiberTextbox_Enter(object sender, EventArgs e)
        {
            dietaryFiberTextbox.Text = "";
        }
        private void dietaryFiberTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(dietaryFiberTextbox.Text, out dietaryFiber);
            if (!res) dietaryFiberTextbox.Text = "";
        }

        private void totalFatTextbox_Enter(object sender, EventArgs e)
        {
            totalFatTextbox.Text = "";
        }
        private void totalFatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(totalFatTextbox.Text, out totalFat);
            if (!res) totalFatTextbox.Text = "";
        }

        private void saturatedFatTextbox_Enter(object sender, EventArgs e)
        {
            saturatedFatTextbox.Text = "";
        }
        private void saturatedFatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(saturatedFatTextbox.Text, out saturatedFat);
            if (!res) saturatedFatTextbox.Text = "";
        }

        private void monoUnsaturatedFatTextbox_Enter(object sender, EventArgs e)
        {
            monoUnsaturatedFatTextbox.Text = "";
        }
        private void monoUnsaturatedFatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(monoUnsaturatedFatTextbox.Text, out monoUnsaturatedFat);
            if (!res) monoUnsaturatedFatTextbox.Text = "";
        }

        private void polyUnsaturatedFatTextbox_Enter(object sender, EventArgs e)
        {
            polyUnsaturatedFatTextbox.Text = "";
        }
        private void polyUnsaturatedFatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(polyUnsaturatedFatTextbox.Text, out polyUnsaturatedFat);
            if (!res) polyUnsaturatedFatTextbox.Text = "";
        }

        private void transFatTextbox_Enter(object sender, EventArgs e)
        {
            transFatTextbox.Text = "";
        }
        private void transFatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(transFatTextbox.Text, out transFat);
            if (!res) transFatTextbox.Text = "";
        }

        private void omega3FatTextbox_Enter(object sender, EventArgs e)
        {
            omega3FatTextbox.Text = "";
        }
        private void omega3FatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(omega3FatTextbox.Text, out omega3Fat);
            if (!res) omega3FatTextbox.Text = "";
        }

        private void omega6FatTextbox_Enter(object sender, EventArgs e)
        {
            omega6FatTextbox.Text = "";
        }
        private void omega6FatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(omega6FatTextbox.Text, out omega6Fat);
            if (!res) omega6FatTextbox.Text = "";
        }

        private void vitATextbox_Enter(object sender, EventArgs e)
        {
            vitATextbox.Text = "";
        }
        private void vitATextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitATextbox.Text, out vitA);
            if (!res) vitATextbox.Text = "";
        }

        private void vitB6Textbox_Enter(object sender, EventArgs e)
        {
            vitB6Textbox.Text = "";
        }
        private void vitB6Textbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitB6Textbox.Text, out vitB6);
            if (!res) vitB6Textbox.Text = "";
        }

        private void vitB12Textbox_Enter(object sender, EventArgs e)
        {
            vitB12Textbox.Text = "";
        }
        private void vitB12Textbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitB12Textbox.Text, out vitB12);
            if (!res) vitB12Textbox.Text = "";
        }

        private void vitCTextbox_Enter(object sender, EventArgs e)
        {
            vitCTextbox.Text = "";
        }
        private void vitCTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitCTextbox.Text, out vitC);
            if (!res) vitCTextbox.Text = "";
        }

        private void vitDTextbox_Enter(object sender, EventArgs e)
        {
            vitDTextbox.Text = "";
        }
        private void vitDTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitDTextbox.Text, out vitD);
            if (!res) vitDTextbox.Text = "";
        }

        private void vitETextbox_Enter(object sender, EventArgs e)
        {
            vitETextbox.Text = "";
        }
        private void vitETextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitETextbox.Text, out vitE);
            if (!res) vitETextbox.Text = "";
        }

        private void vitKTextbox_Enter(object sender, EventArgs e)
        {
            vitKTextbox.Text = "";
        }
        private void vitKTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitKTextbox.Text, out vitK);
            if (!res) vitKTextbox.Text = "";
        }

        private void thiaminTextbox_Enter(object sender, EventArgs e)
        {
            thiaminTextbox.Text = "";
        }
        private void thiaminTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(thiaminTextbox.Text, out thiamin);
            if (!res) thiaminTextbox.Text = "";
        }

        private void riboflavinTextbox_Enter(object sender, EventArgs e)
        {
            riboflavinTextbox.Text = "";
        }
        private void riboflavinTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(riboflavinTextbox.Text, out riboflavin);
            if (!res) riboflavinTextbox.Text = "";
        }
        
        private void niacinTextbox_Enter(object sender, EventArgs e)
        {
            niacinTextbox.Text = "";
        }
        private void niacinTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(niacinTextbox.Text, out niacin);
            if (!res) niacinTextbox.Text = "";
        }

        private void folateTextbox_Enter(object sender, EventArgs e)
        {
            folateTextbox.Text = "";
        }
        private void folateTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(folateTextbox.Text, out folate);
            if (!res) folateTextbox.Text = "";
        }

        private void panthothenicAcidTextbox_Enter(object sender, EventArgs e)
        {
            panthothenicAcidTextbox.Text = "";
        }
        private void panthothenicAcidTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(panthothenicAcidTextbox.Text, out panthothenicAcid);
            if (!res) panthothenicAcidTextbox.Text = "";
        }

        private void calciumTextbox_Enter(object sender, EventArgs e)
        {
            calciumTextbox.Text = "";
        }
        private void calciumTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(calciumTextbox.Text, out calcium);
            if (!res) calciumTextbox.Text = "";
        }

        private void ironTextbox_Enter(object sender, EventArgs e)
        {
            ironTextbox.Text = "";
        }
        private void ironTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(ironTextbox.Text, out iron);
            if (!res) ironTextbox.Text = "";
        }

        private void magnesiumTextbox_Enter(object sender, EventArgs e)
        {
            magnesiumTextbox.Text = "";
        }
        private void magnesiumTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(magnesiumTextbox.Text, out magnesium);
            if (!res) magnesiumTextbox.Text = "";
        }

        private void phosphorusTextbox_Enter(object sender, EventArgs e)
        {
            phosphorusTextbox.Text = "";
        }
        private void phosphorusTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(phosphorusTextbox.Text, out phosphorus);
            if (!res) phosphorusTextbox.Text = "";
        }

        private void potassiumTextbox_Enter(object sender, EventArgs e)
        {
            potassiumTextbox.Text = "";
        }
        private void potassiumTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(potassiumTextbox.Text, out potassium);
            if (!res) potassiumTextbox.Text = "";
        }

        private void sodiumTextbox_Enter(object sender, EventArgs e)
        {
            sodiumTextbox.Text = "";
        }
        private void sodiumTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(sodiumTextbox.Text, out sodium);
            if (!res) sodiumTextbox.Text = "";
        }

        private void zincTextbox_Enter(object sender, EventArgs e)
        {
            zincTextbox.Text = "";
        }
        private void zincTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(zincTextbox.Text, out zinc);
            if (!res) zincTextbox.Text = "";
        }

        private void copperTextbox_Enter(object sender, EventArgs e)
        {
            copperTextbox.Text = "";
        }
        private void copperTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(copperTextbox.Text, out copper);
            if (!res) copperTextbox.Text = "";
        }

        private void manganeseTextbox_Enter(object sender, EventArgs e)
        {
            manganeseTextbox.Text = "";
        }
        private void manganeseTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(manganeseTextbox.Text, out manganese);
            if (!res) manganeseTextbox.Text = "";
        }

        private void seleniumTextbox_Enter(object sender, EventArgs e)
        {
            seleniumTextbox.Text = "";
        }
        private void seleniumTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(seleniumTextbox.Text, out selenium);
            if (!res) seleniumTextbox.Text = "";
        }

        private void foodNotesTextbox_Enter(object sender, EventArgs e)
        {
            foodNotesTextbox.Text = "";
        }
        private void foodNotesTextbox_Leave(object sender, EventArgs e)
        {
            if (foodNotesTextbox.Text.Length != 0) foodNotes = foodNotesTextbox.Text;
        }


        private void addFoodButton_Click(object sender, EventArgs e)
        {
            IDataConnection db = GlobalConfig.Connection;

            StyleModel chosenStyle = (StyleModel)foodStyleCombobox.SelectedItem;
            ServingSizeModel chosenServingSize = (ServingSizeModel)servingSizeCombobox.SelectedItem;

            List<TypeModel> chosenType = new List<TypeModel>();

            List<UnitModel> unit_Gram = db.Units_GetByName("gram");
            List<UnitModel> unit_Miligram = db.Units_GetByName("miligram");
            List<UnitModel> unit_Microgram = db.Units_GetByName("microgram");
            List<UnitModel> unit_IU = db.Units_GetByName("iu");
            List<UnitModel> no_unit = db.Units_GetByName("no unit");

            // Need to create food first to be able to get back the ID first
            FoodModel food = new FoodModel();
            food.Name = foodNameTextbox.Text;
            // TODO: do notes here, check if not empty
            //food.Notes = foodNotesTextbox.Text;

            try
            {
                food = db.InsertFood(food);
           
                if (food.Id > 0)
                {
                    // Then lets create ingredients
                    if (GI != 0)
                    {
                        chosenType = db.Types_GetByName("Glycemic Index");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, GI, no_unit[0].Id, null));
                    }
                    if (completnessScore != 0)
                    {
                        chosenType = db.Types_GetByName("Completness Score");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, completnessScore, no_unit[0].Id, null));
                    }
                    if (aminoAcidScore != 0)
                    {
                        chosenType = db.Types_GetByName("Amino Acid Score");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, aminoAcidScore, no_unit[0].Id, null));
                    }
                    if (calories != 0)
                    {
                        chosenType = db.Types_GetByName("Calories");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, calories, no_unit[0].Id, null));
                    }
                    if (proteins != 0)
                    {
                        chosenType = db.Types_GetByName("Proteins");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, proteins, unit_Gram[0].Id, null));
                    }
                    if (carbs != 0)
                    {
                        chosenType = db.Types_GetByName("Carbs");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, carbs, unit_Gram[0].Id, null));
                    }
                    if (sugars != 0)
                    {
                        chosenType = db.Types_GetByName("Sugars");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, sugars, unit_Gram[0].Id, null));
                    }
                    if (starch != 0)
                    {
                        chosenType = db.Types_GetByName("Starch");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, starch, unit_Gram[0].Id, null));
                    }
                    if (cholesterol != 0)
                    {
                        chosenType = db.Types_GetByName("Cholesterol");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, cholesterol, unit_Miligram[0].Id, null));
                    }
                    if (fiber != 0)
                    {
                        chosenType = db.Types_GetByName("Fibers");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, fiber, unit_Gram[0].Id, null));
                    }
                    if (dietaryFiber != 0)
                    {
                        chosenType = db.Types_GetByName("Cholesterol");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, dietaryFiber, unit_Gram[0].Id, null));
                    }
                    if (totalFat != 0)
                    {
                        chosenType = db.Types_GetByName("Total Fat");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, totalFat, unit_Gram[0].Id, null));
                    }
                    if (saturatedFat != 0)
                    {
                        chosenType = db.Types_GetByName("Saturated");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, saturatedFat, unit_Gram[0].Id, null));
                    }
                    if (monoUnsaturatedFat != 0)
                    {
                        chosenType = db.Types_GetByName("Mono Unsaturated");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, monoUnsaturatedFat, unit_Gram[0].Id, null));
                    }
                    if (polyUnsaturatedFat != 0)
                    {
                        chosenType = db.Types_GetByName("Poly Unsaturated");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, polyUnsaturatedFat, unit_Gram[0].Id, null));
                    }
                    if (transFat != 0)
                    {
                        chosenType = db.Types_GetByName("Trans");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, transFat, unit_Gram[0].Id, null));
                    }
                    if (omega3Fat != 0)
                    {
                        chosenType = db.Types_GetByName("Omega 3");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, omega3Fat, unit_Miligram[0].Id, null));
                    }
                    if (omega6Fat != 0)
                    {
                        chosenType = db.Types_GetByName("Omega 6");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, omega6Fat, unit_Gram[0].Id, null));
                    }
                    if (vitA != 0)
                    {
                        chosenType = db.Types_GetByName("Vitamin A");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitA, unit_IU[0].Id, null));
                    }
                    if (vitB6 != 0)
                    {
                        chosenType = db.Types_GetByName("Vitamin B6");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitB6, unit_Miligram[0].Id, null));
                    }
                    if (vitB12 != 0)
                    {
                        chosenType = db.Types_GetByName("Vitamin B12");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitB12, unit_Microgram[0].Id, null));
                    }
                    if (vitC != 0)
                    {
                        chosenType = db.Types_GetByName("Vitamin C");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitC, unit_Miligram[0].Id, null));
                    }
                    if (vitD != 0)
                    {
                        chosenType = db.Types_GetByName("Vitamin D");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitD, unit_Miligram[0].Id, null));
                    }
                    if (vitE != 0)
                    {
                        chosenType = db.Types_GetByName("Vitamin E");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitE, unit_Miligram[0].Id, null));
                    }
                    if (vitK != 0)
                    {
                        chosenType = db.Types_GetByName("Vitamin K");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitK, unit_Microgram[0].Id, null));
                    }
                    if (thiamin != 0)
                    {
                        chosenType = db.Types_GetByName("Thiamin");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, thiamin, unit_Miligram[0].Id, null));
                    }
                    if (riboflavin != 0)
                    {
                        chosenType = db.Types_GetByName("Riboflavin");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, riboflavin, unit_Miligram[0].Id, null));
                    }
                    if (niacin != 0)
                    {
                        chosenType = db.Types_GetByName("Niacin");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, niacin, unit_Miligram[0].Id, null));
                    }
                    if (folate != 0)
                    {
                        chosenType = db.Types_GetByName("Folate");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, folate, unit_Microgram[0].Id, null));
                    }
                    if (panthothenicAcid != 0)
                    {
                        chosenType = db.Types_GetByName("Panthothenic Acid");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, panthothenicAcid, unit_Miligram[0].Id, null));
                    }
                    if (calcium != 0)
                    {
                        chosenType = db.Types_GetByName("Calcium");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, calcium, unit_Miligram[0].Id, null));
                    }
                    if (iron != 0)
                    {
                        chosenType = db.Types_GetByName("Iron");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, iron, unit_Miligram[0].Id, null));
                    }
                    if (magnesium != 0)
                    {
                        chosenType = db.Types_GetByName("Magnesium");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, magnesium, unit_Miligram[0].Id, null));
                    }
                    if (phosphorus != 0)
                    {
                        chosenType = db.Types_GetByName("Phosphorus");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, phosphorus, unit_Miligram[0].Id, null));
                    }
                    if (potassium != 0)
                    {
                        chosenType = db.Types_GetByName("Potassium");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, potassium, unit_Miligram[0].Id, null));
                    }
                    if (sodium != 0)
                    {
                        chosenType = db.Types_GetByName("Sodium");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, sodium, unit_Miligram[0].Id, null));
                    }
                    if (zinc != 0)
                    {
                        chosenType = db.Types_GetByName("Zinc");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, zinc, unit_Miligram[0].Id, null));
                    }
                    if (copper != 0)
                    {
                        chosenType = db.Types_GetByName("Copper");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, copper, unit_Miligram[0].Id, null));
                    }
                    if (manganese != 0)
                    {
                        chosenType = db.Types_GetByName("Manganese");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, manganese, unit_Miligram[0].Id, null));
                    }
                    if (selenium != 0)
                    {
                        chosenType = db.Types_GetByName("Selenium");
                        Ingredients.Add(addIngredient(food.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, selenium, unit_Microgram[0].Id, null));
                    }

                    try
                    {
                        var result = db.InsertIngredientsForFood(Ingredients);
                        if (result) MessageBox.Show("Wohoo Food and ingredients added!!");
                    }
                    catch (Exception)
                    {
                        throw new Exception($"Adding ingredients for food {food.Name} failed");
                    }

                }

            }
            catch (Exception)
            {
                throw new Exception("Food could not be created");
            }


        }

        private IngredientModel addIngredient(int Food_Id, int Style_Id, int ServingSize_Id, int Type_Id, decimal Quantity, int Unit_Id, string Notes)
        {
            IngredientModel i = new IngredientModel();
            i.Food_id = Food_Id;
            i.Style_Id = Style_Id;
            i.ServingSize_Id = ServingSize_Id;
            i.Type_Id = Type_Id;
            i.Quantity = Quantity;
            i.Unit_Id = Unit_Id;
            i.Notes = Notes;

            return i;
        }


    }
}
