namespace AutoService.AddForms
{
    partial class AddOrderParts
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
            this.Inventory = new System.Windows.Forms.ComboBox();
            this.Orders = new System.Windows.Forms.ComboBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.Inventory);
            this.panel1.Controls.Add(this.Orders);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 381);
            this.panel1.TabIndex = 12;
            // 
            // Inventory
            // 
            this.Inventory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inventory.FormattingEnabled = true;
            this.Inventory.Location = new System.Drawing.Point(103, 84);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(198, 29);
            this.Inventory.TabIndex = 23;
            this.Inventory.Text = "Запчасть";
            // 
            // Orders
            // 
            this.Orders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orders.FormattingEnabled = true;
            this.Orders.Location = new System.Drawing.Point(103, 49);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(198, 29);
            this.Orders.TabIndex = 22;
            this.Orders.Text = "Номер заказа";
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quantity.Location = new System.Drawing.Point(103, 119);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(198, 29);
            this.Quantity.TabIndex = 15;
            this.Quantity.Text = "Количество";
            this.Quantity.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление запчасти в заказ";
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
            this.Save.TabIndex = 14;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddOrderParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddOrderParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddOrderParts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Inventory;
        private System.Windows.Forms.ComboBox Orders;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
    }
}