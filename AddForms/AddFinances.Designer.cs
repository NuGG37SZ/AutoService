namespace AutoService.AddForms
{
    partial class AddFinances
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.TextBox();
            this.transactionDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.transactionType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.transactionType);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.transactionDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 381);
            this.panel1.TabIndex = 22;
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(103, 154);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(198, 29);
            this.description.TabIndex = 20;
            this.description.Text = "Описание";
            this.description.DoubleClick += new System.EventHandler(this.description_DoubleClick);
            // 
            // transactionDate
            // 
            this.transactionDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionDate.Location = new System.Drawing.Point(103, 49);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(198, 29);
            this.transactionDate.TabIndex = 16;
            this.transactionDate.Text = "Дата операции";
            this.transactionDate.DoubleClick += new System.EventHandler(this.transactionDate_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавление Операции";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LimeGreen;
            this.save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(0, 378);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(384, 33);
            this.save.TabIndex = 24;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount.Location = new System.Drawing.Point(103, 119);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(198, 29);
            this.amount.TabIndex = 19;
            this.amount.Text = "Сумма";
            this.amount.DoubleClick += new System.EventHandler(this.amount_DoubleClick);
            // 
            // transactionType
            // 
            this.transactionType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionType.FormattingEnabled = true;
            this.transactionType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.transactionType.Location = new System.Drawing.Point(103, 84);
            this.transactionType.Name = "transactionType";
            this.transactionType.Size = new System.Drawing.Size(198, 29);
            this.transactionType.TabIndex = 34;
            this.transactionType.Text = "Тип транкзации";
            // 
            // AddFinances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.save);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddFinances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox transactionDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox transactionType;
        private System.Windows.Forms.TextBox amount;
    }
}