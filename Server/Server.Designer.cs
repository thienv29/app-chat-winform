namespace Server
{
    partial class FormChat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
            this.SideBar = new System.Windows.Forms.Panel();
            this.pnListFriends = new System.Windows.Forms.Panel();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.borderBottomSearchPn = new System.Windows.Forms.Panel();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.pnForInputSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btn_addContact = new FontAwesome.Sharp.IconButton();
            this.avatarIML = new System.Windows.Forms.ImageList(this.components);
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnOnRightBar = new FontAwesome.Sharp.IconButton();
            this.pnSend = new System.Windows.Forms.Panel();
            this.pnSendText = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.iconSend = new FontAwesome.Sharp.IconButton();
            this.iconSendImage = new FontAwesome.Sharp.IconButton();
            this.iconSendFile = new FontAwesome.Sharp.IconButton();
            this.iconAddIcon = new FontAwesome.Sharp.IconButton();
            this.pnListMessage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.pnBorderForCenter = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.pnListFriends.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnForInputSearch.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.pnSend.SuspendLayout();
            this.pnSendText.SuspendLayout();
            this.pnListMessage.SuspendLayout();
            this.pnCenter.SuspendLayout();
            this.pnBorderForCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.White;
            this.SideBar.Controls.Add(this.pnListFriends);
            this.SideBar.Controls.Add(this.pnSearch);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(257, 722);
            this.SideBar.TabIndex = 0;
            // 
            // pnListFriends
            // 
            this.pnListFriends.Controls.Add(this.flpMain);
            this.pnListFriends.Controls.Add(this.borderBottomSearchPn);
            this.pnListFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnListFriends.Location = new System.Drawing.Point(0, 60);
            this.pnListFriends.Name = "pnListFriends";
            this.pnListFriends.Size = new System.Drawing.Size(257, 662);
            this.pnListFriends.TabIndex = 1;
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.Location = new System.Drawing.Point(0, 1);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(257, 661);
            this.flpMain.TabIndex = 1;
            // 
            // borderBottomSearchPn
            // 
            this.borderBottomSearchPn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(159)))));
            this.borderBottomSearchPn.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderBottomSearchPn.Location = new System.Drawing.Point(0, 0);
            this.borderBottomSearchPn.Name = "borderBottomSearchPn";
            this.borderBottomSearchPn.Size = new System.Drawing.Size(257, 1);
            this.borderBottomSearchPn.TabIndex = 0;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.pnForInputSearch);
            this.pnSearch.Controls.Add(this.btn_addContact);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(257, 60);
            this.pnSearch.TabIndex = 0;
            // 
            // pnForInputSearch
            // 
            this.pnForInputSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.pnForInputSearch.CausesValidation = false;
            this.pnForInputSearch.Controls.Add(this.txtSearch);
            this.pnForInputSearch.Location = new System.Drawing.Point(66, 12);
            this.pnForInputSearch.Name = "pnForInputSearch";
            this.pnForInputSearch.Size = new System.Drawing.Size(178, 35);
            this.pnForInputSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.Location = new System.Drawing.Point(12, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.Size = new System.Drawing.Size(156, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btn_addContact
            // 
            this.btn_addContact.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_addContact.FlatAppearance.BorderSize = 0;
            this.btn_addContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addContact.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_addContact.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.btn_addContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_addContact.IconSize = 36;
            this.btn_addContact.Location = new System.Drawing.Point(0, 0);
            this.btn_addContact.Name = "btn_addContact";
            this.btn_addContact.Size = new System.Drawing.Size(60, 60);
            this.btn_addContact.TabIndex = 0;
            this.btn_addContact.UseVisualStyleBackColor = true;
            this.btn_addContact.Click += new System.EventHandler(this.btn_addContact_Click_1);
            // 
            // avatarIML
            // 
            this.avatarIML.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.avatarIML.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("avatarIML.ImageStream")));
            this.avatarIML.TransparentColor = System.Drawing.Color.Transparent;
            this.avatarIML.Images.SetKeyName(0, "378-3780189_member-icon-png-transparent-png.png");
            this.avatarIML.Images.SetKeyName(1, "png-clipart-users-group-computer-icons-membership-miscellaneous-user-interface-de" +
        "sign-thumbnail.png");
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.White;
            this.pnHeader.Controls.Add(this.btnOnRightBar);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(757, 60);
            this.pnHeader.TabIndex = 1;
            // 
            // btnOnRightBar
            // 
            this.btnOnRightBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOnRightBar.FlatAppearance.BorderSize = 0;
            this.btnOnRightBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnRightBar.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnOnRightBar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnOnRightBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOnRightBar.IconSize = 36;
            this.btnOnRightBar.Location = new System.Drawing.Point(696, 0);
            this.btnOnRightBar.Name = "btnOnRightBar";
            this.btnOnRightBar.Size = new System.Drawing.Size(61, 60);
            this.btnOnRightBar.TabIndex = 0;
            this.btnOnRightBar.UseVisualStyleBackColor = true;
            this.btnOnRightBar.Click += new System.EventHandler(this.btnOnRightBar_Click);
            // 
            // pnSend
            // 
            this.pnSend.BackColor = System.Drawing.Color.White;
            this.pnSend.Controls.Add(this.pnSendText);
            this.pnSend.Controls.Add(this.iconSend);
            this.pnSend.Controls.Add(this.iconSendImage);
            this.pnSend.Controls.Add(this.iconSendFile);
            this.pnSend.Controls.Add(this.iconAddIcon);
            this.pnSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSend.Location = new System.Drawing.Point(0, 674);
            this.pnSend.Name = "pnSend";
            this.pnSend.Size = new System.Drawing.Size(757, 48);
            this.pnSend.TabIndex = 2;
            // 
            // pnSendText
            // 
            this.pnSendText.Controls.Add(this.txtMessage);
            this.pnSendText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSendText.Location = new System.Drawing.Point(183, 0);
            this.pnSendText.Name = "pnSendText";
            this.pnSendText.Padding = new System.Windows.Forms.Padding(9);
            this.pnSendText.Size = new System.Drawing.Size(513, 48);
            this.pnSendText.TabIndex = 5;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMessage.Location = new System.Drawing.Point(9, 9);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PlaceholderText = "Write a message...";
            this.txtMessage.Size = new System.Drawing.Size(495, 25);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // iconSend
            // 
            this.iconSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconSend.FlatAppearance.BorderSize = 0;
            this.iconSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconSend.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.iconSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSend.IconSize = 38;
            this.iconSend.Location = new System.Drawing.Point(696, 0);
            this.iconSend.Name = "iconSend";
            this.iconSend.Size = new System.Drawing.Size(61, 48);
            this.iconSend.TabIndex = 4;
            this.iconSend.UseVisualStyleBackColor = true;
            this.iconSend.Click += new System.EventHandler(this.iconSend_Click);
            // 
            // iconSendImage
            // 
            this.iconSendImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconSendImage.FlatAppearance.BorderSize = 0;
            this.iconSendImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSendImage.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconSendImage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.iconSendImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSendImage.IconSize = 38;
            this.iconSendImage.Location = new System.Drawing.Point(122, 0);
            this.iconSendImage.Name = "iconSendImage";
            this.iconSendImage.Size = new System.Drawing.Size(61, 48);
            this.iconSendImage.TabIndex = 2;
            this.iconSendImage.UseVisualStyleBackColor = true;
            // 
            // iconSendFile
            // 
            this.iconSendFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconSendFile.FlatAppearance.BorderSize = 0;
            this.iconSendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSendFile.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.iconSendFile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.iconSendFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSendFile.IconSize = 38;
            this.iconSendFile.Location = new System.Drawing.Point(61, 0);
            this.iconSendFile.Name = "iconSendFile";
            this.iconSendFile.Size = new System.Drawing.Size(61, 48);
            this.iconSendFile.TabIndex = 1;
            this.iconSendFile.UseVisualStyleBackColor = true;
            // 
            // iconAddIcon
            // 
            this.iconAddIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconAddIcon.FlatAppearance.BorderSize = 0;
            this.iconAddIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAddIcon.IconChar = FontAwesome.Sharp.IconChar.Smile;
            this.iconAddIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.iconAddIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAddIcon.IconSize = 38;
            this.iconAddIcon.Location = new System.Drawing.Point(0, 0);
            this.iconAddIcon.Name = "iconAddIcon";
            this.iconAddIcon.Size = new System.Drawing.Size(61, 48);
            this.iconAddIcon.TabIndex = 0;
            this.iconAddIcon.UseVisualStyleBackColor = true;
            // 
            // pnListMessage
            // 
            this.pnListMessage.AutoScroll = true;
            this.pnListMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.pnListMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnListMessage.Controls.Add(this.panel1);
            this.pnListMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnListMessage.Location = new System.Drawing.Point(0, 60);
            this.pnListMessage.Name = "pnListMessage";
            this.pnListMessage.Size = new System.Drawing.Size(757, 614);
            this.pnListMessage.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 10);
            this.panel1.TabIndex = 0;
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.White;
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(1016, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(265, 722);
            this.pnRight.TabIndex = 4;
            // 
            // pnCenter
            // 
            this.pnCenter.Controls.Add(this.pnListMessage);
            this.pnCenter.Controls.Add(this.pnHeader);
            this.pnCenter.Controls.Add(this.pnSend);
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnCenter.Location = new System.Drawing.Point(1, 0);
            this.pnCenter.Margin = new System.Windows.Forms.Padding(0);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(757, 722);
            this.pnCenter.TabIndex = 5;
            // 
            // pnBorderForCenter
            // 
            this.pnBorderForCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(159)))));
            this.pnBorderForCenter.Controls.Add(this.pnCenter);
            this.pnBorderForCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBorderForCenter.Location = new System.Drawing.Point(257, 0);
            this.pnBorderForCenter.Name = "pnBorderForCenter";
            this.pnBorderForCenter.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.pnBorderForCenter.Size = new System.Drawing.Size(759, 722);
            this.pnBorderForCenter.TabIndex = 6;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 722);
            this.Controls.Add(this.pnBorderForCenter);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.SideBar);
            this.Name = "FormChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppChatServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChat_FormClosed);
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.SideBar.ResumeLayout(false);
            this.pnListFriends.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnForInputSearch.ResumeLayout(false);
            this.pnForInputSearch.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.pnSend.ResumeLayout(false);
            this.pnSendText.ResumeLayout(false);
            this.pnSendText.PerformLayout();
            this.pnListMessage.ResumeLayout(false);
            this.pnCenter.ResumeLayout(false);
            this.pnBorderForCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SideBar;
        private Panel pnSearch;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btn_addContact;
        private Panel pnForInputSearch;
        private Panel pnListFriends;
        private Panel borderBottomSearchPn;
        private Panel pnHeader;
        private Panel pnSend;
        private Panel pnListMessage;
        private FontAwesome.Sharp.IconButton iconSendImage;
        private FontAwesome.Sharp.IconButton iconSendFile;
        private FontAwesome.Sharp.IconButton iconAddIcon;
        private Panel pnSendText;
        private FontAwesome.Sharp.IconButton iconSend;
        private TextBox txtMessage;
        private FontAwesome.Sharp.IconButton btnOnRightBar;
        private Panel pnRight;
        private Panel pnCenter;
        private Panel pnBorderForCenter;
        private ImageList avatarIML;
        private FlowLayoutPanel flpMain;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
    }
}