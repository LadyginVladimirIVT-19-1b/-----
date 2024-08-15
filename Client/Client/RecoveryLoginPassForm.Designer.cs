namespace Client
{
    partial class RecoveryLoginPassForm
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
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.EmailPicture = new System.Windows.Forms.PictureBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.Button_RecoveryLoginPass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.AuthorizationLabel);
            this.MainPanel.Controls.Add(this.EmailPicture);
            this.MainPanel.Controls.Add(this.EmailField);
            this.MainPanel.Controls.Add(this.Button_RecoveryLoginPass);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(348, 198);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.AutoSize = true;
            this.AuthorizationLabel.BackColor = System.Drawing.Color.White;
            this.AuthorizationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorizationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AuthorizationLabel.ForeColor = System.Drawing.Color.Black;
            this.AuthorizationLabel.Location = new System.Drawing.Point(97, 173);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(149, 20);
            this.AuthorizationLabel.TabIndex = 11;
            this.AuthorizationLabel.Text = "Авторизоваться";
            this.AuthorizationLabel.Click += new System.EventHandler(this.AuthorizationLabel_Click);
            this.AuthorizationLabel.MouseEnter += new System.EventHandler(this.AuthorizationLabel_MouseEnter);
            this.AuthorizationLabel.MouseLeave += new System.EventHandler(this.AuthorizationLabel_MouseLeave);
            // 
            // EmailPicture
            // 
            this.EmailPicture.Image = global::Client.Properties.Resources.email;
            this.EmailPicture.Location = new System.Drawing.Point(16, 83);
            this.EmailPicture.Name = "EmailPicture";
            this.EmailPicture.Size = new System.Drawing.Size(40, 40);
            this.EmailPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmailPicture.TabIndex = 9;
            this.EmailPicture.TabStop = false;
            this.EmailPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmailPicture_MouseDown);
            this.EmailPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmailPicture_MouseMove);
            // 
            // EmailField
            // 
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailField.Location = new System.Drawing.Point(62, 86);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.EmailField.Size = new System.Drawing.Size(272, 36);
            this.EmailField.TabIndex = 8;
            this.EmailField.Enter += new System.EventHandler(this.EmailField_Enter);
            this.EmailField.Leave += new System.EventHandler(this.EmailField_Leave);
            // 
            // Button_RecoveryLoginPass
            // 
            this.Button_RecoveryLoginPass.BackColor = System.Drawing.Color.Silver;
            this.Button_RecoveryLoginPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RecoveryLoginPass.FlatAppearance.BorderSize = 0;
            this.Button_RecoveryLoginPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.Button_RecoveryLoginPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(178)))), ((int)(((byte)(22)))));
            this.Button_RecoveryLoginPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RecoveryLoginPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Button_RecoveryLoginPass.Location = new System.Drawing.Point(16, 128);
            this.Button_RecoveryLoginPass.Name = "Button_RecoveryLoginPass";
            this.Button_RecoveryLoginPass.Size = new System.Drawing.Size(318, 42);
            this.Button_RecoveryLoginPass.TabIndex = 5;
            this.Button_RecoveryLoginPass.Text = "Востановить пароль";
            this.Button_RecoveryLoginPass.UseVisualStyleBackColor = false;
            this.Button_RecoveryLoginPass.Click += new System.EventHandler(this.Button_RecoveryLoginPass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.TitlePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 81);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Gray;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(327, 0);
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
            this.TitlePanel.Size = new System.Drawing.Size(348, 81);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.Text = "Восстановление логина и пароля";
            this.TitlePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseMove);
            // 
            // RecoveryLoginPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 198);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoveryLoginPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoveryLoginPassForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox EmailPicture;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Button Button_RecoveryLoginPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label TitlePanel;
        private System.Windows.Forms.Label AuthorizationLabel;
    }
}