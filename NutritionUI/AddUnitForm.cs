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
    public partial class AddUnitForm : Form
    {
        private string unitName = null;
        private string unitDescription = null; // fix this in db, I set it up to varbinary by mistake

        public AddUnitForm()
        {
            InitializeComponent();
        }

        private void createUnitButton_Click(object sender, EventArgs e)
        {
            if (unitNameTextbox.Text.Length != 0 )
            {
                IDataConnection db = GlobalConfig.Connection;
                UnitModel unit = new UnitModel();

                unitName = unitNameTextbox.Text;
                unit.Name = unitName;

                if (unitDescriptionTextbox.Text.Length != 0) unitDescription = unitDescriptionTextbox.Text; // only if it has something then assign the value

                unit.Description = unitDescription;

                UnitModel res = db.Units_Insert(unit);
                if (res.Id != 0)
                {
                    MessageBox.Show("Unit added successfully");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter name of the Unit!");
            }
        }
    }
}
