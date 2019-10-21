using System.Windows.Forms;

namespace NutritionUI
{
    partial class FoodEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.foodNameTextbox = new System.Windows.Forms.TextBox();
            this.foodStyleCombobox = new System.Windows.Forms.ComboBox();
            this.MainGroupbox = new System.Windows.Forms.GroupBox();
            this.aminoAcidScoreTextbox = new System.Windows.Forms.TextBox();
            this.completnessScoreTextbox = new System.Windows.Forms.TextBox();
            this.GITextbox = new System.Windows.Forms.TextBox();
            this.CaloriesGroupbox = new System.Windows.Forms.GroupBox();
            this.cholesterolTextbox = new System.Windows.Forms.TextBox();
            this.starchTextbox = new System.Windows.Forms.TextBox();
            this.sugarsTextbox = new System.Windows.Forms.TextBox();
            this.carbsTextbox = new System.Windows.Forms.TextBox();
            this.proteinsTextbox = new System.Windows.Forms.TextBox();
            this.caloriesTextbox = new System.Windows.Forms.TextBox();
            this.fibersGroupbox = new System.Windows.Forms.GroupBox();
            this.dietaryFiberTextbox = new System.Windows.Forms.TextBox();
            this.fiberTextbox = new System.Windows.Forms.TextBox();
            this.fatsGroupbox = new System.Windows.Forms.GroupBox();
            this.omega6FatTextbox = new System.Windows.Forms.TextBox();
            this.omega3FatTextbox = new System.Windows.Forms.TextBox();
            this.transFatTextbox = new System.Windows.Forms.TextBox();
            this.polyUnsaturatedFatTextbox = new System.Windows.Forms.TextBox();
            this.monoUnsaturatedFatTextbox = new System.Windows.Forms.TextBox();
            this.saturatedFatTextbox = new System.Windows.Forms.TextBox();
            this.totalFatTextbox = new System.Windows.Forms.TextBox();
            this.vitaminsGroupbox = new System.Windows.Forms.GroupBox();
            this.panthothenicAcidTextbox = new System.Windows.Forms.TextBox();
            this.folateTextbox = new System.Windows.Forms.TextBox();
            this.niacinTextbox = new System.Windows.Forms.TextBox();
            this.riboflavinTextbox = new System.Windows.Forms.TextBox();
            this.vitDTextbox = new System.Windows.Forms.TextBox();
            this.thiaminTextbox = new System.Windows.Forms.TextBox();
            this.vitKTextbox = new System.Windows.Forms.TextBox();
            this.vitETextbox = new System.Windows.Forms.TextBox();
            this.vitCTextbox = new System.Windows.Forms.TextBox();
            this.vitB12Textbox = new System.Windows.Forms.TextBox();
            this.vitB6Textbox = new System.Windows.Forms.TextBox();
            this.vitATextbox = new System.Windows.Forms.TextBox();
            this.mineralsGroupbox = new System.Windows.Forms.GroupBox();
            this.seleniumTextbox = new System.Windows.Forms.TextBox();
            this.manganeseTextbox = new System.Windows.Forms.TextBox();
            this.copperTextbox = new System.Windows.Forms.TextBox();
            this.phosphorusTextbox = new System.Windows.Forms.TextBox();
            this.zincTextbox = new System.Windows.Forms.TextBox();
            this.sodiumTextbox = new System.Windows.Forms.TextBox();
            this.potassiumTextbox = new System.Windows.Forms.TextBox();
            this.magnesiumTextbox = new System.Windows.Forms.TextBox();
            this.ironTextbox = new System.Windows.Forms.TextBox();
            this.calciumTextbox = new System.Windows.Forms.TextBox();
            this.foodNotesTextbox = new System.Windows.Forms.RichTextBox();
            this.addFoodButton = new System.Windows.Forms.Button();
            this.servingSizeCombobox = new System.Windows.Forms.ComboBox();
            this.NameGroupbox = new System.Windows.Forms.GroupBox();
            this.foodForm_panel = new System.Windows.Forms.Panel();
            this.numberOfFoodLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addServingSizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.MainGroupbox.SuspendLayout();
            this.CaloriesGroupbox.SuspendLayout();
            this.fibersGroupbox.SuspendLayout();
            this.fatsGroupbox.SuspendLayout();
            this.vitaminsGroupbox.SuspendLayout();
            this.mineralsGroupbox.SuspendLayout();
            this.NameGroupbox.SuspendLayout();
            this.foodForm_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodNameTextbox
            // 
            this.foodNameTextbox.Location = new System.Drawing.Point(6, 21);
            this.foodNameTextbox.Name = "foodNameTextbox";
            this.foodNameTextbox.Size = new System.Drawing.Size(211, 25);
            this.foodNameTextbox.TabIndex = 1;
            this.foodNameTextbox.Text = "Food name here";
            // 
            // foodStyleCombobox
            // 
            this.foodStyleCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodStyleCombobox.FormattingEnabled = true;
            this.foodStyleCombobox.Location = new System.Drawing.Point(6, 59);
            this.foodStyleCombobox.Name = "foodStyleCombobox";
            this.foodStyleCombobox.Size = new System.Drawing.Size(101, 25);
            this.foodStyleCombobox.TabIndex = 2;
            // 
            // MainGroupbox
            // 
            this.MainGroupbox.Controls.Add(this.aminoAcidScoreTextbox);
            this.MainGroupbox.Controls.Add(this.completnessScoreTextbox);
            this.MainGroupbox.Controls.Add(this.GITextbox);
            this.MainGroupbox.Location = new System.Drawing.Point(3, 98);
            this.MainGroupbox.Name = "MainGroupbox";
            this.MainGroupbox.Size = new System.Drawing.Size(195, 127);
            this.MainGroupbox.TabIndex = 2;
            this.MainGroupbox.TabStop = false;
            // 
            // aminoAcidScoreTextbox
            // 
            this.aminoAcidScoreTextbox.Location = new System.Drawing.Point(6, 86);
            this.aminoAcidScoreTextbox.Name = "aminoAcidScoreTextbox";
            this.aminoAcidScoreTextbox.Size = new System.Drawing.Size(183, 25);
            this.aminoAcidScoreTextbox.TabIndex = 7;
            this.aminoAcidScoreTextbox.Text = "Amino Acid Score";
            // 
            // completnessScoreTextbox
            // 
            this.completnessScoreTextbox.Location = new System.Drawing.Point(6, 55);
            this.completnessScoreTextbox.Name = "completnessScoreTextbox";
            this.completnessScoreTextbox.Size = new System.Drawing.Size(183, 25);
            this.completnessScoreTextbox.TabIndex = 6;
            this.completnessScoreTextbox.Text = "Completness Score";
            // 
            // GITextbox
            // 
            this.GITextbox.Location = new System.Drawing.Point(6, 24);
            this.GITextbox.Name = "GITextbox";
            this.GITextbox.Size = new System.Drawing.Size(183, 25);
            this.GITextbox.TabIndex = 5;
            this.GITextbox.Text = "Glycemic Index";
            // 
            // CaloriesGroupbox
            // 
            this.CaloriesGroupbox.Controls.Add(this.cholesterolTextbox);
            this.CaloriesGroupbox.Controls.Add(this.starchTextbox);
            this.CaloriesGroupbox.Controls.Add(this.sugarsTextbox);
            this.CaloriesGroupbox.Controls.Add(this.carbsTextbox);
            this.CaloriesGroupbox.Controls.Add(this.proteinsTextbox);
            this.CaloriesGroupbox.Controls.Add(this.caloriesTextbox);
            this.CaloriesGroupbox.Location = new System.Drawing.Point(3, 231);
            this.CaloriesGroupbox.Name = "CaloriesGroupbox";
            this.CaloriesGroupbox.Size = new System.Drawing.Size(195, 222);
            this.CaloriesGroupbox.TabIndex = 3;
            this.CaloriesGroupbox.TabStop = false;
            // 
            // cholesterolTextbox
            // 
            this.cholesterolTextbox.Location = new System.Drawing.Point(6, 179);
            this.cholesterolTextbox.Name = "cholesterolTextbox";
            this.cholesterolTextbox.Size = new System.Drawing.Size(183, 25);
            this.cholesterolTextbox.TabIndex = 13;
            this.cholesterolTextbox.Text = "Cholesterol (mg)";
            // 
            // starchTextbox
            // 
            this.starchTextbox.Location = new System.Drawing.Point(6, 148);
            this.starchTextbox.Name = "starchTextbox";
            this.starchTextbox.Size = new System.Drawing.Size(183, 25);
            this.starchTextbox.TabIndex = 12;
            this.starchTextbox.Text = "Starch (gr)";
            // 
            // sugarsTextbox
            // 
            this.sugarsTextbox.Location = new System.Drawing.Point(6, 117);
            this.sugarsTextbox.Name = "sugarsTextbox";
            this.sugarsTextbox.Size = new System.Drawing.Size(183, 25);
            this.sugarsTextbox.TabIndex = 11;
            this.sugarsTextbox.Text = "Sugars (gr)";
            // 
            // carbsTextbox
            // 
            this.carbsTextbox.Location = new System.Drawing.Point(6, 86);
            this.carbsTextbox.Name = "carbsTextbox";
            this.carbsTextbox.Size = new System.Drawing.Size(183, 25);
            this.carbsTextbox.TabIndex = 10;
            this.carbsTextbox.Text = "Carbs (gr)";
            // 
            // proteinsTextbox
            // 
            this.proteinsTextbox.Location = new System.Drawing.Point(6, 55);
            this.proteinsTextbox.Name = "proteinsTextbox";
            this.proteinsTextbox.Size = new System.Drawing.Size(183, 25);
            this.proteinsTextbox.TabIndex = 9;
            this.proteinsTextbox.Text = "Proteins (gr)";
            // 
            // caloriesTextbox
            // 
            this.caloriesTextbox.Location = new System.Drawing.Point(6, 24);
            this.caloriesTextbox.Name = "caloriesTextbox";
            this.caloriesTextbox.Size = new System.Drawing.Size(183, 25);
            this.caloriesTextbox.TabIndex = 8;
            this.caloriesTextbox.Text = "Calories";
            // 
            // fibersGroupbox
            // 
            this.fibersGroupbox.Controls.Add(this.dietaryFiberTextbox);
            this.fibersGroupbox.Controls.Add(this.fiberTextbox);
            this.fibersGroupbox.Location = new System.Drawing.Point(205, 103);
            this.fibersGroupbox.Name = "fibersGroupbox";
            this.fibersGroupbox.Size = new System.Drawing.Size(195, 98);
            this.fibersGroupbox.TabIndex = 4;
            this.fibersGroupbox.TabStop = false;
            this.fibersGroupbox.Text = "Fibre";
            // 
            // dietaryFiberTextbox
            // 
            this.dietaryFiberTextbox.Location = new System.Drawing.Point(6, 55);
            this.dietaryFiberTextbox.Name = "dietaryFiberTextbox";
            this.dietaryFiberTextbox.Size = new System.Drawing.Size(183, 25);
            this.dietaryFiberTextbox.TabIndex = 15;
            this.dietaryFiberTextbox.Text = "Dietary Fibers (gr)";
            // 
            // fiberTextbox
            // 
            this.fiberTextbox.Location = new System.Drawing.Point(6, 24);
            this.fiberTextbox.Name = "fiberTextbox";
            this.fiberTextbox.Size = new System.Drawing.Size(183, 25);
            this.fiberTextbox.TabIndex = 14;
            this.fiberTextbox.Text = "Fibers (gr)";
            // 
            // fatsGroupbox
            // 
            this.fatsGroupbox.Controls.Add(this.omega6FatTextbox);
            this.fatsGroupbox.Controls.Add(this.omega3FatTextbox);
            this.fatsGroupbox.Controls.Add(this.transFatTextbox);
            this.fatsGroupbox.Controls.Add(this.polyUnsaturatedFatTextbox);
            this.fatsGroupbox.Controls.Add(this.monoUnsaturatedFatTextbox);
            this.fatsGroupbox.Controls.Add(this.saturatedFatTextbox);
            this.fatsGroupbox.Controls.Add(this.totalFatTextbox);
            this.fatsGroupbox.Location = new System.Drawing.Point(205, 200);
            this.fatsGroupbox.Name = "fatsGroupbox";
            this.fatsGroupbox.Size = new System.Drawing.Size(195, 253);
            this.fatsGroupbox.TabIndex = 5;
            this.fatsGroupbox.TabStop = false;
            this.fatsGroupbox.Text = "Fats";
            // 
            // omega6FatTextbox
            // 
            this.omega6FatTextbox.Location = new System.Drawing.Point(6, 210);
            this.omega6FatTextbox.Name = "omega6FatTextbox";
            this.omega6FatTextbox.Size = new System.Drawing.Size(183, 25);
            this.omega6FatTextbox.TabIndex = 28;
            this.omega6FatTextbox.Text = "Omega 6 (mg)";
            // 
            // omega3FatTextbox
            // 
            this.omega3FatTextbox.Location = new System.Drawing.Point(6, 179);
            this.omega3FatTextbox.Name = "omega3FatTextbox";
            this.omega3FatTextbox.Size = new System.Drawing.Size(183, 25);
            this.omega3FatTextbox.TabIndex = 27;
            this.omega3FatTextbox.Text = "Omega 3 (mg)";
            // 
            // transFatTextbox
            // 
            this.transFatTextbox.Location = new System.Drawing.Point(6, 148);
            this.transFatTextbox.Name = "transFatTextbox";
            this.transFatTextbox.Size = new System.Drawing.Size(183, 25);
            this.transFatTextbox.TabIndex = 26;
            this.transFatTextbox.Text = "Trans (gr)";
            // 
            // polyUnsaturatedFatTextbox
            // 
            this.polyUnsaturatedFatTextbox.Location = new System.Drawing.Point(6, 117);
            this.polyUnsaturatedFatTextbox.Name = "polyUnsaturatedFatTextbox";
            this.polyUnsaturatedFatTextbox.Size = new System.Drawing.Size(183, 25);
            this.polyUnsaturatedFatTextbox.TabIndex = 25;
            this.polyUnsaturatedFatTextbox.Text = "Poly Unsaturated (gr)";
            // 
            // monoUnsaturatedFatTextbox
            // 
            this.monoUnsaturatedFatTextbox.Location = new System.Drawing.Point(6, 86);
            this.monoUnsaturatedFatTextbox.Name = "monoUnsaturatedFatTextbox";
            this.monoUnsaturatedFatTextbox.Size = new System.Drawing.Size(183, 25);
            this.monoUnsaturatedFatTextbox.TabIndex = 24;
            this.monoUnsaturatedFatTextbox.Text = "Mono Unsaturated (gr)";
            // 
            // saturatedFatTextbox
            // 
            this.saturatedFatTextbox.Location = new System.Drawing.Point(6, 55);
            this.saturatedFatTextbox.Name = "saturatedFatTextbox";
            this.saturatedFatTextbox.Size = new System.Drawing.Size(183, 25);
            this.saturatedFatTextbox.TabIndex = 23;
            this.saturatedFatTextbox.Text = "Saturated (gr)";
            // 
            // totalFatTextbox
            // 
            this.totalFatTextbox.Location = new System.Drawing.Point(6, 24);
            this.totalFatTextbox.Name = "totalFatTextbox";
            this.totalFatTextbox.Size = new System.Drawing.Size(183, 25);
            this.totalFatTextbox.TabIndex = 22;
            this.totalFatTextbox.Text = "Total Fat (gr)";
            // 
            // vitaminsGroupbox
            // 
            this.vitaminsGroupbox.Controls.Add(this.panthothenicAcidTextbox);
            this.vitaminsGroupbox.Controls.Add(this.folateTextbox);
            this.vitaminsGroupbox.Controls.Add(this.niacinTextbox);
            this.vitaminsGroupbox.Controls.Add(this.riboflavinTextbox);
            this.vitaminsGroupbox.Controls.Add(this.vitDTextbox);
            this.vitaminsGroupbox.Controls.Add(this.thiaminTextbox);
            this.vitaminsGroupbox.Controls.Add(this.vitKTextbox);
            this.vitaminsGroupbox.Controls.Add(this.vitETextbox);
            this.vitaminsGroupbox.Controls.Add(this.vitCTextbox);
            this.vitaminsGroupbox.Controls.Add(this.vitB12Textbox);
            this.vitaminsGroupbox.Controls.Add(this.vitB6Textbox);
            this.vitaminsGroupbox.Controls.Add(this.vitATextbox);
            this.vitaminsGroupbox.Location = new System.Drawing.Point(406, 103);
            this.vitaminsGroupbox.Name = "vitaminsGroupbox";
            this.vitaminsGroupbox.Size = new System.Drawing.Size(195, 378);
            this.vitaminsGroupbox.TabIndex = 6;
            this.vitaminsGroupbox.TabStop = false;
            this.vitaminsGroupbox.Text = "Vitamins";
            // 
            // panthothenicAcidTextbox
            // 
            this.panthothenicAcidTextbox.Location = new System.Drawing.Point(6, 334);
            this.panthothenicAcidTextbox.Name = "panthothenicAcidTextbox";
            this.panthothenicAcidTextbox.Size = new System.Drawing.Size(183, 25);
            this.panthothenicAcidTextbox.TabIndex = 41;
            this.panthothenicAcidTextbox.Text = "Panthothenic Acid (mg)";
            // 
            // folateTextbox
            // 
            this.folateTextbox.Location = new System.Drawing.Point(6, 303);
            this.folateTextbox.Name = "folateTextbox";
            this.folateTextbox.Size = new System.Drawing.Size(183, 25);
            this.folateTextbox.TabIndex = 40;
            this.folateTextbox.Text = "Folate (mcg)";
            // 
            // niacinTextbox
            // 
            this.niacinTextbox.Location = new System.Drawing.Point(6, 272);
            this.niacinTextbox.Name = "niacinTextbox";
            this.niacinTextbox.Size = new System.Drawing.Size(183, 25);
            this.niacinTextbox.TabIndex = 39;
            this.niacinTextbox.Text = "Niacin (mg)";
            // 
            // riboflavinTextbox
            // 
            this.riboflavinTextbox.Location = new System.Drawing.Point(6, 241);
            this.riboflavinTextbox.Name = "riboflavinTextbox";
            this.riboflavinTextbox.Size = new System.Drawing.Size(183, 25);
            this.riboflavinTextbox.TabIndex = 38;
            this.riboflavinTextbox.Text = "Riboflavin (mg)";
            // 
            // vitDTextbox
            // 
            this.vitDTextbox.Location = new System.Drawing.Point(6, 117);
            this.vitDTextbox.Name = "vitDTextbox";
            this.vitDTextbox.Size = new System.Drawing.Size(183, 25);
            this.vitDTextbox.TabIndex = 34;
            this.vitDTextbox.Text = "Vitamin D (mg)";
            // 
            // thiaminTextbox
            // 
            this.thiaminTextbox.Location = new System.Drawing.Point(6, 210);
            this.thiaminTextbox.Name = "thiaminTextbox";
            this.thiaminTextbox.Size = new System.Drawing.Size(183, 25);
            this.thiaminTextbox.TabIndex = 37;
            this.thiaminTextbox.Text = "Thiamin (mg)";
            // 
            // vitKTextbox
            // 
            this.vitKTextbox.Location = new System.Drawing.Point(6, 179);
            this.vitKTextbox.Name = "vitKTextbox";
            this.vitKTextbox.Size = new System.Drawing.Size(183, 25);
            this.vitKTextbox.TabIndex = 36;
            this.vitKTextbox.Text = "Vitamin K (mcg)";
            // 
            // vitETextbox
            // 
            this.vitETextbox.Location = new System.Drawing.Point(6, 148);
            this.vitETextbox.Name = "vitETextbox";
            this.vitETextbox.Size = new System.Drawing.Size(183, 25);
            this.vitETextbox.TabIndex = 35;
            this.vitETextbox.Text = "Vitamin E (mg)";
            // 
            // vitCTextbox
            // 
            this.vitCTextbox.Location = new System.Drawing.Point(6, 86);
            this.vitCTextbox.Name = "vitCTextbox";
            this.vitCTextbox.Size = new System.Drawing.Size(183, 25);
            this.vitCTextbox.TabIndex = 33;
            this.vitCTextbox.Text = "Vitamin C (mg)";
            // 
            // vitB12Textbox
            // 
            this.vitB12Textbox.Location = new System.Drawing.Point(101, 55);
            this.vitB12Textbox.Name = "vitB12Textbox";
            this.vitB12Textbox.Size = new System.Drawing.Size(88, 25);
            this.vitB12Textbox.TabIndex = 32;
            this.vitB12Textbox.Text = "Vitamin B12 (mcg)";
            // 
            // vitB6Textbox
            // 
            this.vitB6Textbox.Location = new System.Drawing.Point(6, 55);
            this.vitB6Textbox.Name = "vitB6Textbox";
            this.vitB6Textbox.Size = new System.Drawing.Size(88, 25);
            this.vitB6Textbox.TabIndex = 31;
            this.vitB6Textbox.Text = "Vitamin B6 (mg)";
            // 
            // vitATextbox
            // 
            this.vitATextbox.Location = new System.Drawing.Point(6, 24);
            this.vitATextbox.Name = "vitATextbox";
            this.vitATextbox.Size = new System.Drawing.Size(183, 25);
            this.vitATextbox.TabIndex = 30;
            this.vitATextbox.Text = "Vitamin A (IU)";
            // 
            // mineralsGroupbox
            // 
            this.mineralsGroupbox.Controls.Add(this.seleniumTextbox);
            this.mineralsGroupbox.Controls.Add(this.manganeseTextbox);
            this.mineralsGroupbox.Controls.Add(this.copperTextbox);
            this.mineralsGroupbox.Controls.Add(this.phosphorusTextbox);
            this.mineralsGroupbox.Controls.Add(this.zincTextbox);
            this.mineralsGroupbox.Controls.Add(this.sodiumTextbox);
            this.mineralsGroupbox.Controls.Add(this.potassiumTextbox);
            this.mineralsGroupbox.Controls.Add(this.magnesiumTextbox);
            this.mineralsGroupbox.Controls.Add(this.ironTextbox);
            this.mineralsGroupbox.Controls.Add(this.calciumTextbox);
            this.mineralsGroupbox.Location = new System.Drawing.Point(607, 103);
            this.mineralsGroupbox.Name = "mineralsGroupbox";
            this.mineralsGroupbox.Size = new System.Drawing.Size(195, 378);
            this.mineralsGroupbox.TabIndex = 7;
            this.mineralsGroupbox.TabStop = false;
            this.mineralsGroupbox.Text = "Minerals";
            // 
            // seleniumTextbox
            // 
            this.seleniumTextbox.Location = new System.Drawing.Point(6, 303);
            this.seleniumTextbox.Name = "seleniumTextbox";
            this.seleniumTextbox.Size = new System.Drawing.Size(183, 25);
            this.seleniumTextbox.TabIndex = 54;
            this.seleniumTextbox.Text = "Selenium (mcg)";
            // 
            // manganeseTextbox
            // 
            this.manganeseTextbox.Location = new System.Drawing.Point(6, 272);
            this.manganeseTextbox.Name = "manganeseTextbox";
            this.manganeseTextbox.Size = new System.Drawing.Size(183, 25);
            this.manganeseTextbox.TabIndex = 53;
            this.manganeseTextbox.Text = "Manganese (mg)";
            // 
            // copperTextbox
            // 
            this.copperTextbox.Location = new System.Drawing.Point(6, 241);
            this.copperTextbox.Name = "copperTextbox";
            this.copperTextbox.Size = new System.Drawing.Size(183, 25);
            this.copperTextbox.TabIndex = 52;
            this.copperTextbox.Text = "Copper (mg)";
            // 
            // phosphorusTextbox
            // 
            this.phosphorusTextbox.Location = new System.Drawing.Point(6, 117);
            this.phosphorusTextbox.Name = "phosphorusTextbox";
            this.phosphorusTextbox.Size = new System.Drawing.Size(183, 25);
            this.phosphorusTextbox.TabIndex = 48;
            this.phosphorusTextbox.Text = "Phosphorus (mg)";
            // 
            // zincTextbox
            // 
            this.zincTextbox.Location = new System.Drawing.Point(6, 210);
            this.zincTextbox.Name = "zincTextbox";
            this.zincTextbox.Size = new System.Drawing.Size(183, 25);
            this.zincTextbox.TabIndex = 51;
            this.zincTextbox.Text = "Zinc (mg)";
            // 
            // sodiumTextbox
            // 
            this.sodiumTextbox.Location = new System.Drawing.Point(6, 179);
            this.sodiumTextbox.Name = "sodiumTextbox";
            this.sodiumTextbox.Size = new System.Drawing.Size(183, 25);
            this.sodiumTextbox.TabIndex = 50;
            this.sodiumTextbox.Text = "Sodium (mg)";
            // 
            // potassiumTextbox
            // 
            this.potassiumTextbox.Location = new System.Drawing.Point(6, 148);
            this.potassiumTextbox.Name = "potassiumTextbox";
            this.potassiumTextbox.Size = new System.Drawing.Size(183, 25);
            this.potassiumTextbox.TabIndex = 49;
            this.potassiumTextbox.Text = "Potassium (mg)";
            // 
            // magnesiumTextbox
            // 
            this.magnesiumTextbox.Location = new System.Drawing.Point(6, 86);
            this.magnesiumTextbox.Name = "magnesiumTextbox";
            this.magnesiumTextbox.Size = new System.Drawing.Size(183, 25);
            this.magnesiumTextbox.TabIndex = 47;
            this.magnesiumTextbox.Text = "Magnesium (mg)";
            // 
            // ironTextbox
            // 
            this.ironTextbox.Location = new System.Drawing.Point(6, 55);
            this.ironTextbox.Name = "ironTextbox";
            this.ironTextbox.Size = new System.Drawing.Size(183, 25);
            this.ironTextbox.TabIndex = 46;
            this.ironTextbox.Text = "Iron (mg)";
            // 
            // calciumTextbox
            // 
            this.calciumTextbox.Location = new System.Drawing.Point(6, 24);
            this.calciumTextbox.Name = "calciumTextbox";
            this.calciumTextbox.Size = new System.Drawing.Size(183, 25);
            this.calciumTextbox.TabIndex = 45;
            this.calciumTextbox.Text = "Calcium (mg)";
            // 
            // foodNotesTextbox
            // 
            this.foodNotesTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodNotesTextbox.Location = new System.Drawing.Point(232, 21);
            this.foodNotesTextbox.Name = "foodNotesTextbox";
            this.foodNotesTextbox.Size = new System.Drawing.Size(468, 63);
            this.foodNotesTextbox.TabIndex = 4;
            this.foodNotesTextbox.Text = "Notes about food here";
            // 
            // addFoodButton
            // 
            this.addFoodButton.BackColor = System.Drawing.Color.PaleGreen;
            this.addFoodButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.addFoodButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.addFoodButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.addFoodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFoodButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodButton.Location = new System.Drawing.Point(716, 26);
            this.addFoodButton.Name = "addFoodButton";
            this.addFoodButton.Size = new System.Drawing.Size(86, 56);
            this.addFoodButton.TabIndex = 8;
            this.addFoodButton.Text = "ADD\r\nFOOD";
            this.addFoodButton.UseVisualStyleBackColor = false;
            this.addFoodButton.Click += new System.EventHandler(this.addFoodButton_Click);
            // 
            // servingSizeCombobox
            // 
            this.servingSizeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servingSizeCombobox.FormattingEnabled = true;
            this.servingSizeCombobox.Location = new System.Drawing.Point(116, 59);
            this.servingSizeCombobox.Name = "servingSizeCombobox";
            this.servingSizeCombobox.Size = new System.Drawing.Size(101, 25);
            this.servingSizeCombobox.TabIndex = 3;
            // 
            // NameGroupbox
            // 
            this.NameGroupbox.Controls.Add(this.foodNameTextbox);
            this.NameGroupbox.Controls.Add(this.servingSizeCombobox);
            this.NameGroupbox.Controls.Add(this.foodNotesTextbox);
            this.NameGroupbox.Controls.Add(this.foodStyleCombobox);
            this.NameGroupbox.Location = new System.Drawing.Point(3, 3);
            this.NameGroupbox.Name = "NameGroupbox";
            this.NameGroupbox.Size = new System.Drawing.Size(706, 94);
            this.NameGroupbox.TabIndex = 1;
            this.NameGroupbox.TabStop = false;
            // 
            // foodForm_panel
            // 
            this.foodForm_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.foodForm_panel.Controls.Add(this.numberOfFoodLabel);
            this.foodForm_panel.Controls.Add(this.CaloriesGroupbox);
            this.foodForm_panel.Controls.Add(this.addFoodButton);
            this.foodForm_panel.Controls.Add(this.NameGroupbox);
            this.foodForm_panel.Controls.Add(this.mineralsGroupbox);
            this.foodForm_panel.Controls.Add(this.MainGroupbox);
            this.foodForm_panel.Controls.Add(this.vitaminsGroupbox);
            this.foodForm_panel.Controls.Add(this.fibersGroupbox);
            this.foodForm_panel.Controls.Add(this.fatsGroupbox);
            this.foodForm_panel.Location = new System.Drawing.Point(12, 39);
            this.foodForm_panel.Name = "foodForm_panel";
            this.foodForm_panel.Size = new System.Drawing.Size(811, 489);
            this.foodForm_panel.TabIndex = 9;
            // 
            // numberOfFoodLabel
            // 
            this.numberOfFoodLabel.AutoSize = true;
            this.numberOfFoodLabel.Location = new System.Drawing.Point(6, 464);
            this.numberOfFoodLabel.Name = "numberOfFoodLabel";
            this.numberOfFoodLabel.Size = new System.Drawing.Size(85, 17);
            this.numberOfFoodLabel.TabIndex = 9;
            this.numberOfFoodLabel.Text = "# food in db:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addServingSizeMenuItem,
            this.addFoodStyleToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // addServingSizeMenuItem
            // 
            this.addServingSizeMenuItem.Name = "addServingSizeMenuItem";
            this.addServingSizeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addServingSizeMenuItem.Text = "Add Serving Size";
            this.addServingSizeMenuItem.Click += new System.EventHandler(this.addServingSizeMenuItem_Click);
            // 
            // addFoodStyleToolStripMenuItem
            // 
            this.addFoodStyleToolStripMenuItem.Name = "addFoodStyleToolStripMenuItem";
            this.addFoodStyleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addFoodStyleToolStripMenuItem.Text = "Add Food Style";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.copyrightLabel.Location = new System.Drawing.Point(679, 6);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(143, 13);
            this.copyrightLabel.TabIndex = 11;
            this.copyrightLabel.Text = "Created @10/2019 by Dejo";
            // 
            // FoodEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 539);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.foodForm_panel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FoodEntryForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Form";
            this.MainGroupbox.ResumeLayout(false);
            this.MainGroupbox.PerformLayout();
            this.CaloriesGroupbox.ResumeLayout(false);
            this.CaloriesGroupbox.PerformLayout();
            this.fibersGroupbox.ResumeLayout(false);
            this.fibersGroupbox.PerformLayout();
            this.fatsGroupbox.ResumeLayout(false);
            this.fatsGroupbox.PerformLayout();
            this.vitaminsGroupbox.ResumeLayout(false);
            this.vitaminsGroupbox.PerformLayout();
            this.mineralsGroupbox.ResumeLayout(false);
            this.mineralsGroupbox.PerformLayout();
            this.NameGroupbox.ResumeLayout(false);
            this.NameGroupbox.PerformLayout();
            this.foodForm_panel.ResumeLayout(false);
            this.foodForm_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox foodNameTextbox;
        private System.Windows.Forms.ComboBox foodStyleCombobox;
        private System.Windows.Forms.GroupBox MainGroupbox;
        private System.Windows.Forms.TextBox aminoAcidScoreTextbox;
        private System.Windows.Forms.TextBox completnessScoreTextbox;
        private System.Windows.Forms.TextBox GITextbox;
        private System.Windows.Forms.GroupBox CaloriesGroupbox;
        private System.Windows.Forms.TextBox cholesterolTextbox;
        private System.Windows.Forms.TextBox starchTextbox;
        private System.Windows.Forms.TextBox sugarsTextbox;
        private System.Windows.Forms.TextBox carbsTextbox;
        private System.Windows.Forms.TextBox proteinsTextbox;
        private System.Windows.Forms.TextBox caloriesTextbox;
        private System.Windows.Forms.GroupBox fibersGroupbox;
        private System.Windows.Forms.TextBox dietaryFiberTextbox;
        private System.Windows.Forms.TextBox fiberTextbox;
        private System.Windows.Forms.GroupBox fatsGroupbox;
        private System.Windows.Forms.TextBox omega3FatTextbox;
        private System.Windows.Forms.TextBox transFatTextbox;
        private System.Windows.Forms.TextBox polyUnsaturatedFatTextbox;
        private System.Windows.Forms.TextBox monoUnsaturatedFatTextbox;
        private System.Windows.Forms.TextBox saturatedFatTextbox;
        private System.Windows.Forms.TextBox totalFatTextbox;
        private System.Windows.Forms.TextBox omega6FatTextbox;
        private System.Windows.Forms.GroupBox vitaminsGroupbox;
        private System.Windows.Forms.TextBox panthothenicAcidTextbox;
        private System.Windows.Forms.TextBox folateTextbox;
        private System.Windows.Forms.TextBox niacinTextbox;
        private System.Windows.Forms.TextBox riboflavinTextbox;
        private System.Windows.Forms.TextBox vitDTextbox;
        private System.Windows.Forms.TextBox thiaminTextbox;
        private System.Windows.Forms.TextBox vitKTextbox;
        private System.Windows.Forms.TextBox vitETextbox;
        private System.Windows.Forms.TextBox vitCTextbox;
        private System.Windows.Forms.TextBox vitB12Textbox;
        private System.Windows.Forms.TextBox vitB6Textbox;
        private System.Windows.Forms.TextBox vitATextbox;
        private System.Windows.Forms.GroupBox mineralsGroupbox;
        private System.Windows.Forms.TextBox seleniumTextbox;
        private System.Windows.Forms.TextBox manganeseTextbox;
        private System.Windows.Forms.TextBox copperTextbox;
        private System.Windows.Forms.TextBox phosphorusTextbox;
        private System.Windows.Forms.TextBox zincTextbox;
        private System.Windows.Forms.TextBox sodiumTextbox;
        private System.Windows.Forms.TextBox potassiumTextbox;
        private System.Windows.Forms.TextBox magnesiumTextbox;
        private System.Windows.Forms.TextBox ironTextbox;
        private System.Windows.Forms.TextBox calciumTextbox;
        private System.Windows.Forms.RichTextBox foodNotesTextbox;
        private System.Windows.Forms.Button addFoodButton;
        private System.Windows.Forms.GroupBox NameGroupbox;
        private System.Windows.Forms.ComboBox servingSizeCombobox;
        private Panel foodForm_panel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem addServingSizeMenuItem;
        private ToolStripMenuItem addFoodStyleToolStripMenuItem;
        private Label copyrightLabel;
        private Label numberOfFoodLabel;
    }
}

