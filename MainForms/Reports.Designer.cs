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
            this.reloadButton = new Guna.UI2.WinForms.Guna2Button();
            this.applyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.secondDate = new System.Windows.Forms.TextBox();
            this.firstDate = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.buttonParishes = new Guna.UI2.WinForms.Guna2Button();
            this.parishes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.buttonExpenses = new Guna.UI2.WinForms.Guna2Button();
            this.expenses = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.buttonBalance = new Guna.UI2.WinForms.Guna2Button();
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
            // reloadButton
            // 
            this.reloadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reloadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reloadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reloadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reloadButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.reloadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadButton.ForeColor = System.Drawing.Color.White;
            this.reloadButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadButton.Image")));
            this.reloadButton.Location = new System.Drawing.Point(386, 24);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(30, 26);
            this.reloadButton.TabIndex = 30;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // applyFilter
            // 
            this.applyFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.applyFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.applyFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.applyFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.applyFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.applyFilter.FillColor = System.Drawing.Color.LimeGreen;
            this.applyFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applyFilter.ForeColor = System.Drawing.Color.White;
            this.applyFilter.Image = ((System.Drawing.Image)(resources.GetObject("applyFilter.Image")));
            this.applyFilter.Location = new System.Drawing.Point(342, 24);
            this.applyFilter.Name = "applyFilter";
            this.applyFilter.Size = new System.Drawing.Size(30, 26);
            this.applyFilter.TabIndex = 29;
            this.applyFilter.Click += new System.EventHandler(this.applyFilter_Click);
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
            // secondDate
            // 
            this.secondDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondDate.Location = new System.Drawing.Point(187, 24);
            this.secondDate.Name = "secondDate";
            this.secondDate.Size = new System.Drawing.Size(136, 26);
            this.secondDate.TabIndex = 27;
            this.secondDate.Text = "Дата по";
            this.secondDate.DoubleClick += new System.EventHandler(this.secondDate_DoubleClick);
            // 
            // firstDate
            // 
            this.firstDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstDate.Location = new System.Drawing.Point(14, 24);
            this.firstDate.Name = "firstDate";
            this.firstDate.Size = new System.Drawing.Size(136, 26);
            this.firstDate.TabIndex = 26;
            this.firstDate.Text = "Дата с";
            this.firstDate.DoubleClick += new System.EventHandler(this.firstDate_DoubleClick);
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
            this.panel18.Controls.Add(this.buttonParishes);
            this.panel18.Controls.Add(this.parishes);
            this.panel18.Controls.Add(this.label4);
            this.panel18.Location = new System.Drawing.Point(338, 137);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(255, 97);
            this.panel18.TabIndex = 2;
            // 
            // buttonParishes
            // 
            this.buttonParishes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonParishes.BackgroundImage")));
            this.buttonParishes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonParishes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonParishes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonParishes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonParishes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonParishes.FillColor = System.Drawing.Color.Transparent;
            this.buttonParishes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonParishes.ForeColor = System.Drawing.Color.White;
            this.buttonParishes.Location = new System.Drawing.Point(218, 12);
            this.buttonParishes.Name = "buttonParishes";
            this.buttonParishes.Size = new System.Drawing.Size(25, 25);
            this.buttonParishes.TabIndex = 4;
            this.buttonParishes.Text = "guna2Button15";
            this.buttonParishes.Click += new System.EventHandler(this.buttonParishes_Click);
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
            this.panel17.Controls.Add(this.buttonExpenses);
            this.panel17.Controls.Add(this.expenses);
            this.panel17.Controls.Add(this.label5);
            this.panel17.Location = new System.Drawing.Point(16, 137);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(255, 97);
            this.panel17.TabIndex = 1;
            // 
            // buttonExpenses
            // 
            this.buttonExpenses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExpenses.BackgroundImage")));
            this.buttonExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExpenses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonExpenses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonExpenses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonExpenses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonExpenses.FillColor = System.Drawing.Color.Transparent;
            this.buttonExpenses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonExpenses.ForeColor = System.Drawing.Color.White;
            this.buttonExpenses.Location = new System.Drawing.Point(219, 12);
            this.buttonExpenses.Name = "buttonExpenses";
            this.buttonExpenses.Size = new System.Drawing.Size(25, 25);
            this.buttonExpenses.TabIndex = 5;
            this.buttonExpenses.Text = "guna2Button16";
            this.buttonExpenses.Click += new System.EventHandler(this.buttonExpenses_Click);
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
            this.panel15.Controls.Add(this.buttonBalance);
            this.panel15.Controls.Add(this.balanceMoney);
            this.panel15.Controls.Add(this.label2);
            this.panel15.Location = new System.Drawing.Point(187, 22);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(255, 97);
            this.panel15.TabIndex = 0;
            // 
            // buttonBalance
            // 
            this.buttonBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBalance.BackgroundImage")));
            this.buttonBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBalance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBalance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBalance.FillColor = System.Drawing.Color.Transparent;
            this.buttonBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBalance.ForeColor = System.Drawing.Color.White;
            this.buttonBalance.Location = new System.Drawing.Point(219, 8);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(25, 25);
            this.buttonBalance.TabIndex = 2;
            this.buttonBalance.Text = "guna2Button13";
            this.buttonBalance.Click += new System.EventHandler(this.buttonBalance_Click);
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
            this.panel1.Controls.Add(this.secondDate);
            this.panel1.Controls.Add(this.reloadButton);
            this.panel1.Controls.Add(this.firstDate);
            this.panel1.Controls.Add(this.applyFilter);
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

        private Guna.UI2.WinForms.Guna2Button reloadButton;
        private Guna.UI2.WinForms.Guna2Button applyFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox secondDate;
        private System.Windows.Forms.TextBox firstDate;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel18;
        private Guna.UI2.WinForms.Guna2Button buttonParishes;
        private System.Windows.Forms.Label parishes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel17;
        private Guna.UI2.WinForms.Guna2Button buttonExpenses;
        private System.Windows.Forms.Label expenses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel15;
        private Guna.UI2.WinForms.Guna2Button buttonBalance;
        private System.Windows.Forms.Label balanceMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}