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
    public partial class AddStyleForm : Form
    {
        private string styleName = null;

        public AddStyleForm()
        {
            InitializeComponent();

        }

        private void addStyleButton_Click(object sender, EventArgs e)
        {
            if (styleNameTextbox.Text.Length != 0)
            {
                styleName = styleNameTextbox.Text;

                IDataConnection db = GlobalConfig.Connection;

                StyleModel style = new StyleModel();
                style.Name = styleName;

                StyleModel res = db.Styles_Insert(style);
                if (res.Id != 0)
                {
                    MessageBox.Show("Style added successfully");
                    styleName = null;
                }
            }
            else
            {
                MessageBox.Show("Please enter name of the style!");
            }
        }
    }
}
