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
    public partial class AddServingSizeForm : Form
    {
        private string servingSizeName = null;
        private decimal dataValue = 0;
        
        public AddServingSizeForm()
        {
            InitializeComponent();

            IDataConnection db = GlobalConfig.Connection;

            // Fill units combobox
            UnitsCombobox.DataSource = null;
            UnitsCombobox.DataSource = db.Units_GetAll();
            UnitsCombobox.DisplayMember = "Name";

            this.servingSizeTextbox.Enter += new System.EventHandler(this.servingSizeTextbox_Enter);
            this.servingSizeTextbox.Leave += new System.EventHandler(this.servingSizeTextbox_Leave);

            this.dataValueTextbox.Enter += new System.EventHandler(this.dataValueTextbox_Enter);
            this.dataValueTextbox.Leave += new System.EventHandler(this.dataValueTextbox_Leave);
        }

        private void servingSizeTextbox_Enter(object sender, EventArgs e)
        {
            servingSizeTextbox.Text = "";

        }
        private void servingSizeTextbox_Leave(object sender, EventArgs e)
        {
            if (servingSizeTextbox.Text.Length != 0) servingSizeName = servingSizeTextbox.Text;
        }

        private void dataValueTextbox_Enter(object sender, EventArgs e)
        {
            dataValueTextbox.Text = "";

        }
        private void dataValueTextbox_Leave(object sender, EventArgs e)
        {
            if (dataValueTextbox.Text.Length != 0) 
            {
                bool res = decimal.TryParse(dataValueTextbox.Text, out dataValue);
                if (!res) MessageBox.Show("Only numbers accepted in Numeric Value field!");
            }
        }

        private void addServingSizeButton_Click(object sender, EventArgs e)
        {
            if (servingSizeName != null && dataValue != 0)
            {
                ServingSizeModel model = new ServingSizeModel();
                UnitModel unitId = (UnitModel)UnitsCombobox.SelectedItem;

                model.Name = servingSizeName;
                model.DataValue = dataValue;
                model.UnitId = unitId.Id;

                IDataConnection db = GlobalConfig.Connection;
                ServingSizeModel result = db.ServingSizes_Insert(model);
                if (result.Id != 0)
                {
                    MessageBox.Show("Serving Size added successfully");
                    servingSizeName = null;
                    dataValue = 0;
                    unitId = null;
                }

            }
            else
            {
                MessageBox.Show("Please enter all the details");
            }
        }
    }
}
