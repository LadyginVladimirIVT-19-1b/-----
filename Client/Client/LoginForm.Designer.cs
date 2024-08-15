namespace Client
{
    partial class LoginForm
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
            this.Recovery_login_passLabel = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.Button_Authorization = new System.Windows.Forms.Button();
            this.PassField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Label();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.PassPicture = new System.Windows.Forms.PictureBox();
            this.Close_eye_Picture = new System.Windows.Forms.PictureBox();
            this.Open_eye_Picture = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_eye_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Open_eye_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.UserPicture);
            this.MainPanel.Controls.Add(this.Recovery_login_passLabel);
            this.MainPanel.Controls.Add(this.RegisterLabel);
            this.MainPanel.Controls.Add(this.Button_Authorization);
            this.MainPanel.Controls.Add(this.PassField);
            this.MainPanel.Controls.Add(this.PassPicture);
            this.MainPanel.Controls.Add(this.LoginField);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.Close_eye_Picture);
            this.MainPanel.Controls.Add(this.Open_eye_Picture);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(340, 268);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // Recovery_login_passLabel
            // 
            this.Recovery_login_passLabel.AutoSize = true;
            this.Recovery_login_passLabel.BackColor = System.Drawing.Color.White;
            this.Recovery_login_passLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Recovery_login_passLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recovery_login_passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Recovery_login_passLabel.ForeColor = System.Drawing.Color.Black;
            this.Recovery_login_passLabel.Location = new System.Drawing.Point(23, 238);
            this.Recovery_login_passLabel.Name = "Recovery_login_passLabel";
            this.Recovery_login_passLabel.Size = new System.Drawing.Size(295, 20);
            this.Recovery_login_passLabel.TabIndex = 7;
            this.Recovery_login_passLabel.Text = "Восстановление логина и пароля";
            this.Recovery_login_passLabel.Click += new System.EventHandler(this.Recovery_login_passLabel_Click);
            this.Recovery_login_passLabel.MouseEnter += new System.EventHandler(this.Recovery_login_passLabel_MouseEnter);
            this.Recovery_login_passLabel.MouseLeave += new System.EventHandler(this.Recovery_login_passLabel_MouseLeave);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.BackColor = System.Drawing.Color.White;
            this.RegisterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.RegisterLabel.ForeColor = System.Drawing.Color.Black;
            this.RegisterLabel.Location = new System.Drawing.Point(73, 218);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(187, 20);
            this.RegisterLabel.TabIndex = 6;
            this.RegisterLabel.Text = "Зарегистрироваться";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            this.RegisterLabel.MouseEnter += new System.EventHandler(this.RegisterLabel_MouseEnter);
            this.RegisterLabel.MouseLeave += new System.EventHandler(this.RegisterLabel_MouseLeave);
            // 
            // Button_Authorization
            // 
            this.Button_Authorization.BackColor = System.Drawing.Color.Silver;
            this.Button_Authorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Authorization.FlatAppearance.BorderSize = 0;
            this.Button_Authorization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.Button_Authorization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(178)))), ((int)(((byte)(22)))));
            this.Button_Authorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Button_Authorization.Location = new System.Drawing.Point(54, 175);
            this.Button_Authorization.Name = "Button_Authorization";
            this.Button_Authorization.Size = new System.Drawing.Size(231, 40);
            this.Button_Authorization.TabIndex = 5;
            this.Button_Authorization.Text = "Войти";
            this.Button_Authorization.UseVisualStyleBackColor = false;
            this.Button_Authorization.Click += new System.EventHandler(this.Button_Authorization_Click);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(54, 129);
            this.PassField.Name = "PassField";
            this.PassField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PassField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PassField.Size = new System.Drawing.Size(231, 31);
            this.PassField.TabIndex = 4;
            this.PassField.UseSystemPasswordChar = true;
            this.PassField.Enter += new System.EventHandler(this.PassField_Enter);
            this.PassField.Leave += new System.EventHandler(this.PassField_Leave);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(54, 77);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.LoginField.Size = new System.Drawing.Size(231, 36);
            this.LoginField.TabIndex = 2;
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.TitlePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 71);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Gray;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(315, 0);
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
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitlePanel.ForeColor = System.Drawing.Color.Black;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(338, 70);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.Text = "Авторизаиця";
            this.TitlePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseMove);
            // 
            // UserPicture
            // 
            this.UserPicture.Image = global::Client.Properties.Resources.user;
            this.UserPicture.Location = new System.Drawing.Point(8, 73);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(40, 40);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicture.TabIndex = 1;
            this.UserPicture.TabStop = false;
            this.UserPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserPicture_MouseDown);
            this.UserPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserPicture_MouseMove);
            // 
            // PassPicture
            // 
            this.PassPicture.Image = global::Client.Properties.Resources._lock;
            this.PassPicture.Location = new System.Drawing.Point(8, 120);
            this.PassPicture.Name = "PassPicture";
            this.PassPicture.Size = new System.Drawing.Size(40, 40);
            this.PassPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PassPicture.TabIndex = 3;
            this.PassPicture.TabStop = false;
            this.PassPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PassPicture_MouseDown);
            this.PassPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PassPicture_MouseMove);
            // 
            // Close_eye_Picture
            // 
            this.Close_eye_Picture.Image = global::Client.Properties.Resources.close_eye;
            this.Close_eye_Picture.Location = new System.Drawing.Point(291, 129);
            this.Close_eye_Picture.Name = "Close_eye_Picture";
            this.Close_eye_Picture.Size = new System.Drawing.Size(40, 31);
            this.Close_eye_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_eye_Picture.TabIndex = 9;
            this.Close_eye_Picture.TabStop = false;
            this.Close_eye_Picture.Click += new System.EventHandler(this.Close_eye_Picture_Click);
            // 
            // Open_eye_Picture
            // 
            this.Open_eye_Picture.Image = global::Client.Properties.Resources.open_eye;
            this.Open_eye_Picture.Location = new System.Drawing.Point(291, 129);
            this.Open_eye_Picture.Name = "Open_eye_Picture";
            this.Open_eye_Picture.Size = new System.Drawing.Size(40, 31);
            this.Open_eye_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Open_eye_Picture.TabIndex = 8;
            this.Open_eye_Picture.TabStop = false;
            this.Open_eye_Picture.Click += new System.EventHandler(this.Open_eye_Picture_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 268);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_eye_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Open_eye_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.Label Recovery_login_passLabel;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Button Button_Authorization;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.PictureBox PassPicture;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label TitlePanel;
        private System.Windows.Forms.PictureBox Close_eye_Picture;
        private System.Windows.Forms.PictureBox Open_eye_Picture;
    }
}