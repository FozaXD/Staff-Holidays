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
            this.mainCalendar = new System.Windows.Forms.MonthCalendar();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.staffIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holidayCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeStaffButton = new System.Windows.Forms.Button();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.reuse = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.staffContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
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
            this.staffDataGridView.Location = new System.Drawing.Point(19, 491);
            this.staffDataGridView.MultiSelect = false;
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.ReadOnly = true;
            this.staffDataGridView.RowHeadersVisible = false;
            this.staffDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffDataGridView.Size = new System.Drawing.Size(345, 171);
            this.staffDataGridView.TabIndex = 11;
            this.staffDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.staffDataGridView_CellMouseDown);
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
            this.staffNameColumn.FillWeight = 50F;
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
            this.staffTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.staffTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // holidayCountColumn
            // 
            this.holidayCountColumn.FillWeight = 20F;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(730, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Account:";
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLabel.ForeColor = System.Drawing.Color.White;
            this.accountNameLabel.Location = new System.Drawing.Point(817, -2);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(106, 21);
            this.accountNameLabel.TabIndex = 23;
            this.accountNameLabel.Text = "accountname";
            // 
            // staffContextMenu
            // 
            this.staffContextMenu.Name = "staffContextMenu";
            this.staffContextMenu.Size = new System.Drawing.Size(61, 4);
            this.staffContextMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.staffContextMenu_MouseClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(959, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.reuse);
            this.Controls.Add(this.staffDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mainCalendar;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.Button removeStaffButton;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.CheckBox reuse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holidayCountColumn;
        private System.Windows.Forms.ContextMenuStrip staffContextMenu;
    }
}

