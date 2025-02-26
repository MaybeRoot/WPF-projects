namespace Tenzor_Trans
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.LoginUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GoToRegistration = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.AutoRoundedCorners = true;
            this.LoginButton.BorderColor = System.Drawing.Color.Blue;
            this.LoginButton.BorderRadius = 21;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.Blue;
            this.LoginButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(114, 379);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(180, 45);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Войти";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginUser
            // 
            this.LoginUser.BorderColor = System.Drawing.Color.Black;
            this.LoginUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginUser.DefaultText = "";
            this.LoginUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginUser.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUser.ForeColor = System.Drawing.Color.Black;
            this.LoginUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginUser.Location = new System.Drawing.Point(78, 204);
            this.LoginUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.PasswordChar = '\0';
            this.LoginUser.PlaceholderText = "Логин";
            this.LoginUser.SelectedText = "";
            this.LoginUser.Size = new System.Drawing.Size(255, 34);
            this.LoginUser.TabIndex = 2;
            // 
            // LoginPass
            // 
            this.LoginPass.BorderColor = System.Drawing.Color.Black;
            this.LoginPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginPass.DefaultText = "";
            this.LoginPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginPass.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.LoginPass.ForeColor = System.Drawing.Color.Black;
            this.LoginPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginPass.Location = new System.Drawing.Point(78, 296);
            this.LoginPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginPass.Name = "LoginPass";
            this.LoginPass.PasswordChar = '⍫';
            this.LoginPass.PlaceholderText = "Пароль";
            this.LoginPass.SelectedText = "";
            this.LoginPass.Size = new System.Drawing.Size(255, 34);
            this.LoginPass.TabIndex = 3;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Tenzor_Trans.Properties.Resources.logo_sign;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(114, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(188, 136);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // GoToRegistration
            // 
            this.GoToRegistration.AutoSize = true;
            this.GoToRegistration.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToRegistration.Location = new System.Drawing.Point(97, 440);
            this.GoToRegistration.Name = "GoToRegistration";
            this.GoToRegistration.Size = new System.Drawing.Size(215, 17);
            this.GoToRegistration.TabIndex = 5;
            this.GoToRegistration.TabStop = true;
            this.GoToRegistration.Text = "Ещё нет профиля? Зарегистрируйтесь!";
            this.GoToRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToRegistration_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 457);
            this.Controls.Add(this.GoToRegistration);
            this.Controls.Add(this.LoginPass);
            this.Controls.Add(this.LoginUser);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox LoginUser;
        private Guna.UI2.WinForms.Guna2TextBox LoginPass;
        private System.Windows.Forms.LinkLabel GoToRegistration;
    }
}

