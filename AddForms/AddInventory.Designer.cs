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
            this.price = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.TextBox();
            this.supplier = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.partNumber = new System.Windows.Forms.TextBox();
            this.partName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.note);
            this.panel1.Controls.Add(this.supplier);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.partNumber);
            this.panel1.Controls.Add(this.partName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 380);
            this.panel1.TabIndex = 19;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(103, 119);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(198, 29);
            this.price.TabIndex = 23;
            this.price.Text = "Стоимость";
            this.price.DoubleClick += new System.EventHandler(this.price_DoubleClick);
            // 
            // note
            // 
            this.note.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.note.Location = new System.Drawing.Point(103, 224);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(198, 29);
            this.note.TabIndex = 22;
            this.note.Text = "Примечание";
            this.note.DoubleClick += new System.EventHandler(this.note_DoubleClick);
            // 
            // supplier
            // 
            this.supplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplier.Location = new System.Drawing.Point(103, 189);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(198, 29);
            this.supplier.TabIndex = 20;
            this.supplier.Text = "Поставщик";
            this.supplier.DoubleClick += new System.EventHandler(this.supplier_DoubleClick);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantity.Location = new System.Drawing.Point(103, 154);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(198, 29);
            this.quantity.TabIndex = 19;
            this.quantity.Text = "Количество";
            this.quantity.DoubleClick += new System.EventHandler(this.quantity_DoubleClick);
            // 
            // partNumber
            // 
            this.partNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partNumber.Location = new System.Drawing.Point(103, 84);
            this.partNumber.Name = "partNumber";
            this.partNumber.Size = new System.Drawing.Size(198, 29);
            this.partNumber.TabIndex = 17;
            this.partNumber.Text = "Номер ";
            this.partNumber.DoubleClick += new System.EventHandler(this.partNumber_DoubleClick);
            // 
            // partName
            // 
            this.partName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partName.Location = new System.Drawing.Point(103, 49);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(198, 29);
            this.partName.TabIndex = 16;
            this.partName.Text = "Наименование";
            this.partName.DoubleClick += new System.EventHandler(this.partName_DoubleClick);
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
            this.save.TabIndex = 21;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.save);
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
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.TextBox supplier;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox partNumber;
        private System.Windows.Forms.TextBox partName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save;
    }
}