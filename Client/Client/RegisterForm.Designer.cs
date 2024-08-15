namespace Client
{
    partial class RegisterForm
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
            this.PassFieldRepeat = new System.Windows.Forms.TextBox();
            this.PassPictureRepeat = new System.Windows.Forms.PictureBox();
            this.EmailPicture = new System.Windows.Forms.PictureBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.Button_Registration = new System.Windows.Forms.Button();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PassPicture = new System.Windows.Forms.PictureBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassPictureRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.AuthorizationLabel);
            this.MainPanel.Controls.Add(this.PassFieldRepeat);
            this.MainPanel.Controls.Add(this.PassPictureRepeat);
            this.MainPanel.Controls.Add(this.EmailPicture);
            this.MainPanel.Controls.Add(this.PassField);
            this.MainPanel.Controls.Add(this.Button_Registration);
            this.MainPanel.Controls.Add(this.LoginField);
            this.MainPanel.Controls.Add(this.PassPicture);
            this.MainPanel.Controls.Add(this.EmailField);
            this.MainPanel.Controls.Add(this.UserPicture);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(297, 396);
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
            this.AuthorizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.AuthorizationLabel.ForeColor = System.Drawing.Color.Black;
            this.AuthorizationLabel.Location = new System.Drawing.Point(67, 368);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(159, 22);
            this.AuthorizationLabel.TabIndex = 10;
            this.AuthorizationLabel.Text = "Авторизоваться";
            this.AuthorizationLabel.Click += new System.EventHandler(this.AuthorizationLabel_Click);
            this.AuthorizationLabel.MouseEnter += new System.EventHandler(this.AuthorizationLabel_MouseEnter);
            this.AuthorizationLabel.MouseLeave += new System.EventHandler(this.AuthorizationLabel_MouseLeave);
            // 
            // PassFieldRepeat
            // 
            this.PassFieldRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassFieldRepeat.Location = new System.Drawing.Point(58, 273);
            this.PassFieldRepeat.Multiline = true;
            this.PassFieldRepeat.Name = "PassFieldRepeat";
            this.PassFieldRepeat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PassFieldRepeat.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PassFieldRepeat.Size = new System.Drawing.Size(228, 36);
            this.PassFieldRepeat.TabIndex = 9;
            this.PassFieldRepeat.UseSystemPasswordChar = true;
            this.PassFieldRepeat.Enter += new System.EventHandler(this.PassFieldRepeat_Enter);
            this.PassFieldRepeat.Leave += new System.EventHandler(this.PassFieldRepeat_Leave);
            // 
            // PassPictureRepeat
            // 
            this.PassPictureRepeat.Image = global::Client.Properties.Resources._lock;
            this.PassPictureRepeat.Location = new System.Drawing.Point(12, 269);
            this.PassPictureRepeat.Name = "PassPictureRepeat";
            this.PassPictureRepeat.Size = new System.Drawing.Size(40, 40);
            this.PassPictureRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PassPictureRepeat.TabIndex = 8;
            this.PassPictureRepeat.TabStop = false;
            this.PassPictureRepeat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PassPictureRepeat_MouseDown);
            this.PassPictureRepeat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PassPictureRepeat_MouseMove);
            // 
            // EmailPicture
            // 
            this.EmailPicture.Image = global::Client.Properties.Resources.email;
            this.EmailPicture.Location = new System.Drawing.Point(12, 97);
            this.EmailPicture.Name = "EmailPicture";
            this.EmailPicture.Size = new System.Drawing.Size(40, 40);
            this.EmailPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmailPicture.TabIndex = 7;
            this.EmailPicture.TabStop = false;
            this.EmailPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmailPicture_MouseDown);
            this.EmailPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmailPicture_MouseMove);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(57, 217);
            this.PassField.Multiline = true;
            this.PassField.Name = "PassField";
            this.PassField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PassField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PassField.Size = new System.Drawing.Size(228, 36);
            this.PassField.TabIndex = 6;
            this.PassField.Enter += new System.EventHandler(this.PassField_Enter);
            this.PassField.Leave += new System.EventHandler(this.PassField_Leave);
            // 
            // Button_Registration
            // 
            this.Button_Registration.BackColor = System.Drawing.Color.Silver;
            this.Button_Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Registration.FlatAppearance.BorderSize = 0;
            this.Button_Registration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.Button_Registration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(178)))), ((int)(((byte)(22)))));
            this.Button_Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Button_Registration.Location = new System.Drawing.Point(12, 325);
            this.Button_Registration.Name = "Button_Registration";
            this.Button_Registration.Size = new System.Drawing.Size(274, 40);
            this.Button_Registration.TabIndex = 5;
            this.Button_Registration.Text = "Зарегистрироваться";
            this.Button_Registration.UseVisualStyleBackColor = false;
            this.Button_Registration.Click += new System.EventHandler(this.Button_Registration_Click);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(58, 158);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.LoginField.Size = new System.Drawing.Size(228, 36);
            this.LoginField.TabIndex = 4;
            this.LoginField.UseSystemPasswordChar = true;
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // PassPicture
            // 
            this.PassPicture.Image = global::Client.Properties.Resources._lock;
            this.PassPicture.Location = new System.Drawing.Point(12, 213);
            this.PassPicture.Name = "PassPicture";
            this.PassPicture.Size = new System.Drawing.Size(40, 40);
            this.PassPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PassPicture.TabIndex = 3;
            this.PassPicture.TabStop = false;
            this.PassPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PassPicture_MouseDown);
            this.PassPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PassPicture_MouseMove);
            // 
            // EmailField
            // 
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailField.Location = new System.Drawing.Point(57, 101);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.EmailField.Size = new System.Drawing.Size(228, 36);
            this.EmailField.TabIndex = 2;
            this.EmailField.Enter += new System.EventHandler(this.EmailField_Enter);
            this.EmailField.Leave += new System.EventHandler(this.EmailField_Leave);
            // 
            // UserPicture
            // 
            this.UserPicture.Image = global::Client.Properties.Resources.user;
            this.UserPicture.Location = new System.Drawing.Point(12, 154);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(40, 40);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicture.TabIndex = 1;
            this.UserPicture.TabStop = false;
            this.UserPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserPicture_MouseDown);
            this.UserPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserPicture_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.TitlePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 81);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Gray;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(275, 0);
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
            this.TitlePanel.Size = new System.Drawing.Size(297, 81);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.Text = "Регистрация";
            this.TitlePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseMove);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 396);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassPictureRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label AuthorizationLabel;
        private System.Windows.Forms.TextBox PassFieldRepeat;
        private System.Windows.Forms.PictureBox PassPictureRepeat;
        private System.Windows.Forms.PictureBox EmailPicture;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Button Button_Registration;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.PictureBox PassPicture;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label TitlePanel;
    }
}