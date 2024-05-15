namespace AutoService.AddForms
{
    partial class AddClients
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
            this.Address = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.Notes);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.PhoneNumber);
            this.panel1.Controls.Add(this.FullName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 381);
            this.panel1.TabIndex = 11;
            // 
            // Notes
            // 
            this.Notes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Notes.Location = new System.Drawing.Point(103, 189);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(198, 29);
            this.Notes.TabIndex = 17;
            this.Notes.Text = "Примечание";
            this.Notes.DoubleClick += new System.EventHandler(this.Notes_DoubleClick);
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Address.Location = new System.Drawing.Point(103, 154);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(198, 29);
            this.Address.TabIndex = 16;
            this.Address.Text = "Адрес";
            this.Address.DoubleClick += new System.EventHandler(this.Address_DoubleClick);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(103, 119);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(198, 29);
            this.Email.TabIndex = 15;
            this.Email.Text = "Почта";
            this.Email.DoubleClick += new System.EventHandler(this.Email_DoubleClick);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumber.Location = new System.Drawing.Point(103, 84);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(198, 29);
            this.PhoneNumber.TabIndex = 14;
            this.PhoneNumber.Text = "Номер телефона";
            this.PhoneNumber.DoubleClick += new System.EventHandler(this.PhoneNumber_DoubleClick);
            // 
            // FullName
            // 
            this.FullName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullName.Location = new System.Drawing.Point(103, 49);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(198, 29);
            this.FullName.TabIndex = 6;
            this.FullName.Text = "ФИО";
            this.FullName.DoubleClick += new System.EventHandler(this.FullName_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление Клиента";
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
            this.Save.TabIndex = 13;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
    }
}