namespace Client
{
    partial class AddFriend
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.phone = new System.Windows.Forms.TextBox();
            this.goToRegisterBtn = new FontAwesome.Sharp.IconButton();
            this.loginBtn = new FontAwesome.Sharp.IconButton();
            this.createGroupLb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Location = new System.Drawing.Point(82, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 45);
            this.panel1.TabIndex = 13;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton3.Enabled = false;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconButton3.IconColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(0, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(44, 43);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // phone
            // 
            this.phone.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.phone.Location = new System.Drawing.Point(50, 6);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(187, 29);
            this.phone.TabIndex = 2;
            // 
            // goToRegisterBtn
            // 
            this.goToRegisterBtn.BackColor = System.Drawing.Color.White;
            this.goToRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToRegisterBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.goToRegisterBtn.IconColor = System.Drawing.Color.Black;
            this.goToRegisterBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToRegisterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.goToRegisterBtn.Location = new System.Drawing.Point(82, 226);
            this.goToRegisterBtn.Name = "goToRegisterBtn";
            this.goToRegisterBtn.Size = new System.Drawing.Size(109, 38);
            this.goToRegisterBtn.TabIndex = 15;
            this.goToRegisterBtn.Text = "Cancel";
            this.goToRegisterBtn.UseVisualStyleBackColor = false;
            this.goToRegisterBtn.Click += new System.EventHandler(this.goToRegisterBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(159)))));
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.loginBtn.IconColor = System.Drawing.Color.Black;
            this.loginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBtn.Location = new System.Drawing.Point(223, 226);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(109, 38);
            this.loginBtn.TabIndex = 14;
            this.loginBtn.Text = "Add";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // createGroupLb
            // 
            this.createGroupLb.AutoSize = true;
            this.createGroupLb.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createGroupLb.Location = new System.Drawing.Point(82, 74);
            this.createGroupLb.Name = "createGroupLb";
            this.createGroupLb.Size = new System.Drawing.Size(189, 47);
            this.createGroupLb.TabIndex = 16;
            this.createGroupLb.Text = "New friend";
            // 
            // AddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(430, 365);
            this.Controls.Add(this.createGroupLb);
            this.Controls.Add(this.goToRegisterBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddFriend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a new friend";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private TextBox phone;
        private FontAwesome.Sharp.IconButton goToRegisterBtn;
        private FontAwesome.Sharp.IconButton loginBtn;
        private Label createGroupLb;
    }
}