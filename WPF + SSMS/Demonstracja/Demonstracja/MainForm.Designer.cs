namespace Demonstracja
{
    partial class MainForm
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
            this.GuestsBtn = new System.Windows.Forms.Button();
            this.PassChangeBtn = new System.Windows.Forms.Button();
            this.ClientsBtn = new System.Windows.Forms.Button();
            this.RoomsBtn = new System.Windows.Forms.Button();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.roleUser = new System.Windows.Forms.Label();
            this.recordsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuestsBtn
            // 
            this.GuestsBtn.Font = new System.Drawing.Font("DejaVu Sans Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestsBtn.Location = new System.Drawing.Point(30, 29);
            this.GuestsBtn.Name = "GuestsBtn";
            this.GuestsBtn.Size = new System.Drawing.Size(120, 47);
            this.GuestsBtn.TabIndex = 0;
            this.GuestsBtn.Text = "Постояльцы";
            this.GuestsBtn.UseVisualStyleBackColor = true;
            this.GuestsBtn.Click += new System.EventHandler(this.GuestsBtn_Click);
            // 
            // PassChangeBtn
            // 
            this.PassChangeBtn.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassChangeBtn.Location = new System.Drawing.Point(347, 182);
            this.PassChangeBtn.Name = "PassChangeBtn";
            this.PassChangeBtn.Size = new System.Drawing.Size(104, 28);
            this.PassChangeBtn.TabIndex = 3;
            this.PassChangeBtn.Text = "Смена пароля";
            this.PassChangeBtn.UseVisualStyleBackColor = true;
            this.PassChangeBtn.Click += new System.EventHandler(this.PassChangeBtn_Click);
            // 
            // ClientsBtn
            // 
            this.ClientsBtn.Font = new System.Drawing.Font("DejaVu Sans Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientsBtn.Location = new System.Drawing.Point(30, 120);
            this.ClientsBtn.Name = "ClientsBtn";
            this.ClientsBtn.Size = new System.Drawing.Size(120, 47);
            this.ClientsBtn.TabIndex = 4;
            this.ClientsBtn.Text = "Клиенты";
            this.ClientsBtn.UseVisualStyleBackColor = true;
            this.ClientsBtn.Click += new System.EventHandler(this.ClientsBtn_Click);
            // 
            // RoomsBtn
            // 
            this.RoomsBtn.Font = new System.Drawing.Font("DejaVu Sans Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomsBtn.Location = new System.Drawing.Point(294, 29);
            this.RoomsBtn.Name = "RoomsBtn";
            this.RoomsBtn.Size = new System.Drawing.Size(120, 47);
            this.RoomsBtn.TabIndex = 5;
            this.RoomsBtn.Text = "Номерной Фонд";
            this.RoomsBtn.UseVisualStyleBackColor = true;
            this.RoomsBtn.Click += new System.EventHandler(this.RoomsBtn_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.Font = new System.Drawing.Font("DejaVu Sans Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersBtn.Location = new System.Drawing.Point(294, 120);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(120, 47);
            this.UsersBtn.TabIndex = 6;
            this.UsersBtn.Text = "Пользователи";
            this.UsersBtn.UseVisualStyleBackColor = true;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // roleUser
            // 
            this.roleUser.AutoSize = true;
            this.roleUser.Location = new System.Drawing.Point(382, 9);
            this.roleUser.Name = "roleUser";
            this.roleUser.Size = new System.Drawing.Size(32, 13);
            this.roleUser.TabIndex = 7;
            this.roleUser.Text = "Роль";
            // 
            // recordsBtn
            // 
            this.recordsBtn.Font = new System.Drawing.Font("DejaVu Sans Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recordsBtn.Location = new System.Drawing.Point(168, 74);
            this.recordsBtn.Name = "recordsBtn";
            this.recordsBtn.Size = new System.Drawing.Size(120, 47);
            this.recordsBtn.TabIndex = 8;
            this.recordsBtn.Text = "Отчёты";
            this.recordsBtn.UseVisualStyleBackColor = true;
            this.recordsBtn.Click += new System.EventHandler(this.recordsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 212);
            this.Controls.Add(this.recordsBtn);
            this.Controls.Add(this.roleUser);
            this.Controls.Add(this.UsersBtn);
            this.Controls.Add(this.RoomsBtn);
            this.Controls.Add(this.ClientsBtn);
            this.Controls.Add(this.PassChangeBtn);
            this.Controls.Add(this.GuestsBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuestsBtn;
        private System.Windows.Forms.Button PassChangeBtn;
        private System.Windows.Forms.Button ClientsBtn;
        private System.Windows.Forms.Button RoomsBtn;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Label roleUser;
        private System.Windows.Forms.Button recordsBtn;
    }
}