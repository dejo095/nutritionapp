﻿namespace NutritionUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.label2 = new System.Windows.Forms.Label();
            this.findFoodTextbox = new System.Windows.Forms.TextBox();
            this.findFoodButton = new System.Windows.Forms.Button();
            this.dataGridPanel = new System.Windows.Forms.Panel();
            this.foundFoodsListview = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dashboardToolstrip = new System.Windows.Forms.ToolStrip();
            this.addNewFoodButton = new System.Windows.Forms.ToolStripButton();
            this.addNewUnitButton = new System.Windows.Forms.ToolStripButton();
            this.addServingSizeButton = new System.Windows.Forms.ToolStripButton();
            this.addNewStyleButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dashboardToolstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nutrition App";
            // 
            // findFoodTextbox
            // 
            this.findFoodTextbox.Location = new System.Drawing.Point(12, 55);
            this.findFoodTextbox.Name = "findFoodTextbox";
            this.findFoodTextbox.Size = new System.Drawing.Size(366, 25);
            this.findFoodTextbox.TabIndex = 7;
            // 
            // findFoodButton
            // 
            this.findFoodButton.Location = new System.Drawing.Point(389, 53);
            this.findFoodButton.Name = "findFoodButton";
            this.findFoodButton.Size = new System.Drawing.Size(75, 28);
            this.findFoodButton.TabIndex = 8;
            this.findFoodButton.Text = "Search";
            this.findFoodButton.UseVisualStyleBackColor = true;
            this.findFoodButton.Click += new System.EventHandler(this.findFoodButton_Click);
            // 
            // dataGridPanel
            // 
            this.dataGridPanel.Controls.Add(this.foundFoodsListview);
            this.dataGridPanel.Controls.Add(this.dataGridView1);
            this.dataGridPanel.Location = new System.Drawing.Point(12, 86);
            this.dataGridPanel.Name = "dataGridPanel";
            this.dataGridPanel.Size = new System.Drawing.Size(450, 437);
            this.dataGridPanel.TabIndex = 10;
            // 
            // foundFoodsListview
            // 
            this.foundFoodsListview.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.foundFoodsListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.foundFoodsListview.HideSelection = false;
            this.foundFoodsListview.Location = new System.Drawing.Point(3, 68);
            this.foundFoodsListview.MultiSelect = false;
            this.foundFoodsListview.Name = "foundFoodsListview";
            this.foundFoodsListview.Size = new System.Drawing.Size(167, 104);
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
            this.dataGridView1.Size = new System.Drawing.Size(330, 59);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Food Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // dashboardToolstrip
            // 
            this.dashboardToolstrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.dashboardToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFoodButton,
            this.addNewUnitButton,
            this.addServingSizeButton,
            this.addNewStyleButton});
            this.dashboardToolstrip.Location = new System.Drawing.Point(0, 0);
            this.dashboardToolstrip.Name = "dashboardToolstrip";
            this.dashboardToolstrip.Size = new System.Drawing.Size(474, 39);
            this.dashboardToolstrip.TabIndex = 11;
            this.dashboardToolstrip.Text = "toolStrip1";
            // 
            // addNewFoodButton
            // 
            this.addNewFoodButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewFoodButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewFoodButton.Image")));
            this.addNewFoodButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNewFoodButton.Name = "addNewFoodButton";
            this.addNewFoodButton.Size = new System.Drawing.Size(36, 36);
            this.addNewFoodButton.Text = "Add New Food";
            this.addNewFoodButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addNewFoodButton.Click += new System.EventHandler(this.addNewFoodButton_Click);
            // 
            // addNewUnitButton
            // 
            this.addNewUnitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewUnitButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewUnitButton.Image")));
            this.addNewUnitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNewUnitButton.Name = "addNewUnitButton";
            this.addNewUnitButton.Size = new System.Drawing.Size(36, 36);
            this.addNewUnitButton.Text = "Add New Unit";
            this.addNewUnitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addNewUnitButton.Click += new System.EventHandler(this.addNewUnitButton_Click);
            // 
            // addServingSizeButton
            // 
            this.addServingSizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addServingSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("addServingSizeButton.Image")));
            this.addServingSizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addServingSizeButton.Name = "addServingSizeButton";
            this.addServingSizeButton.Size = new System.Drawing.Size(36, 36);
            this.addServingSizeButton.Text = "Add New Serving Size";
            this.addServingSizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addServingSizeButton.Click += new System.EventHandler(this.addServingSizeButton_Click);
            // 
            // addNewStyleButton
            // 
            this.addNewStyleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewStyleButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewStyleButton.Image")));
            this.addNewStyleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNewStyleButton.Name = "addNewStyleButton";
            this.addNewStyleButton.Size = new System.Drawing.Size(36, 36);
            this.addNewStyleButton.Text = "Add New Food Style";
            this.addNewStyleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addNewStyleButton.Click += new System.EventHandler(this.addNewStyleButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dashboardToolstrip);
            this.Controls.Add(this.dataGridPanel);
            this.Controls.Add(this.findFoodButton);
            this.Controls.Add(this.findFoodTextbox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Nutrition App";
            this.dataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dashboardToolstrip.ResumeLayout(false);
            this.dashboardToolstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox findFoodTextbox;
        private System.Windows.Forms.Button findFoodButton;
        private System.Windows.Forms.Panel dataGridPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.ListView foundFoodsListview;
        private System.Windows.Forms.ToolStrip dashboardToolstrip;
        private System.Windows.Forms.ToolStripButton addNewFoodButton;
        private System.Windows.Forms.ToolStripButton addNewUnitButton;
        private System.Windows.Forms.ToolStripButton addServingSizeButton;
        private System.Windows.Forms.ToolStripButton addNewStyleButton;
    }
}