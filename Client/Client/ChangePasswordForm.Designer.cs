namespace Client
{
    partial class ChangePasswordForm
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
            this.PassLable = new System.Windows.Forms.Label();
            this.UserPicture1 = new System.Windows.Forms.PictureBox();
            this.PassAgainField = new System.Windows.Forms.TextBox();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.Button_ChangePass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Label();
            this.PassAgeinLable = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.PassAgeinLable);
            this.MainPanel.Controls.Add(this.PassLable);
            this.MainPanel.Controls.Add(this.UserPicture1);
            this.MainPanel.Controls.Add(this.PassAgainField);
            this.MainPanel.Controls.Add(this.UserPicture);
            this.MainPanel.Controls.Add(this.PassField);
            this.MainPanel.Controls.Add(this.Button_ChangePass);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(354, 268);
            this.MainPanel.TabIndex = 4;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // PassLable
            // 
            this.PassLable.AutoSize = true;
            this.PassLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PassLable.Location = new System.Drawing.Point(90, 85);
            this.PassLable.Name = "PassLable";
            this.PassLable.Size = new System.Drawing.Size(214, 20);
            this.PassLable.TabIndex = 12;
            this.PassLable.Text = "Придумайте новый пароль";
            this.PassLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PassLable_MouseDown);
            this.PassLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PassLable_MouseMove);
            // 
            // UserPicture1
            // 
            this.UserPicture1.Image = global::Client.Properties.Resources.Иконка_числового_кода;
            this.UserPicture1.Location = new System.Drawing.Point(16, 163);
            this.UserPicture1.Name = "UserPicture1";
            this.UserPicture1.Size = new System.Drawing.Size(40, 40);
            this.UserPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicture1.TabIndex = 9;
            this.UserPicture1.TabStop = false;
            this.UserPicture1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserPicture1_MouseDown);
            this.UserPicture1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserPicture1_MouseMove);
            // 
            // PassAgainField
            // 
            this.PassAgainField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassAgainField.Location = new System.Drawing.Point(62, 167);
            this.PassAgainField.Multiline = true;
            this.PassAgainField.Name = "PassAgainField";
            this.PassAgainField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PassAgainField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PassAgainField.Size = new System.Drawing.Size(272, 36);
            this.PassAgainField.TabIndex = 10;
            // 
            // UserPicture
            // 
            this.UserPicture.Image = global::Client.Properties.Resources.Иконка_числового_кода;
            this.UserPicture.Location = new System.Drawing.Point(16, 104);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(40, 40);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicture.TabIndex = 4;
            this.UserPicture.TabStop = false;
            this.UserPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserPicture_MouseDown);
            this.UserPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserPicture_MouseMove);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(62, 108);
            this.PassField.Multiline = true;
            this.PassField.Name = "PassField";
            this.PassField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PassField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PassField.Size = new System.Drawing.Size(272, 36);
            this.PassField.TabIndex = 8;
            // 
            // Button_ChangePass
            // 
            this.Button_ChangePass.BackColor = System.Drawing.Color.Silver;
            this.Button_ChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ChangePass.FlatAppearance.BorderSize = 0;
            this.Button_ChangePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.Button_ChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(178)))), ((int)(((byte)(22)))));
            this.Button_ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Button_ChangePass.Location = new System.Drawing.Point(16, 209);
            this.Button_ChangePass.Name = "Button_ChangePass";
            this.Button_ChangePass.Size = new System.Drawing.Size(318, 42);
            this.Button_ChangePass.TabIndex = 5;
            this.Button_ChangePass.Text = "Подтвердить";
            this.Button_ChangePass.UseVisualStyleBackColor = false;
            this.Button_ChangePass.Click += new System.EventHandler(this.Button_ChangePass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.TitlePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 81);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Gray;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(331, 3);
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
            this.TitlePanel.Size = new System.Drawing.Size(354, 81);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.Text = "Изменение пароля ";
            this.TitlePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseMove);
            // 
            // PassAgeinLable
            // 
            this.PassAgeinLable.AutoSize = true;
            this.PassAgeinLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PassAgeinLable.Location = new System.Drawing.Point(118, 147);
            this.PassAgeinLable.Name = "PassAgeinLable";
            this.PassAgeinLable.Size = new System.Drawing.Size(152, 20);
            this.PassAgeinLable.TabIndex = 13;
            this.PassAgeinLable.Text = "Повторите пароль";
            this.PassAgeinLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PassAgeinLable_MouseDown);
            this.PassAgeinLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PassAgeinLable_MouseMove);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 268);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox UserPicture1;
        private System.Windows.Forms.TextBox PassAgainField;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Button Button_ChangePass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label TitlePanel;
        private System.Windows.Forms.Label PassLable;
        private System.Windows.Forms.Label PassAgeinLable;
    }
}