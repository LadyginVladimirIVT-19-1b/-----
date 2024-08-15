namespace Client
{
    partial class ChatForm
    {
        private System.ComponentModel.IContainer components = null;

       
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.userMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tag = new System.Windows.Forms.Label();
            this.UploadFile = new System.Windows.Forms.Button();
            this.ListTag = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.DownloadFile = new System.Windows.Forms.Button();
            this.ListTagSub = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Unsub_Tag = new System.Windows.Forms.Button();
            this.Sub_Tag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTag = new System.Windows.Forms.ComboBox();
            this.NameTagSub = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userMenu
            // 
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // Tag
            // 
      
            // 
            // UploadFile
            // 
            this.UploadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UploadFile.Location = new System.Drawing.Point(312, 129);
            this.UploadFile.Margin = new System.Windows.Forms.Padding(4);
            this.UploadFile.Name = "UploadFile";
            this.UploadFile.Size = new System.Drawing.Size(117, 70);
            this.UploadFile.TabIndex = 15;
            this.UploadFile.Text = "Загрузитm тег с файлом";
            this.UploadFile.UseVisualStyleBackColor = true;
            this.UploadFile.Click += new System.EventHandler(this.UploadFile_Click);
            // 
            // ListTag
            // 
            this.ListTag.HideSelection = false;
            this.ListTag.Location = new System.Drawing.Point(4, 4);
            this.ListTag.Margin = new System.Windows.Forms.Padding(4);
            this.ListTag.Name = "ListTag";
            this.ListTag.Size = new System.Drawing.Size(275, 271);
            this.ListTag.TabIndex = 0;
            this.ListTag.UseCompatibleStateImageBehavior = false;
            this.ListTag.View = System.Windows.Forms.View.List;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ListTag, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 45);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 279);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(710, 9);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(29, 27);
            this.CloseButton.TabIndex = 17;
            this.CloseButton.Text = "Х";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // DownloadFile
            // 
            this.DownloadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DownloadFile.Location = new System.Drawing.Point(312, 207);
            this.DownloadFile.Margin = new System.Windows.Forms.Padding(4);
            this.DownloadFile.Name = "DownloadFile";
            this.DownloadFile.Size = new System.Drawing.Size(117, 70);
            this.DownloadFile.TabIndex = 18;
            this.DownloadFile.Text = "Скачать файл из тега";
            this.DownloadFile.UseVisualStyleBackColor = true;
            this.DownloadFile.Click += new System.EventHandler(this.DownloadFile_Click);
            // 
            // ListTagSub
            // 
            this.ListTagSub.HideSelection = false;
            this.ListTagSub.Location = new System.Drawing.Point(4, 4);
            this.ListTagSub.Margin = new System.Windows.Forms.Padding(4);
            this.ListTagSub.Name = "ListTagSub";
            this.ListTagSub.Size = new System.Drawing.Size(275, 267);
            this.ListTagSub.TabIndex = 0;
            this.ListTagSub.UseCompatibleStateImageBehavior = false;
            this.ListTagSub.View = System.Windows.Forms.View.List;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ListTagSub, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(446, 49);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(283, 275);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // Unsub_Tag
            // 
            this.Unsub_Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Unsub_Tag.Location = new System.Drawing.Point(446, 358);
            this.Unsub_Tag.Margin = new System.Windows.Forms.Padding(4);
            this.Unsub_Tag.Name = "Unsub_Tag";
            this.Unsub_Tag.Size = new System.Drawing.Size(283, 40);
            this.Unsub_Tag.TabIndex = 21;
            this.Unsub_Tag.Text = "Отписатсья от выбранного тега";
            this.Unsub_Tag.UseVisualStyleBackColor = true;
            this.Unsub_Tag.Click += new System.EventHandler(this.Unsub_Tag_Click);
            // 
            // Sub_Tag
            // 
            this.Sub_Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Sub_Tag.Location = new System.Drawing.Point(11, 358);
            this.Sub_Tag.Margin = new System.Windows.Forms.Padding(4);
            this.Sub_Tag.Name = "Sub_Tag";
            this.Sub_Tag.Size = new System.Drawing.Size(283, 40);
            this.Sub_Tag.TabIndex = 20;
            this.Sub_Tag.Text = "Подписаться на выбранный тег";
            this.Sub_Tag.UseVisualStyleBackColor = true;
            this.Sub_Tag.Click += new System.EventHandler(this.Sub_Tag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(496, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Подписки на теги";
            // 
            // NameTag
            // 
            this.NameTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameTag.FormattingEnabled = true;
            this.NameTag.Location = new System.Drawing.Point(11, 327);
            this.NameTag.Name = "NameTag";
            this.NameTag.Size = new System.Drawing.Size(283, 24);
            this.NameTag.TabIndex = 27;
            // 
            // NameTagSub
            // 
            this.NameTagSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameTagSub.FormattingEnabled = true;
            this.NameTagSub.Location = new System.Drawing.Point(446, 327);
            this.NameTagSub.Name = "NameTagSub";
            this.NameTagSub.Size = new System.Drawing.Size(283, 24);
            this.NameTagSub.TabIndex = 28;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(743, 402);
            this.Controls.Add(this.NameTagSub);
            this.Controls.Add(this.NameTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Unsub_Tag);
            this.Controls.Add(this.Sub_Tag);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.DownloadFile);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.UploadFile);
      
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MQTT";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChatForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChatForm_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip userMenu;
        private System.Windows.Forms.Button UploadFile;
        private System.Windows.Forms.ListView ListTag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button DownloadFile;
        private System.Windows.Forms.ListView ListTagSub;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Unsub_Tag;
        private System.Windows.Forms.Button Sub_Tag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NameTag;
        private System.Windows.Forms.ComboBox NameTagSub;
    }
}

