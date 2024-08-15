namespace Client
{
    partial class PasswordRecoveryCodeForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.CodeField = new System.Windows.Forms.TextBox();
            this.Button_RecoveryPass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.UserPicture);
            this.MainPanel.Controls.Add(this.CodeField);
            this.MainPanel.Controls.Add(this.Button_RecoveryPass);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(350, 181);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // UserPicture
            // 
            this.UserPicture.Image = global::Client.Properties.Resources.Иконка_числового_кода;
            this.UserPicture.Location = new System.Drawing.Point(16, 82);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(40, 40);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicture.TabIndex = 4;
            this.UserPicture.TabStop = false;
            this.UserPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserPicture_MouseDown);
            this.UserPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserPicture_MouseMove);
            // 
            // CodeField
            // 
            this.CodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeField.Location = new System.Drawing.Point(62, 86);
            this.CodeField.Multiline = true;
            this.CodeField.Name = "CodeField";
            this.CodeField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CodeField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CodeField.Size = new System.Drawing.Size(272, 36);
            this.CodeField.TabIndex = 8;
            this.CodeField.Enter += new System.EventHandler(this.CodeField_Enter);
            this.CodeField.Leave += new System.EventHandler(this.CodeField_Leave);
            // 
            // Button_RecoveryPass
            // 
            this.Button_RecoveryPass.BackColor = System.Drawing.Color.Silver;
            this.Button_RecoveryPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RecoveryPass.FlatAppearance.BorderSize = 0;
            this.Button_RecoveryPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.Button_RecoveryPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(178)))), ((int)(((byte)(22)))));
            this.Button_RecoveryPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RecoveryPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Button_RecoveryPass.Location = new System.Drawing.Point(16, 128);
            this.Button_RecoveryPass.Name = "Button_RecoveryPass";
            this.Button_RecoveryPass.Size = new System.Drawing.Size(318, 42);
            this.Button_RecoveryPass.TabIndex = 5;
            this.Button_RecoveryPass.Text = "Подтвердить";
            this.Button_RecoveryPass.UseVisualStyleBackColor = false;
            this.Button_RecoveryPass.Click += new System.EventHandler(this.Button_RecoveryPass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.TitlePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 81);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Gray;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(329, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Х";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.Gray;
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitlePanel.ForeColor = System.Drawing.Color.Black;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(350, 81);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.Text = "Введите код для восстановления пароля";
            this.TitlePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseMove);
            // 
            // PasswordRecoveryCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 181);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordRecoveryCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordRecoveryCodeForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox CodeField;
        private System.Windows.Forms.Button Button_RecoveryPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label TitlePanel;
        private System.Windows.Forms.PictureBox UserPicture;
    }
}