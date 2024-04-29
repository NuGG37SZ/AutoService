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
            this.excelImport = new Guna.UI2.WinForms.Guna2Button();
            this.reloadValue = new Guna.UI2.WinForms.Guna2Button();
            this.deleteValue = new Guna.UI2.WinForms.Guna2Button();
            this.addValue = new Guna.UI2.WinForms.Guna2Button();
            this.reloadGrid = new Guna.UI2.WinForms.Guna2Button();
            this.search = new System.Windows.Forms.TextBox();
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
            this.panel15.Controls.Add(this.excelImport);
            this.panel15.Controls.Add(this.reloadValue);
            this.panel15.Controls.Add(this.deleteValue);
            this.panel15.Controls.Add(this.addValue);
            this.panel15.Controls.Add(this.reloadGrid);
            this.panel15.Controls.Add(this.search);
            this.panel15.Location = new System.Drawing.Point(0, 99);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(613, 77);
            this.panel15.TabIndex = 11;
            // 
            // excelImport
            // 
            this.excelImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.excelImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.excelImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.excelImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.excelImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.excelImport.FillColor = System.Drawing.Color.Green;
            this.excelImport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excelImport.ForeColor = System.Drawing.Color.White;
            this.excelImport.Image = ((System.Drawing.Image)(resources.GetObject("excelImport.Image")));
            this.excelImport.Location = new System.Drawing.Point(566, 24);
            this.excelImport.Name = "excelImport";
            this.excelImport.Size = new System.Drawing.Size(30, 26);
            this.excelImport.TabIndex = 12;
            this.excelImport.Click += new System.EventHandler(this.excelImport_Click);
            // 
            // reloadValue
            // 
            this.reloadValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reloadValue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reloadValue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reloadValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reloadValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reloadValue.FillColor = System.Drawing.Color.DodgerBlue;
            this.reloadValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadValue.ForeColor = System.Drawing.Color.White;
            this.reloadValue.Image = ((System.Drawing.Image)(resources.GetObject("reloadValue.Image")));
            this.reloadValue.Location = new System.Drawing.Point(530, 24);
            this.reloadValue.Name = "reloadValue";
            this.reloadValue.Size = new System.Drawing.Size(30, 26);
            this.reloadValue.TabIndex = 11;
            this.reloadValue.Click += new System.EventHandler(this.reloadValue_Click);
            // 
            // deleteValue
            // 
            this.deleteValue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteValue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteValue.FillColor = System.Drawing.Color.Brown;
            this.deleteValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteValue.ForeColor = System.Drawing.Color.White;
            this.deleteValue.Image = ((System.Drawing.Image)(resources.GetObject("deleteValue.Image")));
            this.deleteValue.Location = new System.Drawing.Point(494, 24);
            this.deleteValue.Name = "deleteValue";
            this.deleteValue.Size = new System.Drawing.Size(30, 26);
            this.deleteValue.TabIndex = 8;
            this.deleteValue.Click += new System.EventHandler(this.deleteValue_Click);
            // 
            // addValue
            // 
            this.addValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addValue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addValue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addValue.FillColor = System.Drawing.Color.ForestGreen;
            this.addValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addValue.ForeColor = System.Drawing.Color.White;
            this.addValue.Image = ((System.Drawing.Image)(resources.GetObject("addValue.Image")));
            this.addValue.Location = new System.Drawing.Point(458, 24);
            this.addValue.Name = "addValue";
            this.addValue.Size = new System.Drawing.Size(30, 26);
            this.addValue.TabIndex = 7;
            this.addValue.Click += new System.EventHandler(this.addValue_Click);
            // 
            // reloadGrid
            // 
            this.reloadGrid.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reloadGrid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reloadGrid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reloadGrid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reloadGrid.FillColor = System.Drawing.Color.RoyalBlue;
            this.reloadGrid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadGrid.ForeColor = System.Drawing.Color.White;
            this.reloadGrid.Image = ((System.Drawing.Image)(resources.GetObject("reloadGrid.Image")));
            this.reloadGrid.Location = new System.Drawing.Point(216, 24);
            this.reloadGrid.Name = "reloadGrid";
            this.reloadGrid.Size = new System.Drawing.Size(30, 26);
            this.reloadGrid.TabIndex = 6;
            this.reloadGrid.Click += new System.EventHandler(this.reloadGrid_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(20, 24);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(190, 26);
            this.search.TabIndex = 0;
            this.search.Text = "Поиск";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.DoubleClick += new System.EventHandler(this.search_DoubleClick);
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
        private Guna.UI2.WinForms.Guna2Button excelImport;
        private Guna.UI2.WinForms.Guna2Button reloadValue;
        private Guna.UI2.WinForms.Guna2Button deleteValue;
        private Guna.UI2.WinForms.Guna2Button addValue;
        private Guna.UI2.WinForms.Guna2Button reloadGrid;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
    }
}