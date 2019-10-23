namespace NutritionUI
{
    partial class DashboardForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.findFoodTextbox = new System.Windows.Forms.TextBox();
            this.findFoodButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPanel = new System.Windows.Forms.Panel();
            this.foundFoodsListview = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New Food";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add New Unit of measure";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add New Serving Size";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add New Food Style";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nutrition App";
            // 
            // findFoodTextbox
            // 
            this.findFoodTextbox.Location = new System.Drawing.Point(30, 385);
            this.findFoodTextbox.Name = "findFoodTextbox";
            this.findFoodTextbox.Size = new System.Drawing.Size(209, 25);
            this.findFoodTextbox.TabIndex = 7;
            // 
            // findFoodButton
            // 
            this.findFoodButton.Location = new System.Drawing.Point(164, 416);
            this.findFoodButton.Name = "findFoodButton";
            this.findFoodButton.Size = new System.Drawing.Size(75, 28);
            this.findFoodButton.TabIndex = 8;
            this.findFoodButton.Text = "Search";
            this.findFoodButton.UseVisualStyleBackColor = true;
            this.findFoodButton.Click += new System.EventHandler(this.findFoodButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Find food";
            // 
            // dataGridPanel
            // 
            this.dataGridPanel.Controls.Add(this.foundFoodsListview);
            this.dataGridPanel.Controls.Add(this.dataGridView1);
            this.dataGridPanel.Location = new System.Drawing.Point(259, 21);
            this.dataGridPanel.Name = "dataGridPanel";
            this.dataGridPanel.Size = new System.Drawing.Size(336, 427);
            this.dataGridPanel.TabIndex = 10;
            // 
            // foundFoodsListview
            // 
            this.foundFoodsListview.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.foundFoodsListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.foundFoodsListview.HideSelection = false;
            this.foundFoodsListview.Location = new System.Drawing.Point(12, 102);
            this.foundFoodsListview.MultiSelect = false;
            this.foundFoodsListview.Name = "foundFoodsListview";
            this.foundFoodsListview.Size = new System.Drawing.Size(167, 302);
            this.foundFoodsListview.TabIndex = 1;
            this.foundFoodsListview.UseCompatibleStateImageBehavior = false;
            this.foundFoodsListview.SelectedIndexChanged += new System.EventHandler(this.foundFoodsListview_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 93);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Food Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 460);
            this.Controls.Add(this.dataGridPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findFoodButton);
            this.Controls.Add(this.findFoodTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Nutrition App";
            this.dataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox findFoodTextbox;
        private System.Windows.Forms.Button findFoodButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel dataGridPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.ListView foundFoodsListview;
    }
}