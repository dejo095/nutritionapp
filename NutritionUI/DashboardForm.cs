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
        
        public DashboardForm()
        {
            InitializeComponent();

            dataGridView1.Visible = false;  // hiding the datagrid

        }

        private void findFoodButton_Click(object sender, EventArgs e)
        {

            if (findFoodTextbox.Text.Length != 0)
            {
                IDataConnection db = GlobalConfig.Connection;
                foods = db.Foods_FindAll(findFoodTextbox.Text);

                // datagrid
                //dataGridView1.AutoGenerateColumns = false;
                //dataGridView1.DataSource = foods;

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
                //var selectedItem = (FoodModel)foundFoodsListview.SelectedItems[0].Tag;
                //this.Hide();
                //FoodForm.Show();
    }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void addNewFoodButton_Click(object sender, EventArgs e)
        {
            FoodEntryForm FoodForm = new FoodEntryForm();
            FoodForm.ShowDialog(this);
        }

        private void addNewUnitButton_Click(object sender, EventArgs e)
        {
            AddUnitForm UnitForm = new AddUnitForm();
            UnitForm.ShowDialog(this);
        }

        private void addServingSizeButton_Click(object sender, EventArgs e)
        {
            AddServingSizeForm ServingSizeForm = new AddServingSizeForm();
            ServingSizeForm.ShowDialog(this);
        }

        private void addNewStyleButton_Click(object sender, EventArgs e)
        {
            AddStyleForm StyleForm = new AddStyleForm();
            StyleForm.ShowDialog(this);
        }
    }
}
