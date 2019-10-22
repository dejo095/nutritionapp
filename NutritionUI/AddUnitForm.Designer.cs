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
            this.SuspendLayout();
            // 
            // unitNameTextbox
            // 
            this.unitNameTextbox.Location = new System.Drawing.Point(22, 32);
            this.unitNameTextbox.Name = "unitNameTextbox";
            this.unitNameTextbox.Size = new System.Drawing.Size(155, 25);
            this.unitNameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // unitDescriptionTextbox
            // 
            this.unitDescriptionTextbox.Location = new System.Drawing.Point(25, 86);
            this.unitDescriptionTextbox.Name = "unitDescriptionTextbox";
            this.unitDescriptionTextbox.Size = new System.Drawing.Size(152, 25);
            this.unitDescriptionTextbox.TabIndex = 2;
            // 
            // createUnitButton
            // 
            this.createUnitButton.Location = new System.Drawing.Point(87, 131);
            this.createUnitButton.Name = "createUnitButton";
            this.createUnitButton.Size = new System.Drawing.Size(90, 39);
            this.createUnitButton.TabIndex = 4;
            this.createUnitButton.Text = "Create";
            this.createUnitButton.UseVisualStyleBackColor = true;
            this.createUnitButton.Click += new System.EventHandler(this.createUnitButton_Click);
            // 
            // AddUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(200, 188);
            this.Controls.Add(this.createUnitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unitDescriptionTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unitNameTextbox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddUnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUnitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unitNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitDescriptionTextbox;
        private System.Windows.Forms.Button createUnitButton;
    }
}