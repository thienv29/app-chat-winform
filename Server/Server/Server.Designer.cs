﻿namespace Server
{
    partial class Server
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
            this.IP = new System.Windows.Forms.TextBox();
            this.KQServer = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IP
            // 
            this.IP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.IP.Location = new System.Drawing.Point(39, 45);
            this.IP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Size = new System.Drawing.Size(252, 23);
            this.IP.TabIndex = 0;
            // 
            // KQServer
            // 
            this.KQServer.Location = new System.Drawing.Point(39, 102);
            this.KQServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KQServer.Multiline = true;
            this.KQServer.Name = "KQServer";
            this.KQServer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.KQServer.Size = new System.Drawing.Size(386, 161);
            this.KQServer.TabIndex = 1;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(312, 44);
            this.Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(82, 22);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Start";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 284);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.KQServer);
            this.Controls.Add(this.IP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox IP;
        private TextBox KQServer;
        private Button Connect;
    }
}