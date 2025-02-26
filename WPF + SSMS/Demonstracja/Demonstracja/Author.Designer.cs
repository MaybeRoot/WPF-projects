namespace Demonstracja
{
    partial class Author
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
            this.AuthorBtn = new System.Windows.Forms.Button();
            this.UserLogin = new System.Windows.Forms.TextBox();
            this.UserPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthorBtn
            // 
            this.AuthorBtn.Font = new System.Drawing.Font("DejaVu Sans Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorBtn.Location = new System.Drawing.Point(97, 246);
            this.AuthorBtn.Name = "AuthorBtn";
            this.AuthorBtn.Size = new System.Drawing.Size(116, 51);
            this.AuthorBtn.TabIndex = 0;
            this.AuthorBtn.Text = "Войти";
            this.AuthorBtn.UseVisualStyleBackColor = true;
            this.AuthorBtn.Click += new System.EventHandler(this.AuthorBtn_Click);
            // 
            // UserLogin
            // 
            this.UserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLogin.Location = new System.Drawing.Point(67, 51);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(179, 24);
            this.UserLogin.TabIndex = 1;
            // 
            // UserPass
            // 
            this.UserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPass.Location = new System.Drawing.Point(67, 157);
            this.UserPass.Name = "UserPass";
            this.UserPass.Size = new System.Drawing.Size(179, 24);
            this.UserPass.TabIndex = 2;
            this.UserPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserPass);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.AuthorBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Author";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthorBtn;
        private System.Windows.Forms.TextBox UserLogin;
        private System.Windows.Forms.TextBox UserPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

