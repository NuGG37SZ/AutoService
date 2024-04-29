namespace AutoService.AddForms
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
            this.notes = new System.Windows.Forms.TextBox();
            this.vin = new System.Windows.Forms.TextBox();
            this.client = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.make = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.notes);
            this.panel1.Controls.Add(this.vin);
            this.panel1.Controls.Add(this.client);
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.model);
            this.panel1.Controls.Add(this.make);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 381);
            this.panel1.TabIndex = 12;
            // 
            // notes
            // 
            this.notes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notes.Location = new System.Drawing.Point(103, 224);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(198, 29);
            this.notes.TabIndex = 20;
            this.notes.Text = "Примечание";
            this.notes.DoubleClick += new System.EventHandler(this.notes_DoubleClick);
            // 
            // vin
            // 
            this.vin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vin.Location = new System.Drawing.Point(103, 189);
            this.vin.Name = "vin";
            this.vin.Size = new System.Drawing.Size(198, 29);
            this.vin.TabIndex = 19;
            this.vin.Text = "VIN";
            this.vin.DoubleClick += new System.EventHandler(this.vin_DoubleClick);
            // 
            // client
            // 
            this.client.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client.FormattingEnabled = true;
            this.client.Location = new System.Drawing.Point(103, 49);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(198, 29);
            this.client.TabIndex = 18;
            this.client.Text = "Клиент";
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year.Location = new System.Drawing.Point(103, 154);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(198, 29);
            this.year.TabIndex = 17;
            this.year.Text = "Год выпуска";
            this.year.DoubleClick += new System.EventHandler(this.year_DoubleClick);
            // 
            // model
            // 
            this.model.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model.Location = new System.Drawing.Point(103, 119);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(198, 29);
            this.model.TabIndex = 16;
            this.model.Text = "Модель";
            this.model.DoubleClick += new System.EventHandler(this.model_DoubleClick);
            // 
            // make
            // 
            this.make.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.make.Location = new System.Drawing.Point(103, 84);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(198, 29);
            this.make.TabIndex = 15;
            this.make.Text = "Производитель";
            this.make.DoubleClick += new System.EventHandler(this.make_DoubleClick);
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
            this.save.TabIndex = 15;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // AddVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.save);
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
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.TextBox vin;
        private System.Windows.Forms.ComboBox client;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox make;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
    }
}