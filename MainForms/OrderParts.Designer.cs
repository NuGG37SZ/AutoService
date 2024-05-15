namespace AutoService.MainForms
{
    partial class OrderParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderParts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel15 = new System.Windows.Forms.Panel();
            this.ExcelImport = new Guna.UI2.WinForms.Guna2Button();
            this.ReloadValue = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteValue = new Guna.UI2.WinForms.Guna2Button();
            this.AddValue = new Guna.UI2.WinForms.Guna2Button();
            this.ReloadGrid = new Guna.UI2.WinForms.Guna2Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 258);
            this.dataGridView1.TabIndex = 12;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel15.Controls.Add(this.ExcelImport);
            this.panel15.Controls.Add(this.ReloadValue);
            this.panel15.Controls.Add(this.DeleteValue);
            this.panel15.Controls.Add(this.AddValue);
            this.panel15.Controls.Add(this.ReloadGrid);
            this.panel15.Controls.Add(this.Search);
            this.panel15.Location = new System.Drawing.Point(0, 99);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(613, 77);
            this.panel15.TabIndex = 11;
            // 
            // ExcelImport
            // 
            this.ExcelImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExcelImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExcelImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExcelImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExcelImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExcelImport.FillColor = System.Drawing.Color.Green;
            this.ExcelImport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExcelImport.ForeColor = System.Drawing.Color.White;
            this.ExcelImport.Image = ((System.Drawing.Image)(resources.GetObject("ExcelImport.Image")));
            this.ExcelImport.Location = new System.Drawing.Point(566, 24);
            this.ExcelImport.Name = "ExcelImport";
            this.ExcelImport.Size = new System.Drawing.Size(30, 26);
            this.ExcelImport.TabIndex = 12;
            this.ExcelImport.Click += new System.EventHandler(this.ExcelImport_Click);
            // 
            // ReloadValue
            // 
            this.ReloadValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReloadValue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReloadValue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReloadValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReloadValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReloadValue.FillColor = System.Drawing.Color.DodgerBlue;
            this.ReloadValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadValue.ForeColor = System.Drawing.Color.White;
            this.ReloadValue.Image = ((System.Drawing.Image)(resources.GetObject("ReloadValue.Image")));
            this.ReloadValue.Location = new System.Drawing.Point(530, 24);
            this.ReloadValue.Name = "ReloadValue";
            this.ReloadValue.Size = new System.Drawing.Size(30, 26);
            this.ReloadValue.TabIndex = 11;
            this.ReloadValue.Click += new System.EventHandler(this.ReloadValue_Click);
            // 
            // DeleteValue
            // 
            this.DeleteValue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteValue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteValue.FillColor = System.Drawing.Color.Brown;
            this.DeleteValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteValue.ForeColor = System.Drawing.Color.White;
            this.DeleteValue.Image = ((System.Drawing.Image)(resources.GetObject("DeleteValue.Image")));
            this.DeleteValue.Location = new System.Drawing.Point(494, 24);
            this.DeleteValue.Name = "DeleteValue";
            this.DeleteValue.Size = new System.Drawing.Size(30, 26);
            this.DeleteValue.TabIndex = 8;
            this.DeleteValue.Click += new System.EventHandler(this.DeleteValue_Click);
            // 
            // AddValue
            // 
            this.AddValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddValue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddValue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddValue.FillColor = System.Drawing.Color.ForestGreen;
            this.AddValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddValue.ForeColor = System.Drawing.Color.White;
            this.AddValue.Image = ((System.Drawing.Image)(resources.GetObject("AddValue.Image")));
            this.AddValue.Location = new System.Drawing.Point(458, 24);
            this.AddValue.Name = "AddValue";
            this.AddValue.Size = new System.Drawing.Size(30, 26);
            this.AddValue.TabIndex = 7;
            this.AddValue.Click += new System.EventHandler(this.AddValue_Click);
            // 
            // ReloadGrid
            // 
            this.ReloadGrid.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReloadGrid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReloadGrid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReloadGrid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReloadGrid.FillColor = System.Drawing.Color.RoyalBlue;
            this.ReloadGrid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadGrid.ForeColor = System.Drawing.Color.White;
            this.ReloadGrid.Image = ((System.Drawing.Image)(resources.GetObject("ReloadGrid.Image")));
            this.ReloadGrid.Location = new System.Drawing.Point(216, 24);
            this.ReloadGrid.Name = "ReloadGrid";
            this.ReloadGrid.Size = new System.Drawing.Size(30, 26);
            this.ReloadGrid.TabIndex = 6;
            this.ReloadGrid.Click += new System.EventHandler(this.ReloadGrid_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(20, 24);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(190, 26);
            this.Search.TabIndex = 0;
            this.Search.Text = "Поиск";
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            this.Search.DoubleClick += new System.EventHandler(this.Search_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Запчасти в заказе";
            // 
            // OrderParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OrderParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrderParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel15;
        private Guna.UI2.WinForms.Guna2Button ExcelImport;
        private Guna.UI2.WinForms.Guna2Button ReloadValue;
        private Guna.UI2.WinForms.Guna2Button DeleteValue;
        private Guna.UI2.WinForms.Guna2Button AddValue;
        private Guna.UI2.WinForms.Guna2Button ReloadGrid;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
    }
}