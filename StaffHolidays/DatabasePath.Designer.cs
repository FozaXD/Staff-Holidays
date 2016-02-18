namespace StaffHolidays
{
    partial class DatabasePath
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabasePath));
            this.tick = new System.Windows.Forms.PictureBox();
            this.setDataPathButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseFilePathTextBox = new System.Windows.Forms.TextBox();
            this.errorProviderDataPath = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDataPath)).BeginInit();
            this.SuspendLayout();
            // 
            // tick
            // 
            this.tick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.tick.Enabled = false;
            this.tick.Image = ((System.Drawing.Image)(resources.GetObject("tick.Image")));
            this.tick.InitialImage = null;
            this.tick.Location = new System.Drawing.Point(13, 26);
            this.tick.Name = "tick";
            this.tick.Size = new System.Drawing.Size(27, 23);
            this.tick.TabIndex = 9;
            this.tick.TabStop = false;
            this.tick.Visible = false;
            // 
            // setDataPathButton
            // 
            this.setDataPathButton.BackColor = System.Drawing.Color.Silver;
            this.setDataPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setDataPathButton.ForeColor = System.Drawing.Color.White;
            this.setDataPathButton.Location = new System.Drawing.Point(279, 53);
            this.setDataPathButton.Name = "setDataPathButton";
            this.setDataPathButton.Size = new System.Drawing.Size(65, 23);
            this.setDataPathButton.TabIndex = 8;
            this.setDataPathButton.Text = "Set";
            this.setDataPathButton.UseVisualStyleBackColor = false;
            this.setDataPathButton.Click += new System.EventHandler(this.setDataPathButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.BackColor = System.Drawing.Color.Silver;
            this.openFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileButton.ForeColor = System.Drawing.Color.White;
            this.openFileButton.Location = new System.Drawing.Point(279, 25);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(65, 22);
            this.openFileButton.TabIndex = 6;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please select the database location:";
            // 
            // databaseFilePathTextBox
            // 
            this.databaseFilePathTextBox.Location = new System.Drawing.Point(46, 26);
            this.databaseFilePathTextBox.Name = "databaseFilePathTextBox";
            this.databaseFilePathTextBox.Size = new System.Drawing.Size(227, 20);
            this.databaseFilePathTextBox.TabIndex = 5;
            this.databaseFilePathTextBox.TextChanged += new System.EventHandler(this.databaseFilePathTextBox_TextChanged);
            // 
            // errorProviderDataPath
            // 
            this.errorProviderDataPath.ContainerControl = this;
            this.errorProviderDataPath.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderDataPath.Icon")));
            // 
            // DatabasePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(356, 87);
            this.Controls.Add(this.tick);
            this.Controls.Add(this.setDataPathButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.databaseFilePathTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabasePath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Path";
            ((System.ComponentModel.ISupportInitialize)(this.tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDataPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tick;
        private System.Windows.Forms.Button setDataPathButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox databaseFilePathTextBox;
        private System.Windows.Forms.ErrorProvider errorProviderDataPath;
    }
}