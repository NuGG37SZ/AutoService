﻿namespace AutoService.AddForms
{
    partial class AddVehicles
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
            this.Notes = new System.Windows.Forms.TextBox();
            this.Vin = new System.Windows.Forms.TextBox();
            this.Client = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.Make = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.Notes);
            this.panel1.Controls.Add(this.Vin);
            this.panel1.Controls.Add(this.Client);
            this.panel1.Controls.Add(this.Year);
            this.panel1.Controls.Add(this.Model);
            this.panel1.Controls.Add(this.Make);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 381);
            this.panel1.TabIndex = 12;
            // 
            // Notes
            // 
            this.Notes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Notes.Location = new System.Drawing.Point(103, 224);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(198, 29);
            this.Notes.TabIndex = 20;
            this.Notes.Text = "Примечание";
            this.Notes.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // Vin
            // 
            this.Vin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vin.Location = new System.Drawing.Point(103, 189);
            this.Vin.Name = "Vin";
            this.Vin.Size = new System.Drawing.Size(198, 29);
            this.Vin.TabIndex = 19;
            this.Vin.Text = "VIN";
            this.Vin.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // Client
            // 
            this.Client.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Client.FormattingEnabled = true;
            this.Client.Location = new System.Drawing.Point(103, 49);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(198, 29);
            this.Client.TabIndex = 18;
            this.Client.Text = "Клиент";
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year.Location = new System.Drawing.Point(103, 154);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(198, 29);
            this.Year.TabIndex = 17;
            this.Year.Text = "Год выпуска";
            this.Year.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // Model
            // 
            this.Model.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model.Location = new System.Drawing.Point(103, 119);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(198, 29);
            this.Model.TabIndex = 16;
            this.Model.Text = "Модель";
            this.Model.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // Make
            // 
            this.Make.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Make.Location = new System.Drawing.Point(103, 84);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(198, 29);
            this.Make.TabIndex = 15;
            this.Make.Text = "Производитель";
            this.Make.DoubleClick += new System.EventHandler(this.ClearTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление Автомобиля";
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
            this.Save.TabIndex = 15;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddVehicles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.TextBox Vin;
        private System.Windows.Forms.ComboBox Client;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Make;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
    }
}