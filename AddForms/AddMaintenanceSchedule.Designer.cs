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
            this.serviceType = new System.Windows.Forms.ComboBox();
            this.note = new System.Windows.Forms.TextBox();
            this.car = new System.Windows.Forms.ComboBox();
            this.nextServiceDate = new System.Windows.Forms.TextBox();
            this.lastServiceDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.serviceType);
            this.panel1.Controls.Add(this.note);
            this.panel1.Controls.Add(this.car);
            this.panel1.Controls.Add(this.nextServiceDate);
            this.panel1.Controls.Add(this.lastServiceDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 381);
            this.panel1.TabIndex = 19;
            // 
            // serviceType
            // 
            this.serviceType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceType.FormattingEnabled = true;
            this.serviceType.Location = new System.Drawing.Point(103, 154);
            this.serviceType.Name = "serviceType";
            this.serviceType.Size = new System.Drawing.Size(198, 29);
            this.serviceType.TabIndex = 23;
            this.serviceType.Text = "Тип услуги";
            // 
            // note
            // 
            this.note.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.note.Location = new System.Drawing.Point(103, 189);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(198, 29);
            this.note.TabIndex = 22;
            this.note.Text = "Примечание";
            this.note.DoubleClick += new System.EventHandler(this.note_DoubleClick);
            // 
            // car
            // 
            this.car.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car.FormattingEnabled = true;
            this.car.Location = new System.Drawing.Point(103, 49);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(198, 29);
            this.car.TabIndex = 21;
            this.car.Text = "Автомобиль";
            // 
            // nextServiceDate
            // 
            this.nextServiceDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextServiceDate.Location = new System.Drawing.Point(103, 119);
            this.nextServiceDate.Name = "nextServiceDate";
            this.nextServiceDate.Size = new System.Drawing.Size(198, 29);
            this.nextServiceDate.TabIndex = 17;
            this.nextServiceDate.Text = "Следующее посещение";
            this.nextServiceDate.DoubleClick += new System.EventHandler(this.nextServiceDate_DoubleClick);
            // 
            // lastServiceDate
            // 
            this.lastServiceDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastServiceDate.Location = new System.Drawing.Point(103, 84);
            this.lastServiceDate.Name = "lastServiceDate";
            this.lastServiceDate.Size = new System.Drawing.Size(198, 29);
            this.lastServiceDate.TabIndex = 16;
            this.lastServiceDate.Text = "Последнее посещения";
            this.lastServiceDate.DoubleClick += new System.EventHandler(this.lastServiceDate_DoubleClick);
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
            // AddMaintenanceSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.save);
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
        private System.Windows.Forms.ComboBox serviceType;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.ComboBox car;
        private System.Windows.Forms.TextBox nextServiceDate;
        private System.Windows.Forms.TextBox lastServiceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
    }
}