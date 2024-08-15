namespace Client
{
    partial class DownLoadFileForm
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
            this.ViewFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Hint_User = new System.Windows.Forms.Label();
            this.NameTagFile = new System.Windows.Forms.ComboBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewFile
            // 
            this.ViewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ViewFile.Location = new System.Drawing.Point(40, 136);
            this.ViewFile.Name = "ViewFile";
            this.ViewFile.Size = new System.Drawing.Size(204, 41);
            this.ViewFile.TabIndex = 5;
            this.ViewFile.Text = "Скачать файл";
            this.ViewFile.UseVisualStyleBackColor = true;
            this.ViewFile.Click += new System.EventHandler(this.ViewFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Скачать файл";
            // 
            // Hint_User
            // 
            this.Hint_User.AutoSize = true;
            this.Hint_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Hint_User.Location = new System.Drawing.Point(24, 71);
            this.Hint_User.Name = "Hint_User";
            this.Hint_User.Size = new System.Drawing.Size(242, 24);
            this.Hint_User.TabIndex = 24;
            this.Hint_User.Text = "Выберете файл из списка";
            // 
            // NameTagFile
            // 
            this.NameTagFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NameTagFile.FormattingEnabled = true;
            this.NameTagFile.Location = new System.Drawing.Point(40, 98);
            this.NameTagFile.Name = "NameTagFile";
            this.NameTagFile.Size = new System.Drawing.Size(204, 32);
            this.NameTagFile.TabIndex = 26;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(244, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.TabIndex = 27;
            this.CloseButton.Text = "Х";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // DownLoadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 188);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.NameTagFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hint_User);
            this.Controls.Add(this.ViewFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DownLoadFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DownLoadFileForm";
            this.Load += new System.EventHandler(this.DownLoadFileForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownLoadFileForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DownLoadFileForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ViewFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Hint_User;
        private System.Windows.Forms.ComboBox NameTagFile;
        private System.Windows.Forms.Label CloseButton;
    }
}