﻿namespace StaffHolidays
{
    partial class StartupWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupWindow));
            this.existingAccountButton = new System.Windows.Forms.Button();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // existingAccountButton
            // 
            this.existingAccountButton.BackColor = System.Drawing.Color.Silver;
            this.existingAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.existingAccountButton.ForeColor = System.Drawing.Color.White;
            this.existingAccountButton.Image = ((System.Drawing.Image)(resources.GetObject("existingAccountButton.Image")));
            this.existingAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.existingAccountButton.Location = new System.Drawing.Point(174, 53);
            this.existingAccountButton.Name = "existingAccountButton";
            this.existingAccountButton.Size = new System.Drawing.Size(123, 53);
            this.existingAccountButton.TabIndex = 3;
            this.existingAccountButton.Text = "Existing Account";
            this.existingAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.existingAccountButton.UseVisualStyleBackColor = false;
            this.existingAccountButton.Click += new System.EventHandler(this.existingAccountButton_Click);
            // 
            // newAccountButton
            // 
            this.newAccountButton.BackColor = System.Drawing.Color.Silver;
            this.newAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newAccountButton.ForeColor = System.Drawing.Color.White;
            this.newAccountButton.Image = ((System.Drawing.Image)(resources.GetObject("newAccountButton.Image")));
            this.newAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newAccountButton.Location = new System.Drawing.Point(29, 53);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(119, 53);
            this.newAccountButton.TabIndex = 2;
            this.newAccountButton.Text = "New Account";
            this.newAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newAccountButton.UseVisualStyleBackColor = false;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // StartupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(326, 158);
            this.Controls.Add(this.existingAccountButton);
            this.Controls.Add(this.newAccountButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartupWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button existingAccountButton;
        private System.Windows.Forms.Button newAccountButton;
    }
}