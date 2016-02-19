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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainCalendar = new System.Windows.Forms.MonthCalendar();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.staffIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holidayCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeStaffButton = new System.Windows.Forms.Button();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.reuse = new System.Windows.Forms.CheckBox();
            this.staffContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.indiStaffHoliDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.removeHoliday = new System.Windows.Forms.Button();
            this.addHoliday = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indiStaffHoliDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCalendar
            // 
            this.mainCalendar.CalendarDimensions = new System.Drawing.Size(4, 3);
            this.mainCalendar.Location = new System.Drawing.Point(19, 19);
            this.mainCalendar.Name = "mainCalendar";
            this.mainCalendar.TabIndex = 0;
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AllowUserToAddRows = false;
            this.staffDataGridView.AllowUserToDeleteRows = false;
            this.staffDataGridView.AllowUserToOrderColumns = true;
            this.staffDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIdColumn,
            this.staffNameColumn,
            this.staffTypeColumn,
            this.holidayCountColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.staffDataGridView.EnableHeadersVisualStyles = false;
            this.staffDataGridView.Location = new System.Drawing.Point(951, 41);
            this.staffDataGridView.MultiSelect = false;
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.ReadOnly = true;
            this.staffDataGridView.RowHeadersVisible = false;
            this.staffDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffDataGridView.Size = new System.Drawing.Size(332, 400);
            this.staffDataGridView.TabIndex = 11;
            this.staffDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.staffDataGridView_CellMouseDown);
            this.staffDataGridView.SelectionChanged += new System.EventHandler(this.staffDataGridView_SelectionChanged);
            this.staffDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.staffDataGridView_MouseClick);
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
            this.staffTypeColumn.FillWeight = 20F;
            this.staffTypeColumn.HeaderText = "Type";
            this.staffTypeColumn.Name = "staffTypeColumn";
            this.staffTypeColumn.ReadOnly = true;
            this.staffTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.staffTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // holidayCountColumn
            // 
            this.holidayCountColumn.FillWeight = 5F;
            this.holidayCountColumn.HeaderText = "Holiday Count";
            this.holidayCountColumn.MinimumWidth = 100;
            this.holidayCountColumn.Name = "holidayCountColumn";
            this.holidayCountColumn.ReadOnly = true;
            // 
            // removeStaffButton
            // 
            this.removeStaffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeStaffButton.BackColor = System.Drawing.Color.Silver;
            this.removeStaffButton.Enabled = false;
            this.removeStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStaffButton.ForeColor = System.Drawing.Color.White;
            this.removeStaffButton.Image = ((System.Drawing.Image)(resources.GetObject("removeStaffButton.Image")));
            this.removeStaffButton.Location = new System.Drawing.Point(989, 447);
            this.removeStaffButton.Name = "removeStaffButton";
            this.removeStaffButton.Size = new System.Drawing.Size(32, 32);
            this.removeStaffButton.TabIndex = 10;
            this.removeStaffButton.UseVisualStyleBackColor = false;
            this.removeStaffButton.Click += new System.EventHandler(this.removeStaffButton_Click);
            // 
            // addStaffButton
            // 
            this.addStaffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addStaffButton.BackColor = System.Drawing.Color.Silver;
            this.addStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStaffButton.ForeColor = System.Drawing.Color.White;
            this.addStaffButton.Image = ((System.Drawing.Image)(resources.GetObject("addStaffButton.Image")));
            this.addStaffButton.Location = new System.Drawing.Point(951, 447);
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
            this.reuse.Location = new System.Drawing.Point(1185, 13);
            this.reuse.Name = "reuse";
            this.reuse.Size = new System.Drawing.Size(98, 17);
            this.reuse.TabIndex = 22;
            this.reuse.Text = "Stay Logged In";
            this.reuse.UseVisualStyleBackColor = true;
            // 
            // staffContextMenu
            // 
            this.staffContextMenu.Name = "staffContextMenu";
            this.staffContextMenu.Size = new System.Drawing.Size(61, 4);
            this.staffContextMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.staffContextMenu_MouseClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(948, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "&Staff:";
            // 
            // indiStaffHoliDataGridView
            // 
            this.indiStaffHoliDataGridView.AllowUserToAddRows = false;
            this.indiStaffHoliDataGridView.AllowUserToDeleteRows = false;
            this.indiStaffHoliDataGridView.AllowUserToOrderColumns = true;
            this.indiStaffHoliDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indiStaffHoliDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.indiStaffHoliDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.indiStaffHoliDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.indiStaffHoliDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.indiStaffHoliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indiStaffHoliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.startColumn,
            this.endColumn,
            this.countColumn,
            this.reasonColumn,
            this.approvedColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.indiStaffHoliDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.indiStaffHoliDataGridView.EnableHeadersVisualStyles = false;
            this.indiStaffHoliDataGridView.Location = new System.Drawing.Point(19, 491);
            this.indiStaffHoliDataGridView.MultiSelect = false;
            this.indiStaffHoliDataGridView.Name = "indiStaffHoliDataGridView";
            this.indiStaffHoliDataGridView.ReadOnly = true;
            this.indiStaffHoliDataGridView.RowHeadersVisible = false;
            this.indiStaffHoliDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.indiStaffHoliDataGridView.Size = new System.Drawing.Size(920, 307);
            this.indiStaffHoliDataGridView.TabIndex = 26;
            // 
            // idColumn
            // 
            this.idColumn.FillWeight = 5F;
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // startColumn
            // 
            this.startColumn.FillWeight = 10F;
            this.startColumn.HeaderText = "Day Off - Start";
            this.startColumn.MinimumWidth = 15;
            this.startColumn.Name = "startColumn";
            this.startColumn.ReadOnly = true;
            this.startColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.startColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // endColumn
            // 
            this.endColumn.FillWeight = 10F;
            this.endColumn.HeaderText = "Day Off - End";
            this.endColumn.MinimumWidth = 15;
            this.endColumn.Name = "endColumn";
            this.endColumn.ReadOnly = true;
            this.endColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.endColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // countColumn
            // 
            this.countColumn.FillWeight = 10F;
            this.countColumn.HeaderText = "Days Off - Count";
            this.countColumn.MinimumWidth = 15;
            this.countColumn.Name = "countColumn";
            this.countColumn.ReadOnly = true;
            // 
            // reasonColumn
            // 
            this.reasonColumn.FillWeight = 55F;
            this.reasonColumn.HeaderText = "Reason";
            this.reasonColumn.MinimumWidth = 50;
            this.reasonColumn.Name = "reasonColumn";
            this.reasonColumn.ReadOnly = true;
            // 
            // approvedColumn
            // 
            this.approvedColumn.FillWeight = 10F;
            this.approvedColumn.HeaderText = "Approved";
            this.approvedColumn.Name = "approvedColumn";
            this.approvedColumn.ReadOnly = true;
            // 
            // removeHoliday
            // 
            this.removeHoliday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeHoliday.BackColor = System.Drawing.Color.Silver;
            this.removeHoliday.Enabled = false;
            this.removeHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeHoliday.ForeColor = System.Drawing.Color.White;
            this.removeHoliday.Image = ((System.Drawing.Image)(resources.GetObject("removeHoliday.Image")));
            this.removeHoliday.Location = new System.Drawing.Point(951, 766);
            this.removeHoliday.Name = "removeHoliday";
            this.removeHoliday.Size = new System.Drawing.Size(32, 32);
            this.removeHoliday.TabIndex = 28;
            this.removeHoliday.UseVisualStyleBackColor = false;
            this.removeHoliday.Click += new System.EventHandler(this.removeHoliday_Click);
            // 
            // addHoliday
            // 
            this.addHoliday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addHoliday.BackColor = System.Drawing.Color.Silver;
            this.addHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addHoliday.ForeColor = System.Drawing.Color.White;
            this.addHoliday.Image = ((System.Drawing.Image)(resources.GetObject("addHoliday.Image")));
            this.addHoliday.Location = new System.Drawing.Point(951, 728);
            this.addHoliday.Name = "addHoliday";
            this.addHoliday.Size = new System.Drawing.Size(32, 32);
            this.addHoliday.TabIndex = 27;
            this.addHoliday.UseVisualStyleBackColor = false;
            this.addHoliday.Click += new System.EventHandler(this.addHoliday_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1296, 811);
            this.Controls.Add(this.removeHoliday);
            this.Controls.Add(this.addHoliday);
            this.Controls.Add(this.indiStaffHoliDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reuse);
            this.Controls.Add(this.staffDataGridView);
            this.Controls.Add(this.removeStaffButton);
            this.Controls.Add(this.addStaffButton);
            this.Controls.Add(this.mainCalendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1312, 850);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Holidays";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indiStaffHoliDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mainCalendar;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.Button removeStaffButton;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.CheckBox reuse;
        private System.Windows.Forms.ContextMenuStrip staffContextMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holidayCountColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView indiStaffHoliDataGridView;
        private System.Windows.Forms.Button removeHoliday;
        private System.Windows.Forms.Button addHoliday;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn approvedColumn;
    }
}

