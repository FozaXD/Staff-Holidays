namespace StaffHolidays
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainCalendar = new System.Windows.Forms.MonthCalendar();
            this.yearlyDataGridView = new System.Windows.Forms.DataGridView();
            this.staffIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.removeStaffButton = new System.Windows.Forms.Button();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.reuse = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCalendar
            // 
            this.mainCalendar.CalendarDimensions = new System.Drawing.Size(4, 3);
            this.mainCalendar.Location = new System.Drawing.Point(19, 19);
            this.mainCalendar.Name = "mainCalendar";
            this.mainCalendar.TabIndex = 0;
            // 
            // yearlyDataGridView
            // 
            this.yearlyDataGridView.AllowUserToAddRows = false;
            this.yearlyDataGridView.AllowUserToDeleteRows = false;
            this.yearlyDataGridView.AllowUserToOrderColumns = true;
            this.yearlyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yearlyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.yearlyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearlyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yearlyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.yearlyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yearlyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIdColumn,
            this.staffNameColumn,
            this.staffTypeColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.yearlyDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.yearlyDataGridView.EnableHeadersVisualStyles = false;
            this.yearlyDataGridView.Location = new System.Drawing.Point(19, 491);
            this.yearlyDataGridView.MultiSelect = false;
            this.yearlyDataGridView.Name = "yearlyDataGridView";
            this.yearlyDataGridView.ReadOnly = true;
            this.yearlyDataGridView.RowHeadersVisible = false;
            this.yearlyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.yearlyDataGridView.Size = new System.Drawing.Size(345, 171);
            this.yearlyDataGridView.TabIndex = 11;
            // 
            // staffIdColumn
            // 
            this.staffIdColumn.FillWeight = 5F;
            this.staffIdColumn.HeaderText = "Id";
            this.staffIdColumn.MinimumWidth = 25;
            this.staffIdColumn.Name = "staffIdColumn";
            this.staffIdColumn.ReadOnly = true;
            this.staffIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // staffNameColumn
            // 
            this.staffNameColumn.FillWeight = 70F;
            this.staffNameColumn.HeaderText = "Name";
            this.staffNameColumn.MinimumWidth = 100;
            this.staffNameColumn.Name = "staffNameColumn";
            this.staffNameColumn.ReadOnly = true;
            this.staffNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.staffNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // staffTypeColumn
            // 
            this.staffTypeColumn.FillWeight = 25F;
            this.staffTypeColumn.HeaderText = "Type";
            this.staffTypeColumn.Name = "staffTypeColumn";
            this.staffTypeColumn.ReadOnly = true;
            // 
            // removeStaffButton
            // 
            this.removeStaffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeStaffButton.BackColor = System.Drawing.Color.Silver;
            this.removeStaffButton.Enabled = false;
            this.removeStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStaffButton.ForeColor = System.Drawing.Color.White;
            this.removeStaffButton.Image = ((System.Drawing.Image)(resources.GetObject("removeStaffButton.Image")));
            this.removeStaffButton.Location = new System.Drawing.Point(370, 529);
            this.removeStaffButton.Name = "removeStaffButton";
            this.removeStaffButton.Size = new System.Drawing.Size(32, 32);
            this.removeStaffButton.TabIndex = 10;
            this.removeStaffButton.UseVisualStyleBackColor = false;
            // 
            // addStaffButton
            // 
            this.addStaffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addStaffButton.BackColor = System.Drawing.Color.Silver;
            this.addStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStaffButton.ForeColor = System.Drawing.Color.White;
            this.addStaffButton.Image = ((System.Drawing.Image)(resources.GetObject("addStaffButton.Image")));
            this.addStaffButton.Location = new System.Drawing.Point(370, 491);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(32, 32);
            this.addStaffButton.TabIndex = 9;
            this.addStaffButton.UseVisualStyleBackColor = false;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // reuse
            // 
            this.reuse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reuse.AutoSize = true;
            this.reuse.ForeColor = System.Drawing.Color.White;
            this.reuse.Location = new System.Drawing.Point(848, 645);
            this.reuse.Name = "reuse";
            this.reuse.Size = new System.Drawing.Size(98, 17);
            this.reuse.TabIndex = 22;
            this.reuse.Text = "Stay Logged In";
            this.reuse.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(959, 675);
            this.Controls.Add(this.reuse);
            this.Controls.Add(this.yearlyDataGridView);
            this.Controls.Add(this.removeStaffButton);
            this.Controls.Add(this.addStaffButton);
            this.Controls.Add(this.mainCalendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Holidays";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.yearlyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mainCalendar;
        private System.Windows.Forms.DataGridView yearlyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn staffTypeColumn;
        private System.Windows.Forms.Button removeStaffButton;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.CheckBox reuse;
    }
}

