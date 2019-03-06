namespace HospitalManagement
{
    partial class viewEmployeeUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.doctorTabPage = new MetroFramework.Controls.MetroTabControl();
            this.empPageTab = new MetroFramework.Controls.MetroTabPage();
            this.empGrid = new MetroFramework.Controls.MetroGrid();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet = new HospitalManagement.EmployeeDataSet();
            this.doctorTabPg = new MetroFramework.Controls.MetroTabPage();
            this.refreshEmpQryToolStrip = new System.Windows.Forms.ToolStrip();
            this.refreshEmpQryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.employeeTableAdapter = new HospitalManagement.EmployeeDataSetTableAdapters.employeeTableAdapter();
            this.roomwardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonehomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonepersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneofficeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorTabPage.SuspendLayout();
            this.empPageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            this.refreshEmpQryToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorTabPage
            // 
            this.doctorTabPage.Controls.Add(this.empPageTab);
            this.doctorTabPage.Controls.Add(this.doctorTabPg);
            this.doctorTabPage.Location = new System.Drawing.Point(0, 28);
            this.doctorTabPage.Name = "doctorTabPage";
            this.doctorTabPage.SelectedIndex = 0;
            this.doctorTabPage.Size = new System.Drawing.Size(1086, 647);
            this.doctorTabPage.TabIndex = 0;
            this.doctorTabPage.UseSelectable = true;
            // 
            // empPageTab
            // 
            this.empPageTab.AutoScroll = true;
            this.empPageTab.Controls.Add(this.empGrid);
            this.empPageTab.HorizontalScrollbar = true;
            this.empPageTab.HorizontalScrollbarBarColor = true;
            this.empPageTab.HorizontalScrollbarHighlightOnWheel = false;
            this.empPageTab.HorizontalScrollbarSize = 10;
            this.empPageTab.Location = new System.Drawing.Point(4, 38);
            this.empPageTab.Name = "empPageTab";
            this.empPageTab.Size = new System.Drawing.Size(1078, 605);
            this.empPageTab.TabIndex = 0;
            this.empPageTab.Text = "Employee";
            this.empPageTab.VerticalScrollbar = true;
            this.empPageTab.VerticalScrollbarBarColor = true;
            this.empPageTab.VerticalScrollbarHighlightOnWheel = false;
            this.empPageTab.VerticalScrollbarSize = 10;
            // 
            // empGrid
            // 
            this.empGrid.AllowUserToAddRows = false;
            this.empGrid.AllowUserToResizeRows = false;
            this.empGrid.AutoGenerateColumns = false;
            this.empGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.empGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.empGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.empGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.dateofBirthDataGridViewTextBoxColumn,
            this.joindateDataGridViewTextBoxColumn,
            this.phoneofficeDataGridViewTextBoxColumn,
            this.phonepersonalDataGridViewTextBoxColumn,
            this.phonehomeDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.roomwardDataGridViewTextBoxColumn});
            this.empGrid.DataSource = this.employeeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.empGrid.EnableHeadersVisualStyles = false;
            this.empGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.empGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.empGrid.Location = new System.Drawing.Point(-43, 3);
            this.empGrid.Name = "empGrid";
            this.empGrid.ReadOnly = true;
            this.empGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.empGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.empGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empGrid.Size = new System.Drawing.Size(1145, 538);
            this.empGrid.TabIndex = 2;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.employeeDataSet;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTabPg
            // 
            this.doctorTabPg.HorizontalScrollbarBarColor = true;
            this.doctorTabPg.HorizontalScrollbarHighlightOnWheel = false;
            this.doctorTabPg.HorizontalScrollbarSize = 10;
            this.doctorTabPg.Location = new System.Drawing.Point(4, 38);
            this.doctorTabPg.Name = "doctorTabPg";
            this.doctorTabPg.Size = new System.Drawing.Size(1078, 605);
            this.doctorTabPg.TabIndex = 1;
            this.doctorTabPg.Text = "Doctor";
            this.doctorTabPg.VerticalScrollbarBarColor = true;
            this.doctorTabPg.VerticalScrollbarHighlightOnWheel = false;
            this.doctorTabPg.VerticalScrollbarSize = 10;
            // 
            // refreshEmpQryToolStrip
            // 
            this.refreshEmpQryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshEmpQryToolStripButton});
            this.refreshEmpQryToolStrip.Location = new System.Drawing.Point(0, 0);
            this.refreshEmpQryToolStrip.Name = "refreshEmpQryToolStrip";
            this.refreshEmpQryToolStrip.Size = new System.Drawing.Size(1218, 25);
            this.refreshEmpQryToolStrip.TabIndex = 1;
            this.refreshEmpQryToolStrip.Text = "refreshEmpQryToolStrip";
            // 
            // refreshEmpQryToolStripButton
            // 
            this.refreshEmpQryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshEmpQryToolStripButton.Name = "refreshEmpQryToolStripButton";
            this.refreshEmpQryToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.refreshEmpQryToolStripButton.Text = "Refresh";
            this.refreshEmpQryToolStripButton.Click += new System.EventHandler(this.refreshEmpQryToolStripButton_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // roomwardDataGridViewTextBoxColumn
            // 
            this.roomwardDataGridViewTextBoxColumn.DataPropertyName = "room/ward";
            this.roomwardDataGridViewTextBoxColumn.HeaderText = "Room/Ward";
            this.roomwardDataGridViewTextBoxColumn.Name = "roomwardDataGridViewTextBoxColumn";
            this.roomwardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonehomeDataGridViewTextBoxColumn
            // 
            this.phonehomeDataGridViewTextBoxColumn.DataPropertyName = "phone_home";
            this.phonehomeDataGridViewTextBoxColumn.HeaderText = "Home Phone";
            this.phonehomeDataGridViewTextBoxColumn.Name = "phonehomeDataGridViewTextBoxColumn";
            this.phonehomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonepersonalDataGridViewTextBoxColumn
            // 
            this.phonepersonalDataGridViewTextBoxColumn.DataPropertyName = "phone_personal";
            this.phonepersonalDataGridViewTextBoxColumn.HeaderText = "Personal Phone";
            this.phonepersonalDataGridViewTextBoxColumn.Name = "phonepersonalDataGridViewTextBoxColumn";
            this.phonepersonalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneofficeDataGridViewTextBoxColumn
            // 
            this.phoneofficeDataGridViewTextBoxColumn.DataPropertyName = "phone_office";
            this.phoneofficeDataGridViewTextBoxColumn.HeaderText = "Office Phone";
            this.phoneofficeDataGridViewTextBoxColumn.Name = "phoneofficeDataGridViewTextBoxColumn";
            this.phoneofficeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // joindateDataGridViewTextBoxColumn
            // 
            this.joindateDataGridViewTextBoxColumn.DataPropertyName = "join_date";
            this.joindateDataGridViewTextBoxColumn.HeaderText = "Join Date";
            this.joindateDataGridViewTextBoxColumn.Name = "joindateDataGridViewTextBoxColumn";
            this.joindateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofBirthDataGridViewTextBoxColumn
            // 
            this.dateofBirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_Birth";
            this.dateofBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dateofBirthDataGridViewTextBoxColumn.Name = "dateofBirthDataGridViewTextBoxColumn";
            this.dateofBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "Employee ID";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewEmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshEmpQryToolStrip);
            this.Controls.Add(this.doctorTabPage);
            this.Name = "viewEmployeeUC";
            this.Size = new System.Drawing.Size(1218, 693);
            this.doctorTabPage.ResumeLayout(false);
            this.empPageTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            this.refreshEmpQryToolStrip.ResumeLayout(false);
            this.refreshEmpQryToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl doctorTabPage;
        private MetroFramework.Controls.MetroTabPage empPageTab;
        private MetroFramework.Controls.MetroGrid empGrid;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeDataSet employeeDataSet;
        private EmployeeDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.ToolStrip refreshEmpQryToolStrip;
        private System.Windows.Forms.ToolStripButton refreshEmpQryToolStripButton;
        private MetroFramework.Controls.MetroTabPage doctorTabPg;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneofficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonepersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonehomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomwardDataGridViewTextBoxColumn;

    }
}
