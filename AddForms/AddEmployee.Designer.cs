namespace AutoService.AddForms
{
    partial class AddEmployee
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
            this.skills = new System.Windows.Forms.TextBox();
            this.schedule = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.skills);
            this.panel1.Controls.Add(this.schedule);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.phoneNumber);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.fullName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 381);
            this.panel1.TabIndex = 19;
            // 
            // skills
            // 
            this.skills.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skills.Location = new System.Drawing.Point(103, 224);
            this.skills.Name = "skills";
            this.skills.Size = new System.Drawing.Size(198, 29);
            this.skills.TabIndex = 23;
            this.skills.Text = "Навыки";
            this.skills.DoubleClick += new System.EventHandler(this.skills_DoubleClick);
            // 
            // schedule
            // 
            this.schedule.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.schedule.Location = new System.Drawing.Point(103, 189);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(198, 29);
            this.schedule.TabIndex = 22;
            this.schedule.Text = "График работы";
            this.schedule.DoubleClick += new System.EventHandler(this.schedule_DoubleClick);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(103, 154);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(198, 29);
            this.email.TabIndex = 20;
            this.email.Text = "Почта";
            this.email.DoubleClick += new System.EventHandler(this.email_DoubleClick);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.Location = new System.Drawing.Point(103, 119);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(198, 29);
            this.phoneNumber.TabIndex = 19;
            this.phoneNumber.Text = "Номер телефона";
            this.phoneNumber.DoubleClick += new System.EventHandler(this.phoneNumber_DoubleClick);
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.position.Location = new System.Drawing.Point(103, 84);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(198, 29);
            this.position.TabIndex = 17;
            this.position.Text = "Должность";
            this.position.DoubleClick += new System.EventHandler(this.position_DoubleClick);
            // 
            // fullName
            // 
            this.fullName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName.Location = new System.Drawing.Point(103, 49);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(198, 29);
            this.fullName.TabIndex = 16;
            this.fullName.Text = "ФИО";
            this.fullName.DoubleClick += new System.EventHandler(this.fullName_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление Сотрудника";
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
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.save);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox skills;
        private System.Windows.Forms.TextBox schedule;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
    }
}