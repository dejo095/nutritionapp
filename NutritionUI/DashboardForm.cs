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
    public partial class DashboardForm : Form
    {
        private List<FoodModel> foods = new List<FoodModel>();
        private FoodEntryForm FoodForm = new FoodEntryForm();
        public DashboardForm()
        {
            InitializeComponent();


        }

        private void findFoodButton_Click(object sender, EventArgs e)
        {

            if (findFoodTextbox.Text.Length != 0)
            {
                IDataConnection db = GlobalConfig.Connection;
                foods = db.Foods_FindAll(findFoodTextbox.Text);

                // datagrid
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = foods;

                // listview
                foundFoodsListview.Items.Clear();
                foreach (var food in foods)
                {
                    var row = new string[]
                    {
                        food.Name,
                        food.Notes
                    };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = food;

                    foundFoodsListview.Items.Add(lvi);
                }
            }

        }

        private void foundFoodsListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (FoodModel)foundFoodsListview.SelectedItems[0].Tag;
                this.Hide();
                FoodForm.Show();
    }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
