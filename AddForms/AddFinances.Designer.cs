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
            this.TransactionType = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.TransactionDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.TransactionType);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.TransactionDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 381);
            this.panel1.TabIndex = 22;
            // 
            // TransactionType
            // 
            this.TransactionType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransactionType.FormattingEnabled = true;
            this.TransactionType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.TransactionType.Location = new System.Drawing.Point(103, 84);
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.Size = new System.Drawing.Size(198, 29);
            this.TransactionType.TabIndex = 34;
            this.TransactionType.Text = "Тип транкзации";
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(103, 154);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(198, 29);
            this.Description.TabIndex = 20;
            this.Description.Text = "Описание";
            this.Description.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount.Location = new System.Drawing.Point(103, 119);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(198, 29);
            this.Amount.TabIndex = 19;
            this.Amount.Text = "Сумма";
            this.Amount.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // TransactionDate
            // 
            this.TransactionDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransactionDate.Location = new System.Drawing.Point(103, 49);
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.Size = new System.Drawing.Size(198, 29);
            this.TransactionDate.TabIndex = 16;
            this.TransactionDate.Text = "Дата операции";
            this.TransactionDate.DoubleClick += new System.EventHandler(this.ClearTextBox);
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
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.LimeGreen;
            this.Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(0, 378);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(384, 33);
            this.Save.TabIndex = 24;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddFinances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.Save);
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
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox TransactionDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox TransactionType;
        private System.Windows.Forms.TextBox Amount;
    }
}