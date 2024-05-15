namespace AutoService.MainForms
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.ReloadButton = new Guna.UI2.WinForms.Guna2Button();
            this.ApplyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SecondDate = new System.Windows.Forms.TextBox();
            this.FirstDate = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.ButtonParishes = new Guna.UI2.WinForms.Guna2Button();
            this.parishes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.ButtonExpenses = new Guna.UI2.WinForms.Guna2Button();
            this.expenses = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.ButtonBalance = new Guna.UI2.WinForms.Guna2Button();
            this.balanceMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel14.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReloadButton
            // 
            this.ReloadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReloadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReloadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReloadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReloadButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.ReloadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadButton.ForeColor = System.Drawing.Color.White;
            this.ReloadButton.Image = ((System.Drawing.Image)(resources.GetObject("ReloadButton.Image")));
            this.ReloadButton.Location = new System.Drawing.Point(386, 24);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(30, 26);
            this.ReloadButton.TabIndex = 30;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ApplyFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ApplyFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ApplyFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ApplyFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ApplyFilter.FillColor = System.Drawing.Color.LimeGreen;
            this.ApplyFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyFilter.ForeColor = System.Drawing.Color.White;
            this.ApplyFilter.Image = ((System.Drawing.Image)(resources.GetObject("ApplyFilter.Image")));
            this.ApplyFilter.Location = new System.Drawing.Point(342, 24);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(30, 26);
            this.ApplyFilter.TabIndex = 29;
            this.ApplyFilter.Click += new System.EventHandler(this.ApplyFilter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(156, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "-";
            // 
            // SecondDate
            // 
            this.SecondDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondDate.Location = new System.Drawing.Point(187, 24);
            this.SecondDate.Name = "SecondDate";
            this.SecondDate.Size = new System.Drawing.Size(136, 26);
            this.SecondDate.TabIndex = 27;
            this.SecondDate.Text = "Дата по";
            this.SecondDate.DoubleClick += new System.EventHandler(this.SecondDate_DoubleClick);
            // 
            // FirstDate
            // 
            this.FirstDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstDate.Location = new System.Drawing.Point(14, 24);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(136, 26);
            this.FirstDate.TabIndex = 26;
            this.FirstDate.Text = "Дата с";
            this.FirstDate.DoubleClick += new System.EventHandler(this.FirstDate_DoubleClick);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel14.Controls.Add(this.panel18);
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Location = new System.Drawing.Point(0, 176);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(625, 260);
            this.panel14.TabIndex = 25;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.Controls.Add(this.ButtonParishes);
            this.panel18.Controls.Add(this.parishes);
            this.panel18.Controls.Add(this.label4);
            this.panel18.Location = new System.Drawing.Point(338, 137);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(255, 97);
            this.panel18.TabIndex = 2;
            // 
            // ButtonParishes
            // 
            this.ButtonParishes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonParishes.BackgroundImage")));
            this.ButtonParishes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonParishes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonParishes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonParishes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonParishes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonParishes.FillColor = System.Drawing.Color.Transparent;
            this.ButtonParishes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonParishes.ForeColor = System.Drawing.Color.White;
            this.ButtonParishes.Location = new System.Drawing.Point(218, 12);
            this.ButtonParishes.Name = "ButtonParishes";
            this.ButtonParishes.Size = new System.Drawing.Size(25, 25);
            this.ButtonParishes.TabIndex = 4;
            this.ButtonParishes.Text = "guna2Button15";
            this.ButtonParishes.Click += new System.EventHandler(this.ButtonParishes_Click);
            // 
            // parishes
            // 
            this.parishes.AutoSize = true;
            this.parishes.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parishes.Location = new System.Drawing.Point(3, 34);
            this.parishes.Name = "parishes";
            this.parishes.Size = new System.Drawing.Size(65, 20);
            this.parishes.TabIndex = 4;
            this.parishes.Text = "Деньги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Приходы";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.Controls.Add(this.ButtonExpenses);
            this.panel17.Controls.Add(this.expenses);
            this.panel17.Controls.Add(this.label5);
            this.panel17.Location = new System.Drawing.Point(16, 137);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(255, 97);
            this.panel17.TabIndex = 1;
            // 
            // ButtonExpenses
            // 
            this.ButtonExpenses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonExpenses.BackgroundImage")));
            this.ButtonExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonExpenses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExpenses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExpenses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonExpenses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonExpenses.FillColor = System.Drawing.Color.Transparent;
            this.ButtonExpenses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonExpenses.ForeColor = System.Drawing.Color.White;
            this.ButtonExpenses.Location = new System.Drawing.Point(219, 12);
            this.ButtonExpenses.Name = "ButtonExpenses";
            this.ButtonExpenses.Size = new System.Drawing.Size(25, 25);
            this.ButtonExpenses.TabIndex = 5;
            this.ButtonExpenses.Text = "guna2Button16";
            this.ButtonExpenses.Click += new System.EventHandler(this.ButtonExpenses_Click);
            // 
            // expenses
            // 
            this.expenses.AutoSize = true;
            this.expenses.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expenses.Location = new System.Drawing.Point(6, 34);
            this.expenses.Name = "expenses";
            this.expenses.Size = new System.Drawing.Size(65, 20);
            this.expenses.TabIndex = 2;
            this.expenses.Text = "Деньги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Расходы";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Controls.Add(this.ButtonBalance);
            this.panel15.Controls.Add(this.balanceMoney);
            this.panel15.Controls.Add(this.label2);
            this.panel15.Location = new System.Drawing.Point(187, 22);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(255, 97);
            this.panel15.TabIndex = 0;
            // 
            // ButtonBalance
            // 
            this.ButtonBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonBalance.BackgroundImage")));
            this.ButtonBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonBalance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBalance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonBalance.FillColor = System.Drawing.Color.Transparent;
            this.ButtonBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonBalance.ForeColor = System.Drawing.Color.White;
            this.ButtonBalance.Location = new System.Drawing.Point(219, 8);
            this.ButtonBalance.Name = "ButtonBalance";
            this.ButtonBalance.Size = new System.Drawing.Size(25, 25);
            this.ButtonBalance.TabIndex = 2;
            this.ButtonBalance.Text = "guna2Button13";
            this.ButtonBalance.Click += new System.EventHandler(this.ButtonBalance_Click);
            // 
            // balanceMoney
            // 
            this.balanceMoney.AutoSize = true;
            this.balanceMoney.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceMoney.Location = new System.Drawing.Point(5, 29);
            this.balanceMoney.Name = "balanceMoney";
            this.balanceMoney.Size = new System.Drawing.Size(65, 20);
            this.balanceMoney.TabIndex = 1;
            this.balanceMoney.Text = "Деньги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Баланс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Отчет";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.SecondDate);
            this.panel1.Controls.Add(this.ReloadButton);
            this.panel1.Controls.Add(this.FirstDate);
            this.panel1.Controls.Add(this.ApplyFilter);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 77);
            this.panel1.TabIndex = 31;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel14.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ReloadButton;
        private Guna.UI2.WinForms.Guna2Button ApplyFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SecondDate;
        private System.Windows.Forms.TextBox FirstDate;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel18;
        private Guna.UI2.WinForms.Guna2Button ButtonParishes;
        private System.Windows.Forms.Label parishes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel17;
        private Guna.UI2.WinForms.Guna2Button ButtonExpenses;
        private System.Windows.Forms.Label expenses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel15;
        private Guna.UI2.WinForms.Guna2Button ButtonBalance;
        private System.Windows.Forms.Label balanceMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}