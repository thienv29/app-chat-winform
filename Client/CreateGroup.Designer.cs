namespace Client
{
    partial class CreateGroup
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
            this.listViewBanBeTaoNhom = new System.Windows.Forms.ListView();
            this.createGroupLb = new System.Windows.Forms.Label();
            this.loginBtn = new FontAwesome.Sharp.IconButton();
            this.goToRegisterBtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupName = new System.Windows.Forms.TextBox();
            //toolTip1.SetToolTip(listViewBanBeTaoNhom, "Select member for add to group (multiple)");

            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBanBeTaoNhom
            // 
            this.listViewBanBeTaoNhom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.listViewBanBeTaoNhom.CheckBoxes = true;
            this.listViewBanBeTaoNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewBanBeTaoNhom.FullRowSelect = true;
            this.listViewBanBeTaoNhom.Location = new System.Drawing.Point(76, 188);
            this.listViewBanBeTaoNhom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewBanBeTaoNhom.Name = "listViewBanBeTaoNhom";
            this.listViewBanBeTaoNhom.Size = new System.Drawing.Size(289, 245);
            this.listViewBanBeTaoNhom.TabIndex = 7;
            this.listViewBanBeTaoNhom.UseCompatibleStateImageBehavior = false;
            this.listViewBanBeTaoNhom.View = System.Windows.Forms.View.SmallIcon;
            // 
            // createGroupLb
            // 
            this.createGroupLb.AutoSize = true;
            this.createGroupLb.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createGroupLb.Location = new System.Drawing.Point(76, 59);
            this.createGroupLb.Name = "createGroupLb";
            this.createGroupLb.Size = new System.Drawing.Size(225, 47);
            this.createGroupLb.TabIndex = 9;
            this.createGroupLb.Text = "Create group";
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
            this.loginBtn.Location = new System.Drawing.Point(256, 462);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(109, 38);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "Create";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.ThemNhom_Click);
            // 
            // goToRegisterBtn
            // 
            this.goToRegisterBtn.BackColor = System.Drawing.Color.White;
            this.goToRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToRegisterBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.goToRegisterBtn.IconColor = System.Drawing.Color.Black;
            this.goToRegisterBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToRegisterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.goToRegisterBtn.Location = new System.Drawing.Point(76, 462);
            this.goToRegisterBtn.Name = "goToRegisterBtn";
            this.goToRegisterBtn.Size = new System.Drawing.Size(109, 38);
            this.goToRegisterBtn.TabIndex = 11;
            this.goToRegisterBtn.Text = "Cancel";
            this.goToRegisterBtn.UseVisualStyleBackColor = false;
            this.goToRegisterBtn.Click += new System.EventHandler(this.ThoatFormTaoNhom_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupName);
            this.panel1.Location = new System.Drawing.Point(76, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 45);
            this.panel1.TabIndex = 12;
            // 
            // groupName
            // 
            this.groupName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.groupName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupName.Location = new System.Drawing.Point(13, 7);
            this.groupName.Name = "groupName";
            this.groupName.PlaceholderText = "Group name";
            this.groupName.Size = new System.Drawing.Size(261, 29);
            this.groupName.TabIndex = 2;
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(445, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goToRegisterBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.createGroupLb);
            this.Controls.Add(this.listViewBanBeTaoNhom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create group";
            this.Load += new System.EventHandler(this.CreateGroup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView listViewBanBeTaoNhom;
        private Label createGroupLb;
        private FontAwesome.Sharp.IconButton loginBtn;
        private FontAwesome.Sharp.IconButton goToRegisterBtn;
        private Panel panel1;
        private TextBox groupName;
        private ToolTip toolTip1;
    }
}