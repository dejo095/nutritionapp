﻿namespace NutritionUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Name";
            // 
            // servingSizeTextbox
            // 
            this.servingSizeTextbox.Location = new System.Drawing.Point(12, 29);
            this.servingSizeTextbox.Name = "servingSizeTextbox";
            this.servingSizeTextbox.Size = new System.Drawing.Size(186, 25);
            this.servingSizeTextbox.TabIndex = 1;
            // 
            // dataValueTextbox
            // 
            this.dataValueTextbox.Location = new System.Drawing.Point(12, 77);
            this.dataValueTextbox.Name = "dataValueTextbox";
            this.dataValueTextbox.Size = new System.Drawing.Size(71, 25);
            this.dataValueTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numeric value";
            // 
            // UnitsCombobox
            // 
            this.UnitsCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitsCombobox.FormattingEnabled = true;
            this.UnitsCombobox.Location = new System.Drawing.Point(108, 77);
            this.UnitsCombobox.Name = "UnitsCombobox";
            this.UnitsCombobox.Size = new System.Drawing.Size(90, 25);
            this.UnitsCombobox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unit of measure";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddServingSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(214, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnitsCombobox);
            this.Controls.Add(this.dataValueTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.servingSizeTextbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddServingSizeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddServingSizeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox servingSizeTextbox;
        private System.Windows.Forms.TextBox dataValueTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UnitsCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}