namespace NutritionUI
{
    partial class AddUnitForm
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
            this.unitNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.createUnitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // unitNameTextbox
            // 
            this.unitNameTextbox.Location = new System.Drawing.Point(7, 57);
            this.unitNameTextbox.Name = "unitNameTextbox";
            this.unitNameTextbox.Size = new System.Drawing.Size(155, 25);
            this.unitNameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // unitDescriptionTextbox
            // 
            this.unitDescriptionTextbox.Location = new System.Drawing.Point(7, 112);
            this.unitDescriptionTextbox.Name = "unitDescriptionTextbox";
            this.unitDescriptionTextbox.Size = new System.Drawing.Size(152, 25);
            this.unitDescriptionTextbox.TabIndex = 2;
            // 
            // createUnitButton
            // 
            this.createUnitButton.Location = new System.Drawing.Point(69, 152);
            this.createUnitButton.Name = "createUnitButton";
            this.createUnitButton.Size = new System.Drawing.Size(90, 39);
            this.createUnitButton.TabIndex = 4;
            this.createUnitButton.Text = "Create";
            this.createUnitButton.UseVisualStyleBackColor = true;
            this.createUnitButton.Click += new System.EventHandler(this.createUnitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.createUnitButton);
            this.panel1.Controls.Add(this.unitNameTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.unitDescriptionTextbox);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 207);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Measure Unit";
            // 
            // AddUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(167, 202);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(183, 241);
            this.MinimumSize = new System.Drawing.Size(183, 241);
            this.Name = "AddUnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUnitForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox unitNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitDescriptionTextbox;
        private System.Windows.Forms.Button createUnitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}