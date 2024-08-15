namespace Client
{
    partial class UpLoadFileForm
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
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpLoadFile = new System.Windows.Forms.Button();
            this.SelectFile = new System.Windows.Forms.Button();
            this.Hint_User = new System.Windows.Forms.Label();
            this.Path_File = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(250, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "Х";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Загрузить файл";
            // 
            // UpLoadFile
            // 
            this.UpLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UpLoadFile.Location = new System.Drawing.Point(30, 178);
            this.UpLoadFile.Name = "UpLoadFile";
            this.UpLoadFile.Size = new System.Drawing.Size(223, 34);
            this.UpLoadFile.TabIndex = 21;
            this.UpLoadFile.Text = "Загрузить файл";
            this.UpLoadFile.UseVisualStyleBackColor = true;
            this.UpLoadFile.Click += new System.EventHandler(this.UpLoadFile_Click);
            // 
            // SelectFile
            // 
            this.SelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SelectFile.Location = new System.Drawing.Point(30, 138);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(223, 34);
            this.SelectFile.TabIndex = 20;
            this.SelectFile.Text = "Выбрать файл";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // Hint_User
            // 
            this.Hint_User.AutoSize = true;
            this.Hint_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Hint_User.Location = new System.Drawing.Point(64, 76);
            this.Hint_User.Name = "Hint_User";
            this.Hint_User.Size = new System.Drawing.Size(156, 24);
            this.Hint_User.TabIndex = 19;
            this.Hint_User.Text = "Файл не выбран";
            // 
            // Path_File
            // 
            this.Path_File.AutoSize = true;
            this.Path_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Path_File.Location = new System.Drawing.Point(64, 105);
            this.Path_File.Name = "Path_File";
            this.Path_File.Size = new System.Drawing.Size(0, 24);
            this.Path_File.TabIndex = 25;
            // 
            // UpLoadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 225);
            this.Controls.Add(this.Path_File);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpLoadFile);
            this.Controls.Add(this.SelectFile);
            this.Controls.Add(this.Hint_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpLoadFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpLoadFileForm";
            this.Load += new System.EventHandler(this.UpLoadFileForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpLoadFileForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpLoadFileForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpLoadFile;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Label Hint_User;
        private System.Windows.Forms.Label Path_File;
    }
}