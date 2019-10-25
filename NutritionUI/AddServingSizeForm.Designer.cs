namespace NutritionUI
{
    partial class AddServingSizeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.servingSizeTextbox = new System.Windows.Forms.TextBox();
            this.dataValueTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnitsCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addServingSizeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Name";
            // 
            // servingSizeTextbox
            // 
            this.servingSizeTextbox.Location = new System.Drawing.Point(10, 62);
            this.servingSizeTextbox.Name = "servingSizeTextbox";
            this.servingSizeTextbox.Size = new System.Drawing.Size(186, 25);
            this.servingSizeTextbox.TabIndex = 1;
            // 
            // dataValueTextbox
            // 
            this.dataValueTextbox.Location = new System.Drawing.Point(10, 110);
            this.dataValueTextbox.Name = "dataValueTextbox";
            this.dataValueTextbox.Size = new System.Drawing.Size(86, 25);
            this.dataValueTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num value";
            // 
            // UnitsCombobox
            // 
            this.UnitsCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitsCombobox.FormattingEnabled = true;
            this.UnitsCombobox.Location = new System.Drawing.Point(106, 110);
            this.UnitsCombobox.Name = "UnitsCombobox";
            this.UnitsCombobox.Size = new System.Drawing.Size(90, 25);
            this.UnitsCombobox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Measure unit";
            // 
            // addServingSizeButton
            // 
            this.addServingSizeButton.Location = new System.Drawing.Point(106, 147);
            this.addServingSizeButton.Name = "addServingSizeButton";
            this.addServingSizeButton.Size = new System.Drawing.Size(90, 39);
            this.addServingSizeButton.TabIndex = 4;
            this.addServingSizeButton.Text = "Create";
            this.addServingSizeButton.UseVisualStyleBackColor = true;
            this.addServingSizeButton.Click += new System.EventHandler(this.addServingSizeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addServingSizeButton);
            this.panel1.Controls.Add(this.servingSizeTextbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UnitsCombobox);
            this.panel1.Controls.Add(this.dataValueTextbox);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 203);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add New Serving Size";
            // 
            // AddServingSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(207, 192);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(223, 231);
            this.MinimumSize = new System.Drawing.Size(223, 231);
            this.Name = "AddServingSizeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddServingSizeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox servingSizeTextbox;
        private System.Windows.Forms.TextBox dataValueTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UnitsCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addServingSizeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}