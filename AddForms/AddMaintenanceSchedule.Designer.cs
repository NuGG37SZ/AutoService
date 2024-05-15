namespace AutoService.AddForms
{
    partial class AddMaintenanceSchedule
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
            this.ServiceType = new System.Windows.Forms.ComboBox();
            this.Notes = new System.Windows.Forms.TextBox();
            this.Car = new System.Windows.Forms.ComboBox();
            this.NextServiceDate = new System.Windows.Forms.TextBox();
            this.LastServiceDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.ServiceType);
            this.panel1.Controls.Add(this.Notes);
            this.panel1.Controls.Add(this.Car);
            this.panel1.Controls.Add(this.NextServiceDate);
            this.panel1.Controls.Add(this.LastServiceDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 381);
            this.panel1.TabIndex = 19;
            // 
            // ServiceType
            // 
            this.ServiceType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceType.FormattingEnabled = true;
            this.ServiceType.Location = new System.Drawing.Point(103, 154);
            this.ServiceType.Name = "ServiceType";
            this.ServiceType.Size = new System.Drawing.Size(198, 29);
            this.ServiceType.TabIndex = 23;
            this.ServiceType.Text = "Тип услуги";
            // 
            // Notes
            // 
            this.Notes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Notes.Location = new System.Drawing.Point(103, 189);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(198, 29);
            this.Notes.TabIndex = 22;
            this.Notes.Text = "Примечание";
            this.Notes.DoubleClick += new System.EventHandler(this.Notes_DoubleClick);
            // 
            // Car
            // 
            this.Car.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Car.FormattingEnabled = true;
            this.Car.Location = new System.Drawing.Point(103, 49);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(198, 29);
            this.Car.TabIndex = 21;
            this.Car.Text = "Автомобиль";
            // 
            // NextServiceDate
            // 
            this.NextServiceDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextServiceDate.Location = new System.Drawing.Point(103, 119);
            this.NextServiceDate.Name = "NextServiceDate";
            this.NextServiceDate.Size = new System.Drawing.Size(198, 29);
            this.NextServiceDate.TabIndex = 17;
            this.NextServiceDate.Text = "Следующее посещение";
            this.NextServiceDate.DoubleClick += new System.EventHandler(this.NextServiceDate_DoubleClick);
            // 
            // LastServiceDate
            // 
            this.LastServiceDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastServiceDate.Location = new System.Drawing.Point(103, 84);
            this.LastServiceDate.Name = "LastServiceDate";
            this.LastServiceDate.Size = new System.Drawing.Size(198, 29);
            this.LastServiceDate.TabIndex = 16;
            this.LastServiceDate.Text = "Последнее посещения";
            this.LastServiceDate.DoubleClick += new System.EventHandler(this.LastServiceDate_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление Обслуживания";
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
            // AddMaintenanceSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddMaintenanceSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddMaintenanceSchedule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ServiceType;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.ComboBox Car;
        private System.Windows.Forms.TextBox NextServiceDate;
        private System.Windows.Forms.TextBox LastServiceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
    }
}