namespace Demonstracja
{
    partial class Records
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
            this.GuestsBase = new System.Windows.Forms.RadioButton();
            this.ClientsBase = new System.Windows.Forms.RadioButton();
            this.RoomsBase = new System.Windows.Forms.RadioButton();
            this.recordGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuestsBase
            // 
            this.GuestsBase.AutoSize = true;
            this.GuestsBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestsBase.Location = new System.Drawing.Point(23, 20);
            this.GuestsBase.Margin = new System.Windows.Forms.Padding(4);
            this.GuestsBase.Name = "GuestsBase";
            this.GuestsBase.Size = new System.Drawing.Size(104, 20);
            this.GuestsBase.TabIndex = 0;
            this.GuestsBase.TabStop = true;
            this.GuestsBase.Text = "Постояльцы";
            this.GuestsBase.UseVisualStyleBackColor = true;
            // 
            // ClientsBase
            // 
            this.ClientsBase.AutoSize = true;
            this.ClientsBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientsBase.Location = new System.Drawing.Point(23, 60);
            this.ClientsBase.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsBase.Name = "ClientsBase";
            this.ClientsBase.Size = new System.Drawing.Size(81, 20);
            this.ClientsBase.TabIndex = 1;
            this.ClientsBase.TabStop = true;
            this.ClientsBase.Text = "Клиенты";
            this.ClientsBase.UseVisualStyleBackColor = true;
            // 
            // RoomsBase
            // 
            this.RoomsBase.AutoSize = true;
            this.RoomsBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomsBase.Location = new System.Drawing.Point(23, 100);
            this.RoomsBase.Margin = new System.Windows.Forms.Padding(4);
            this.RoomsBase.Name = "RoomsBase";
            this.RoomsBase.Size = new System.Drawing.Size(130, 20);
            this.RoomsBase.TabIndex = 2;
            this.RoomsBase.TabStop = true;
            this.RoomsBase.Text = "Номерной фонд";
            this.RoomsBase.UseVisualStyleBackColor = true;
            // 
            // recordGen
            // 
            this.recordGen.Location = new System.Drawing.Point(246, 48);
            this.recordGen.Margin = new System.Windows.Forms.Padding(4);
            this.recordGen.Name = "recordGen";
            this.recordGen.Size = new System.Drawing.Size(151, 44);
            this.recordGen.TabIndex = 3;
            this.recordGen.Text = "Отчёт";
            this.recordGen.UseVisualStyleBackColor = true;
            this.recordGen.Click += new System.EventHandler(this.recordGen_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 135);
            this.Controls.Add(this.recordGen);
            this.Controls.Add(this.RoomsBase);
            this.Controls.Add(this.ClientsBase);
            this.Controls.Add(this.GuestsBase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Records";
            this.Text = "Records";
            this.Load += new System.EventHandler(this.Records_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton GuestsBase;
        private System.Windows.Forms.RadioButton ClientsBase;
        private System.Windows.Forms.RadioButton RoomsBase;
        private System.Windows.Forms.Button recordGen;
    }
}