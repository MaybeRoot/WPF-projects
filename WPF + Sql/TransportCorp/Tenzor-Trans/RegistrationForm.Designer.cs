namespace Tenzor_Trans
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.UserPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserOtch = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.UserNewLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserAdress = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegisterButton = new Guna.UI2.WinForms.Guna2Button();
            this.GoToLogin = new System.Windows.Forms.LinkLabel();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2GroupBox1.Controls.Add(this.UserAdress);
            this.guna2GroupBox1.Controls.Add(this.UserPhone);
            this.guna2GroupBox1.Controls.Add(this.UserOtch);
            this.guna2GroupBox1.Controls.Add(this.UserName);
            this.guna2GroupBox1.Controls.Add(this.UserSurname);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Blue;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(14, 58);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(738, 263);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Личные данные";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // UserPhone
            // 
            this.UserPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPhone.DefaultText = "";
            this.UserPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserPhone.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserPhone.Location = new System.Drawing.Point(507, 71);
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.PasswordChar = '\0';
            this.UserPhone.PlaceholderText = "Телефон";
            this.UserPhone.SelectedText = "";
            this.UserPhone.Size = new System.Drawing.Size(200, 36);
            this.UserPhone.TabIndex = 3;
            // 
            // UserOtch
            // 
            this.UserOtch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserOtch.DefaultText = "";
            this.UserOtch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserOtch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserOtch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserOtch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserOtch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserOtch.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.UserOtch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserOtch.Location = new System.Drawing.Point(21, 205);
            this.UserOtch.Name = "UserOtch";
            this.UserOtch.PasswordChar = '\0';
            this.UserOtch.PlaceholderText = "Отчество";
            this.UserOtch.SelectedText = "";
            this.UserOtch.Size = new System.Drawing.Size(200, 36);
            this.UserOtch.TabIndex = 2;
            // 
            // UserName
            // 
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.DefaultText = "";
            this.UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName.Location = new System.Drawing.Point(21, 137);
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.PlaceholderText = "Имя";
            this.UserName.SelectedText = "";
            this.UserName.Size = new System.Drawing.Size(200, 36);
            this.UserName.TabIndex = 1;
            // 
            // UserSurname
            // 
            this.UserSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserSurname.DefaultText = "";
            this.UserSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserSurname.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserSurname.Location = new System.Drawing.Point(21, 71);
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.PasswordChar = '\0';
            this.UserSurname.PlaceholderText = "Фамилия";
            this.UserSurname.SelectedText = "";
            this.UserSurname.Size = new System.Drawing.Size(200, 36);
            this.UserSurname.TabIndex = 0;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.UserNewPassword);
            this.guna2GroupBox2.Controls.Add(this.UserNewLogin);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Blue;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(14, 336);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(738, 107);
            this.guna2GroupBox2.TabIndex = 2;
            this.guna2GroupBox2.Text = "Данные для входа";
            // 
            // UserNewLogin
            // 
            this.UserNewLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNewLogin.DefaultText = "";
            this.UserNewLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserNewLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserNewLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNewLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNewLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNewLogin.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.UserNewLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNewLogin.Location = new System.Drawing.Point(21, 56);
            this.UserNewLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserNewLogin.Name = "UserNewLogin";
            this.UserNewLogin.PasswordChar = '\0';
            this.UserNewLogin.PlaceholderText = "Логин";
            this.UserNewLogin.SelectedText = "";
            this.UserNewLogin.Size = new System.Drawing.Size(200, 36);
            this.UserNewLogin.TabIndex = 0;
            // 
            // UserNewPassword
            // 
            this.UserNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNewPassword.DefaultText = "";
            this.UserNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNewPassword.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNewPassword.Location = new System.Drawing.Point(507, 56);
            this.UserNewPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserNewPassword.Name = "UserNewPassword";
            this.UserNewPassword.PasswordChar = '\0';
            this.UserNewPassword.PlaceholderText = "Пароль";
            this.UserNewPassword.SelectedText = "";
            this.UserNewPassword.Size = new System.Drawing.Size(200, 36);
            this.UserNewPassword.TabIndex = 1;
            this.UserNewPassword.TextChanged += new System.EventHandler(this.guna2TextBox6_TextChanged);
            // 
            // UserAdress
            // 
            this.UserAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserAdress.DefaultText = "";
            this.UserAdress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserAdress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserAdress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserAdress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserAdress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserAdress.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAdress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserAdress.Location = new System.Drawing.Point(507, 137);
            this.UserAdress.Name = "UserAdress";
            this.UserAdress.PasswordChar = '\0';
            this.UserAdress.PlaceholderText = "Адрес";
            this.UserAdress.SelectedText = "";
            this.UserAdress.Size = new System.Drawing.Size(200, 36);
            this.UserAdress.TabIndex = 4;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Animated = true;
            this.RegisterButton.AutoRoundedCorners = true;
            this.RegisterButton.BorderRadius = 21;
            this.RegisterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterButton.FillColor = System.Drawing.Color.Blue;
            this.RegisterButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(287, 458);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(180, 45);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Зарегистрироваться";
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // GoToLogin
            // 
            this.GoToLogin.AutoSize = true;
            this.GoToLogin.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToLogin.Location = new System.Drawing.Point(248, 521);
            this.GoToLogin.Name = "GoToLogin";
            this.GoToLogin.Size = new System.Drawing.Size(266, 17);
            this.GoToLogin.TabIndex = 4;
            this.GoToLogin.TabStop = true;
            this.GoToLogin.Text = "Уже зарегистрировались? Тогда авторизуйтесь!";
            this.GoToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToLogin_LinkClicked);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 538);
            this.Controls.Add(this.GoToLogin);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.ShowIcon = false;
            this.Text = "Регистрация";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox UserPhone;
        private Guna.UI2.WinForms.Guna2TextBox UserOtch;
        private Guna.UI2.WinForms.Guna2TextBox UserName;
        private Guna.UI2.WinForms.Guna2TextBox UserSurname;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2TextBox UserNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox UserNewLogin;
        private Guna.UI2.WinForms.Guna2TextBox UserAdress;
        private Guna.UI2.WinForms.Guna2Button RegisterButton;
        private System.Windows.Forms.LinkLabel GoToLogin;
    }
}