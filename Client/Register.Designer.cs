namespace Client
{
    partial class Register
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
            this.registerBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.goToLoginBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.confirmPassTxt = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(159)))));
            this.registerBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.registerBtn.IconColor = System.Drawing.Color.Black;
            this.registerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerBtn.Location = new System.Drawing.Point(85, 422);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(250, 38);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Submit";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.firstNameTxt);
            this.panel1.Location = new System.Drawing.Point(85, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 45);
            this.panel1.TabIndex = 6;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton3.Enabled = false;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton3.IconColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(0, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(44, 43);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.firstNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.firstNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTxt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTxt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.firstNameTxt.Location = new System.Drawing.Point(50, 5);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.PlaceholderText = "First name";
            this.firstNameTxt.Size = new System.Drawing.Size(187, 29);
            this.firstNameTxt.TabIndex = 2;
            this.firstNameTxt.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // goToLoginBtn
            // 
            this.goToLoginBtn.BackColor = System.Drawing.Color.White;
            this.goToLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToLoginBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.goToLoginBtn.IconColor = System.Drawing.Color.Black;
            this.goToLoginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToLoginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.goToLoginBtn.Location = new System.Drawing.Point(363, 422);
            this.goToLoginBtn.Name = "goToLoginBtn";
            this.goToLoginBtn.Size = new System.Drawing.Size(250, 38);
            this.goToLoginBtn.TabIndex = 7;
            this.goToLoginBtn.Text = "Login";
            this.goToLoginBtn.UseVisualStyleBackColor = false;
            this.goToLoginBtn.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.iconButton4);
            this.panel2.Controls.Add(this.passwordTxt);
            this.panel2.Location = new System.Drawing.Point(85, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 45);
            this.panel2.TabIndex = 7;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton4.Enabled = false;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton4.IconColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(0, 0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(44, 43);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // passwordTxt
            // 
            this.passwordTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.passwordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.passwordTxt.Location = new System.Drawing.Point(50, 5);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.Size = new System.Drawing.Size(187, 29);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(86, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 5);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.iconButton5);
            this.panel4.Controls.Add(this.lastNameTxt);
            this.panel4.Location = new System.Drawing.Point(363, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 45);
            this.panel4.TabIndex = 7;
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton5.Enabled = false;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton5.IconColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.Location = new System.Drawing.Point(0, 0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(44, 43);
            this.iconButton5.TabIndex = 3;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lastNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.lastNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTxt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTxt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lastNameTxt.Location = new System.Drawing.Point(50, 6);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.PlaceholderText = "Last name";
            this.lastNameTxt.Size = new System.Drawing.Size(187, 29);
            this.lastNameTxt.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.iconButton6);
            this.panel5.Controls.Add(this.confirmPassTxt);
            this.panel5.Location = new System.Drawing.Point(364, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 45);
            this.panel5.TabIndex = 8;
            // 
            // iconButton6
            // 
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton6.Enabled = false;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton6.IconColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 30;
            this.iconButton6.Location = new System.Drawing.Point(0, 0);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(44, 43);
            this.iconButton6.TabIndex = 3;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // confirmPassTxt
            // 
            this.confirmPassTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.confirmPassTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.confirmPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPassTxt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPassTxt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.confirmPassTxt.Location = new System.Drawing.Point(50, 5);
            this.confirmPassTxt.Name = "confirmPassTxt";
            this.confirmPassTxt.PlaceholderText = "Confirm password";
            this.confirmPassTxt.Size = new System.Drawing.Size(187, 29);
            this.confirmPassTxt.TabIndex = 2;
            this.confirmPassTxt.UseSystemPasswordChar = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.iconButton7);
            this.panel6.Controls.Add(this.phoneTxt);
            this.panel6.Location = new System.Drawing.Point(363, 208);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 45);
            this.panel6.TabIndex = 9;
            // 
            // iconButton7
            // 
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton7.Enabled = false;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconButton7.IconColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 30;
            this.iconButton7.Location = new System.Drawing.Point(0, 0);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(44, 43);
            this.iconButton7.TabIndex = 3;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // phoneTxt
            // 
            this.phoneTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.phoneTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.phoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTxt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneTxt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.phoneTxt.Location = new System.Drawing.Point(50, 6);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PlaceholderText = "Phone";
            this.phoneTxt.Size = new System.Drawing.Size(187, 29);
            this.phoneTxt.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.emailTxt);
            this.panel7.Controls.Add(this.iconButton8);
            this.panel7.Location = new System.Drawing.Point(85, 208);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 45);
            this.panel7.TabIndex = 8;
            // 
            // emailTxt
            // 
            this.emailTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.emailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(197)))), ((int)(((byte)(213)))));
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTxt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.emailTxt.Location = new System.Drawing.Point(50, 5);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PlaceholderText = "Email";
            this.emailTxt.Size = new System.Drawing.Size(187, 29);
            this.emailTxt.TabIndex = 2;
            // 
            // iconButton8
            // 
            this.iconButton8.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton8.Enabled = false;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton8.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 30;
            this.iconButton8.Location = new System.Drawing.Point(0, 0);
            this.iconButton8.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(44, 43);
            this.iconButton8.TabIndex = 3;
            this.iconButton8.Text = "@";
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(694, 517);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.goToLoginBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerBtn);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton registerBtn;
        private Label label1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private TextBox firstNameTxt;
        private FontAwesome.Sharp.IconButton goToLoginBtn;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox passwordTxt;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private TextBox lastNameTxt;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private TextBox confirmPassTxt;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton iconButton7;
        private TextBox phoneTxt;
        private Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton8;
        private TextBox emailTxt;
    }
}