namespace AutoService.AddForms
{
    partial class AddInventory
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
            this.Price = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.TextBox();
            this.Supplier = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.PartNumber = new System.Windows.Forms.TextBox();
            this.PartName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.Notes);
            this.panel1.Controls.Add(this.Supplier);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.PartNumber);
            this.panel1.Controls.Add(this.PartName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 380);
            this.panel1.TabIndex = 19;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(103, 119);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(198, 29);
            this.Price.TabIndex = 23;
            this.Price.Text = "Стоимость";
            this.Price.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // Notes
            // 
            this.Notes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Notes.Location = new System.Drawing.Point(103, 224);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(198, 29);
            this.Notes.TabIndex = 22;
            this.Notes.Text = "Примечание";
            this.Notes.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // Supplier
            // 
            this.Supplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Supplier.Location = new System.Drawing.Point(103, 189);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(198, 29);
            this.Supplier.TabIndex = 20;
            this.Supplier.Text = "Поставщик";
            this.Supplier.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quantity.Location = new System.Drawing.Point(103, 154);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(198, 29);
            this.Quantity.TabIndex = 19;
            this.Quantity.Text = "Количество";
            this.Quantity.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // PartNumber
            // 
            this.PartNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartNumber.Location = new System.Drawing.Point(103, 84);
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Size = new System.Drawing.Size(198, 29);
            this.PartNumber.TabIndex = 17;
            this.PartNumber.Text = "Номер ";
            this.PartNumber.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // PartName
            // 
            this.PartName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartName.Location = new System.Drawing.Point(103, 49);
            this.PartName.Name = "PartName";
            this.PartName.Size = new System.Drawing.Size(198, 29);
            this.PartName.TabIndex = 16;
            this.PartName.Text = "Наименование";
            this.PartName.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавление Запчасти";
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
            this.Save.TabIndex = 21;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.TextBox Supplier;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox PartNumber;
        private System.Windows.Forms.TextBox PartName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save;
    }
}