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
            this.connection = new System.Windows.Forms.Button();
            this.Entering_a_nickname = new System.Windows.Forms.Label();
            this.nicknameData = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.userList = new System.Windows.Forms.ListBox();
            this.Chat = new System.Windows.Forms.Label();
            this.list_of_users = new System.Windows.Forms.Label();
            this.messageData = new System.Windows.Forms.TextBox();
            this.userMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Text_for_chat = new System.Windows.Forms.Label();
            this.Subscription = new System.Windows.Forms.Label();
            this.listTag = new System.Windows.Forms.ListBox();
            this.Tag = new System.Windows.Forms.Label();
            this.listSubscription = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // connection
            // 
            this.connection.Enabled = false;
            this.connection.Location = new System.Drawing.Point(423, 5);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(111, 29);
            this.connection.TabIndex = 0;
            this.connection.Text = "Подключится";
            this.connection.UseVisualStyleBackColor = true;
            this.connection.Click += new System.EventHandler(this.enterChat_Click);
            // 
            // Entering_a_nickname
            // 
            this.Entering_a_nickname.AutoSize = true;
            this.Entering_a_nickname.Location = new System.Drawing.Point(4, 13);
            this.Entering_a_nickname.Name = "Entering_a_nickname";
            this.Entering_a_nickname.Size = new System.Drawing.Size(101, 13);
            this.Entering_a_nickname.TabIndex = 1;
            this.Entering_a_nickname.Text = "Введите ваш НИК:";
            this.Entering_a_nickname.Click += new System.EventHandler(this.label1_Click);
            // 
            // nicknameData
            // 
            this.nicknameData.Enabled = false;
            this.nicknameData.Location = new System.Drawing.Point(122, 10);
            this.nicknameData.Name = "nicknameData";
            this.nicknameData.Size = new System.Drawing.Size(272, 20);
            this.nicknameData.TabIndex = 2;
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.White;
            this.chatBox.Enabled = false;
            this.chatBox.Location = new System.Drawing.Point(7, 53);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(288, 291);
            this.chatBox.TabIndex = 3;
            this.chatBox.Text = "";
            // 
            // userList
            // 
            this.userList.Enabled = false;
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(329, 54);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(227, 290);
            this.userList.TabIndex = 4;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // Chat
            // 
            this.Chat.AutoSize = true;
            this.Chat.Location = new System.Drawing.Point(11, 37);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(32, 13);
            this.Chat.TabIndex = 5;
            this.Chat.Text = "Чат: ";
            // 
            // list_of_users
            // 
            this.list_of_users.AutoSize = true;
            this.list_of_users.Location = new System.Drawing.Point(335, 38);
            this.list_of_users.Name = "list_of_users";
            this.list_of_users.Size = new System.Drawing.Size(130, 13);
            this.list_of_users.TabIndex = 6;
            this.list_of_users.Text = "Список пользователей: ";
            // 
            // messageData
            // 
            this.messageData.Enabled = false;
            this.messageData.Location = new System.Drawing.Point(14, 365);
            this.messageData.Name = "messageData";
            this.messageData.Size = new System.Drawing.Size(1062, 20);
            this.messageData.TabIndex = 7;
            this.messageData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messageData_KeyUp);
            // 
            // userMenu
            // 
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // Text_for_chat
            // 
            this.Text_for_chat.AutoSize = true;
            this.Text_for_chat.Location = new System.Drawing.Point(12, 349);
            this.Text_for_chat.Name = "Text_for_chat";
            this.Text_for_chat.Size = new System.Drawing.Size(78, 13);
            this.Text_for_chat.TabIndex = 9;
            this.Text_for_chat.Text = "Текс для чата";
            this.Text_for_chat.Click += new System.EventHandler(this.nameData_Click);
            // 
            // Subscription
            // 
            this.Subscription.AutoSize = true;
            this.Subscription.Location = new System.Drawing.Point(600, 37);
            this.Subscription.Name = "Subscription";
            this.Subscription.Size = new System.Drawing.Size(60, 13);
            this.Subscription.TabIndex = 11;
            this.Subscription.Text = "Подписки:";
            // 
            // listTag
            // 
            this.listTag.Enabled = false;
            this.listTag.FormattingEnabled = true;
            this.listTag.Location = new System.Drawing.Point(849, 54);
            this.listTag.Name = "listTag";
            this.listTag.Size = new System.Drawing.Size(227, 290);
            this.listTag.TabIndex = 12;
            // 
            // Tag
            // 
            this.Tag.AutoSize = true;
            this.Tag.Location = new System.Drawing.Point(855, 37);
            this.Tag.Name = "Tag";
            this.Tag.Size = new System.Drawing.Size(34, 13);
            this.Tag.TabIndex = 13;
            this.Tag.Text = "Теги:";
            // 
            // listSubscription
            // 
            this.listSubscription.Enabled = false;
            this.listSubscription.FormattingEnabled = true;
            this.listSubscription.Location = new System.Drawing.Point(591, 53);
            this.listSubscription.Name = "listSubscription";
            this.listSubscription.Size = new System.Drawing.Size(227, 290);
            this.listSubscription.TabIndex = 14;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 396);
            this.Controls.Add(this.listSubscription);
            this.Controls.Add(this.Tag);
            this.Controls.Add(this.listTag);
            this.Controls.Add(this.Subscription);
            this.Controls.Add(this.Text_for_chat);
            this.Controls.Add(this.messageData);
            this.Controls.Add(this.list_of_users);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.nicknameData);
            this.Controls.Add(this.Entering_a_nickname);
            this.Controls.Add(this.connection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connection;
        private System.Windows.Forms.Label Entering_a_nickname;
        private System.Windows.Forms.TextBox nicknameData;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Label Chat;
        private System.Windows.Forms.Label list_of_users;
        private System.Windows.Forms.TextBox messageData;
        private System.Windows.Forms.ContextMenuStrip userMenu;
        private System.Windows.Forms.Label Text_for_chat;
        private System.Windows.Forms.Label Subscription;
        private System.Windows.Forms.ListBox listTag;
        private System.Windows.Forms.Label Tag;
        private System.Windows.Forms.ListBox listSubscription;
    }
}

