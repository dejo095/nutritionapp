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
        private string foodNotes = null;
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

        // modal forms
        private AddServingSizeForm ServingSizeForm = new AddServingSizeForm();
        private AddStyleForm StyleForm = new AddStyleForm();
        private AddUnitForm UnitForm = new AddUnitForm();

        public FoodEntryForm()
        {
            InitializeComponent();
            populateStylesCombobox();
            populateServingSizesCombobox();

            foodCountLabel.Text = Foods_GetCount();

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

            ServingSizeForm.FormClosed += OnServingSizeFormClosed;
            StyleForm.FormClosed += OnStyleFormClosed;
        }

        private void populateStylesCombobox()
        {
            foodStyleCombobox.DataSource = null;
            FoodStylesList = GlobalConfig.Connection.Styles_GetAll();
            foodStyleCombobox.DataSource = FoodStylesList;
            foodStyleCombobox.DisplayMember = "Name";
        }

        private void populateServingSizesCombobox()
        {
            servingSizeCombobox.DataSource = null;
            ServingSizeList = GlobalConfig.Connection.ServingSizes_GetAll();
            servingSizeCombobox.DataSource = ServingSizeList;
            servingSizeCombobox.DisplayMember = "Name";
        }

        private void foodNameTextbox_Enter(object sender, EventArgs e)
        {
            foodNameTextbox.HideSelection = false;
            foodNameTextbox.SelectAll();

        }
        private void foodNameTextbox_Leave(object sender, EventArgs e)
        {
            if (foodNameTextbox.Text.Length != 0)
            {
                foodName = foodNameTextbox.Text;
                foodNameTextbox.SelectionLength = 0;
            }
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
            if (!res) GITextbox.Text = StringValues.GI;
        }

        private void completnessScoreTextbox_Enter(object sender, EventArgs e)
        {
            completnessScoreTextbox.Text = "";
        }
        private void completnessScoreTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(completnessScoreTextbox.Text, out completnessScore);
            if (!res) completnessScoreTextbox.Text = StringValues.completnessScore;
        }

        private void aminoAcidScoreTextbox_Enter(object sender, EventArgs e)
        {
            aminoAcidScoreTextbox.Text = "";
        }
        private void aminoAcidScoreTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(aminoAcidScoreTextbox.Text, out aminoAcidScore);
            if (!res) aminoAcidScoreTextbox.Text = StringValues.aminoAcidScore;
        }

        private void caloriesTextbox_Enter(object sender, EventArgs e)
        {
            caloriesTextbox.HideSelection = false;
            caloriesTextbox.SelectAll();
        }
        private void caloriesTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(caloriesTextbox.Text, out calories);
            if (!res) caloriesTextbox.Text = StringValues.calories;
            caloriesTextbox.SelectionLength = 0;
        }

        private void proteinsTextbox_Enter(object sender, EventArgs e)
        {
            proteinsTextbox.HideSelection = false;
            proteinsTextbox.SelectAll();

        }
        private void proteinsTextbox_Leave(object sender, EventArgs e)
        {
            if (proteinsTextbox.Text.IndexOf(",") > 0)
                proteinsTextbox.Text = proteinsTextbox.Text.Replace(",", ".");
            
            bool check = decimal.TryParse(proteinsTextbox.Text, out proteins);

            if (!check)
                proteinsTextbox.Text = StringValues.proteins;

            proteinsTextbox.SelectionLength = 0;
        }

        private void carbsTextbox_Enter(object sender, EventArgs e)
        {
            carbsTextbox.Text = "";
        }
        private void carbsTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(carbsTextbox.Text, out carbs);
            if (!res) carbsTextbox.Text = StringValues.carbs;
        }

        private void sugarsTextbox_Enter(object sender, EventArgs e)
        {
            sugarsTextbox.Text = "";
        }
        private void sugarsTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(sugarsTextbox.Text, out sugars);
            if (!res) sugarsTextbox.Text = StringValues.sugars;
        }

        private void starchTextbox_Enter(object sender, EventArgs e)
        {
            starchTextbox.Text = "";
        }
        private void starchTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(starchTextbox.Text, out starch);
            if (!res) starchTextbox.Text = StringValues.starch;
        }

        private void cholesterolTextbox_Enter(object sender, EventArgs e)
        {
            cholesterolTextbox.Text = "";
        }
        private void cholesterolTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(cholesterolTextbox.Text, out cholesterol);
            if (!res) cholesterolTextbox.Text = StringValues.cholesterol;
        }

        private void fiberTextbox_Enter(object sender, EventArgs e)
        {
            fiberTextbox.Text = "";
        }
        private void fiberTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(fiberTextbox.Text, out fiber);
            if (!res) fiberTextbox.Text = StringValues.fibers;
        }

        private void dietaryFiberTextbox_Enter(object sender, EventArgs e)
        {
            dietaryFiberTextbox.Text = "";
        }
        private void dietaryFiberTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(dietaryFiberTextbox.Text, out dietaryFiber);
            if (!res) dietaryFiberTextbox.Text = StringValues.dietaryFibers;
        }

        private void totalFatTextbox_Enter(object sender, EventArgs e)
        {
            totalFatTextbox.Text = "";
        }
        private void totalFatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(totalFatTextbox.Text, out totalFat);
            if (!res) totalFatTextbox.Text = StringValues.totalFat;
        }

        private void saturatedFatTextbox_Enter(object sender, EventArgs e)
        {
            saturatedFatTextbox.Text = "";
        }
        private void saturatedFatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(saturatedFatTextbox.Text, out saturatedFat);
            if (!res) saturatedFatTextbox.Text = StringValues.saturatedFat;
        }

        private void monoUnsaturatedFatTextbox_Enter(object sender, EventArgs e)
        {
            monoUnsaturatedFatTextbox.Text = "";
        }
        private void monoUnsaturatedFatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(monoUnsaturatedFatTextbox.Text, out monoUnsaturatedFat);
            if (!res) monoUnsaturatedFatTextbox.Text = StringValues.monoUnsaturatedFat;
        }

        private void polyUnsaturatedFatTextbox_Enter(object sender, EventArgs e)
        {
            polyUnsaturatedFatTextbox.Text = "";
        }
        private void polyUnsaturatedFatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(polyUnsaturatedFatTextbox.Text, out polyUnsaturatedFat);
            if (!res) polyUnsaturatedFatTextbox.Text = StringValues.polyUnsaturatedFat;
        }

        private void transFatTextbox_Enter(object sender, EventArgs e)
        {
            transFatTextbox.Text = "";
        }
        private void transFatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(transFatTextbox.Text, out transFat);
            if (!res) transFatTextbox.Text = StringValues.transFat;
        }

        private void omega3FatTextbox_Enter(object sender, EventArgs e)
        {
            omega3FatTextbox.Text = "";
        }
        private void omega3FatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(omega3FatTextbox.Text, out omega3Fat);
            if (!res) omega3FatTextbox.Text = StringValues.omega3Fat;
        }

        private void omega6FatTextbox_Enter(object sender, EventArgs e)
        {
            omega6FatTextbox.Text = "";
        }
        private void omega6FatTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(omega6FatTextbox.Text, out omega6Fat);
            if (!res) omega6FatTextbox.Text = StringValues.omega6Fat;
        }

        private void vitATextbox_Enter(object sender, EventArgs e)
        {
            vitATextbox.Text = "";
        }
        private void vitATextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitATextbox.Text, out vitA);
            if (!res) vitATextbox.Text = StringValues.vitA;
        }

        private void vitB6Textbox_Enter(object sender, EventArgs e)
        {
            vitB6Textbox.Text = "";
        }
        private void vitB6Textbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitB6Textbox.Text, out vitB6);
            if (!res) vitB6Textbox.Text = StringValues.vitB6;
        }

        private void vitB12Textbox_Enter(object sender, EventArgs e)
        {
            vitB12Textbox.Text = "";
        }
        private void vitB12Textbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitB12Textbox.Text, out vitB12);
            if (!res) vitB12Textbox.Text = StringValues.vitB12;
        }

        private void vitCTextbox_Enter(object sender, EventArgs e)
        {
            vitCTextbox.Text = "";
        }
        private void vitCTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitCTextbox.Text, out vitC);
            if (!res) vitCTextbox.Text = StringValues.vitC;
        }

        private void vitDTextbox_Enter(object sender, EventArgs e)
        {
            vitDTextbox.Text = "";
        }
        private void vitDTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitDTextbox.Text, out vitD);
            if (!res) vitDTextbox.Text = StringValues.vitD;
        }

        private void vitETextbox_Enter(object sender, EventArgs e)
        {
            vitETextbox.Text = "";
        }
        private void vitETextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitETextbox.Text, out vitE);
            if (!res) vitETextbox.Text = StringValues.vitE;
        }

        private void vitKTextbox_Enter(object sender, EventArgs e)
        {
            vitKTextbox.Text = "";
        }
        private void vitKTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(vitKTextbox.Text, out vitK);
            if (!res) vitKTextbox.Text = StringValues.vitK;
        }

        private void thiaminTextbox_Enter(object sender, EventArgs e)
        {
            thiaminTextbox.Text = "";
        }
        private void thiaminTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(thiaminTextbox.Text, out thiamin);
            if (!res) thiaminTextbox.Text = StringValues.thiamin;
        }

        private void riboflavinTextbox_Enter(object sender, EventArgs e)
        {
            riboflavinTextbox.Text = "";
        }
        private void riboflavinTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(riboflavinTextbox.Text, out riboflavin);
            if (!res) riboflavinTextbox.Text = StringValues.riboflavin;
        }
        
        private void niacinTextbox_Enter(object sender, EventArgs e)
        {
            niacinTextbox.Text = "";
        }
        private void niacinTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(niacinTextbox.Text, out niacin);
            if (!res) niacinTextbox.Text = StringValues.niacin;
        }

        private void folateTextbox_Enter(object sender, EventArgs e)
        {
            folateTextbox.Text = "";
        }
        private void folateTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(folateTextbox.Text, out folate);
            if (!res) folateTextbox.Text = StringValues.folate;
        }

        private void panthothenicAcidTextbox_Enter(object sender, EventArgs e)
        {
            panthothenicAcidTextbox.Text = "";
        }
        private void panthothenicAcidTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(panthothenicAcidTextbox.Text, out panthothenicAcid);
            if (!res) panthothenicAcidTextbox.Text = StringValues.panthothenicAcid;
        }

        private void calciumTextbox_Enter(object sender, EventArgs e)
        {
            calciumTextbox.Text = "";
        }
        private void calciumTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(calciumTextbox.Text, out calcium);
            if (!res) calciumTextbox.Text = StringValues.calcium;
        }

        private void ironTextbox_Enter(object sender, EventArgs e)
        {
            ironTextbox.Text = "";
        }
        private void ironTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(ironTextbox.Text, out iron);
            if (!res) ironTextbox.Text = StringValues.iron;
        }

        private void magnesiumTextbox_Enter(object sender, EventArgs e)
        {
            magnesiumTextbox.Text = "";
        }
        private void magnesiumTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(magnesiumTextbox.Text, out magnesium);
            if (!res) magnesiumTextbox.Text = StringValues.magnesium;
        }

        private void phosphorusTextbox_Enter(object sender, EventArgs e)
        {
            phosphorusTextbox.Text = "";
        }
        private void phosphorusTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(phosphorusTextbox.Text, out phosphorus);
            if (!res) phosphorusTextbox.Text = StringValues.phosphorus;
        }

        private void potassiumTextbox_Enter(object sender, EventArgs e)
        {
            potassiumTextbox.Text = "";
        }
        private void potassiumTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(potassiumTextbox.Text, out potassium);
            if (!res) potassiumTextbox.Text = StringValues.potassium;
        }

        private void sodiumTextbox_Enter(object sender, EventArgs e)
        {
            sodiumTextbox.Text = "";
        }
        private void sodiumTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(sodiumTextbox.Text, out sodium);
            if (!res) sodiumTextbox.Text = StringValues.sodium;
        }

        private void zincTextbox_Enter(object sender, EventArgs e)
        {
            zincTextbox.Text = "";
        }
        private void zincTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(zincTextbox.Text, out zinc);
            if (!res) zincTextbox.Text = StringValues.zinc;
        }

        private void copperTextbox_Enter(object sender, EventArgs e)
        {
            copperTextbox.Text = "";
        }
        private void copperTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(copperTextbox.Text, out copper);
            if (!res) copperTextbox.Text = StringValues.copper;
        }

        private void manganeseTextbox_Enter(object sender, EventArgs e)
        {
            manganeseTextbox.Text = "";
        }
        private void manganeseTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(manganeseTextbox.Text, out manganese);
            if (!res) manganeseTextbox.Text = StringValues.manganese;
        }

        private void seleniumTextbox_Enter(object sender, EventArgs e)
        {
            seleniumTextbox.Text = "";
        }
        private void seleniumTextbox_Leave(object sender, EventArgs e)
        {
            bool res = decimal.TryParse(seleniumTextbox.Text, out selenium);
            if (!res) seleniumTextbox.Text = StringValues.selenium;
        }

        private void foodNotesTextbox_Enter(object sender, EventArgs e)
        {
            foodNotesTextbox.Text = "";
        }
        private void foodNotesTextbox_Leave(object sender, EventArgs e)
        {
            if (foodNotesTextbox.Text.Length != 0 || foodNotesTextbox.Text != StringValues.foodNotes) foodNotes = foodNotesTextbox.Text;
            else foodNotesTextbox.Text = StringValues.foodNotes;
        }

        private void OnServingSizeFormClosed(object sender, FormClosedEventArgs e)
        {
            ServingSizeForm = (AddServingSizeForm)sender; // we get data from ServingSizeForm when it closes /// dont need it at all
            populateServingSizesCombobox();
            servingSizeCombobox.SelectedIndex = servingSizeCombobox.Items.Count - 1;
            ServingSizeForm.FormClosed -= OnServingSizeFormClosed;
        }

        private void OnStyleFormClosed(object sender, FormClosedEventArgs e)
        {
            populateStylesCombobox();
            foodStyleCombobox.SelectedIndex = foodStyleCombobox.Items.Count - 1; // quick and dirty way to choose last one (added), after update on list
            StyleForm.FormClosed -= OnStyleFormClosed;
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
            FoodModel insertedFood;

            if (foodNameTextbox.Text.Length != 0 && foodNameTextbox.Text != StringValues.foodName) food.Name = foodNameTextbox.Text;
            if (foodNotesTextbox.Text.Length != 0 && foodNotesTextbox.Text != StringValues.foodNotes) food.Notes = foodNotesTextbox.Text;

            try
            {
                insertedFood = db.InsertFood(food);

                if (insertedFood.Id > 0)
                {
                    // Then lets create ingredients
                    if (GI != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.GI);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, GI, no_unit[0].Id, null));
                    }
                    if (completnessScore != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.completnessScore);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, completnessScore, no_unit[0].Id, null));
                    }
                    if (aminoAcidScore != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.aminoAcidScore);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, aminoAcidScore, no_unit[0].Id, null));
                    }
                    if (calories != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.calories);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, calories, no_unit[0].Id, null));
                    }
                    if (proteins != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.proteins);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, proteins, unit_Gram[0].Id, null));
                    }
                    if (carbs != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.carbs);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, carbs, unit_Gram[0].Id, null));
                    }
                    if (sugars != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.sugars);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, sugars, unit_Gram[0].Id, null));
                    }
                    if (starch != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.starch);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, starch, unit_Gram[0].Id, null));
                    }
                    if (cholesterol != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.cholesterol);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, cholesterol, unit_Miligram[0].Id, null));
                    }
                    if (fiber != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.fibers);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, fiber, unit_Gram[0].Id, null));
                    }
                    if (dietaryFiber != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.dietaryFibers);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, dietaryFiber, unit_Gram[0].Id, null));
                    }
                    if (totalFat != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.totalFat);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, totalFat, unit_Gram[0].Id, null));
                    }
                    if (saturatedFat != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.saturatedFat);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, saturatedFat, unit_Gram[0].Id, null));
                    }
                    if (monoUnsaturatedFat != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.monoUnsaturatedFat);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, monoUnsaturatedFat, unit_Gram[0].Id, null));
                    }
                    if (polyUnsaturatedFat != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.polyUnsaturatedFat);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, polyUnsaturatedFat, unit_Gram[0].Id, null));
                    }
                    if (transFat != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.transFat);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, transFat, unit_Gram[0].Id, null));
                    }
                    if (omega3Fat != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.omega3Fat);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, omega3Fat, unit_Miligram[0].Id, null));
                    }
                    if (omega6Fat != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.omega6Fat);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, omega6Fat, unit_Gram[0].Id, null));
                    }
                    if (vitA != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.vitA);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitA, unit_IU[0].Id, null));
                    }
                    if (vitB6 != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.vitB6);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitB6, unit_Miligram[0].Id, null));
                    }
                    if (vitB12 != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.vitB12);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitB12, unit_Microgram[0].Id, null));
                    }
                    if (vitC != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.vitC);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitC, unit_Miligram[0].Id, null));
                    }
                    if (vitD != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.vitD);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitD, unit_Miligram[0].Id, null));
                    }
                    if (vitE != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.vitE);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitE, unit_Miligram[0].Id, null));
                    }
                    if (vitK != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.vitK);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, vitK, unit_Microgram[0].Id, null));
                    }
                    if (thiamin != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.thiamin);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, thiamin, unit_Miligram[0].Id, null));
                    }
                    if (riboflavin != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.riboflavin);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, riboflavin, unit_Miligram[0].Id, null));
                    }
                    if (niacin != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.niacin);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, niacin, unit_Miligram[0].Id, null));
                    }
                    if (folate != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.folate);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, folate, unit_Microgram[0].Id, null));
                    }
                    if (panthothenicAcid != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.panthothenicAcid);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, panthothenicAcid, unit_Miligram[0].Id, null));
                    }
                    if (calcium != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.calcium);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, calcium, unit_Miligram[0].Id, null));
                    }
                    if (iron != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.iron);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, iron, unit_Miligram[0].Id, null));
                    }
                    if (magnesium != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.magnesium);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, magnesium, unit_Miligram[0].Id, null));
                    }
                    if (phosphorus != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.phosphorus);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, phosphorus, unit_Miligram[0].Id, null));
                    }
                    if (potassium != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.potassium);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, potassium, unit_Miligram[0].Id, null));
                    }
                    if (sodium != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.sodium);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, sodium, unit_Miligram[0].Id, null));
                    }
                    if (zinc != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.zinc);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, zinc, unit_Miligram[0].Id, null));
                    }
                    if (copper != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.copper);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, copper, unit_Miligram[0].Id, null));
                    }
                    if (manganese != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.manganese);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, manganese, unit_Miligram[0].Id, null));
                    }
                    if (selenium != 0)
                    {
                        chosenType = db.Types_GetByName(StringValues.selenium);
                        Ingredients.Add(addIngredient(insertedFood.Id, chosenStyle.Id, chosenServingSize.Id, chosenType[0].Id, selenium, unit_Microgram[0].Id, null));
                    }
                }
                try
                {
                    if (Ingredients.Count != 0)
                    {
                        var result = db.InsertIngredientsForFood(Ingredients);
                        if (result)
                        {
                            ClearTextboxes();
                            ResetAllVars();
                            foodCountLabel.Text = Foods_GetCount();
                            MessageBox.Show($"{insertedFood.Name} added!!", "Success!");
                        }
                    }
                    else
                    {
                        db.Foods_Remove(insertedFood);
                        MessageBox.Show("Cant add food without any ingredients!", "Error");
                    }
                }
                catch (Exception)
                {
                    db.Foods_Remove(insertedFood);
                    MessageBox.Show("Ingredients could not be added! Removing Food!", "Error");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Must have some data first to create food");
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

        private void ClearTextboxes()
        {
            foodNameTextbox.Text = StringValues.foodName;
            aminoAcidScoreTextbox.Text = StringValues.aminoAcidScore;
            completnessScoreTextbox.Text = StringValues.completnessScore;
            GITextbox.Text = StringValues.GI;
            cholesterolTextbox.Text = StringValues.cholesterol + "(mg)";
            starchTextbox.Text = StringValues.starch;
            sugarsTextbox.Text = StringValues.sugars;
            carbsTextbox.Text = StringValues.carbs;
            proteinsTextbox.Text = StringValues.proteins;
            caloriesTextbox.Text = StringValues.calories;
            dietaryFiberTextbox.Text = StringValues.dietaryFibers;
            fiberTextbox.Text = StringValues.fibers;
            omega3FatTextbox.Text = StringValues.omega3Fat;
            transFatTextbox.Text = StringValues.transFat;
            polyUnsaturatedFatTextbox.Text = StringValues.polyUnsaturatedFat;
            monoUnsaturatedFatTextbox.Text = StringValues.monoUnsaturatedFat;
            saturatedFatTextbox.Text = StringValues.saturatedFat;
            totalFatTextbox.Text = StringValues.totalFat;
            omega6FatTextbox.Text = StringValues.omega6Fat;
            panthothenicAcidTextbox.Text = StringValues.panthothenicAcid;
            folateTextbox.Text = StringValues.folate;
            niacinTextbox.Text = StringValues.niacin;
            riboflavinTextbox.Text = StringValues.riboflavin;
            vitDTextbox.Text = StringValues.vitD;
            thiaminTextbox.Text = StringValues.thiamin;
            vitKTextbox.Text = StringValues.vitK;
            vitETextbox.Text = StringValues.vitE;
            vitCTextbox.Text = StringValues.vitC;
            vitB12Textbox.Text = StringValues.vitB12;
            vitB6Textbox.Text = StringValues.vitB6;
            vitATextbox.Text = StringValues.vitA;
            seleniumTextbox.Text = StringValues.selenium;
            manganeseTextbox.Text = StringValues.manganese;
            copperTextbox.Text = StringValues.copper;
            phosphorusTextbox.Text = StringValues.phosphorus;
            zincTextbox.Text = StringValues.zinc;
            sodiumTextbox.Text = StringValues.sodium;
            potassiumTextbox.Text = StringValues.potassium;
            magnesiumTextbox.Text = StringValues.magnesium;
            ironTextbox.Text = StringValues.iron;
            calciumTextbox.Text = StringValues.calcium;
            foodNotesTextbox.Text = StringValues.foodNotes;
        }

        private void ResetAllVars()
        {
            foodName = null;
            foodNotes = null;
            GI = 0;
            completnessScore = 0;
            aminoAcidScore = 0;
            calories = 0;
            proteins = 0;
            carbs = 0;
            sugars = 0;
            starch = 0;
            cholesterol = 0;
            fiber = 0;
            dietaryFiber = 0;
            totalFat = 0;
            saturatedFat = 0;
            monoUnsaturatedFat = 0;
            polyUnsaturatedFat = 0;
            transFat = 0;
            omega3Fat = 0;
            omega6Fat = 0;
            vitA = 0;
            vitB6 = 0;
            vitB12 = 0;
            vitC = 0;
            vitD = 0;
            vitE = 0;
            vitK = 0;
            thiamin = 0;
            riboflavin = 0;
            niacin = 0;
            folate = 0;
            panthothenicAcid = 0;
            calcium = 0;
            iron = 0;
            magnesium = 0;
            phosphorus = 0;
            potassium = 0;
            sodium = 0;
            zinc = 0;
            copper = 0;
            manganese = 0;
            selenium = 0;
    }

        private string Foods_GetCount()
        {
            IDataConnection db = GlobalConfig.Connection;
            return "No of foods in db: " + db.Foods_GetSum().ToString();
        }

        private void addServingSizeMenuItem_Click(object sender, EventArgs e)
        {
            
            ServingSizeForm.ShowDialog(this);
        }

        private void addFoodStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StyleForm.ShowDialog(this);
        }

        private void addNewUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitForm.ShowDialog(this);
        }

        private void backToDashboardFormButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            DashboardForm frm = new DashboardForm();
            frm.Show();
        }
    }
}
