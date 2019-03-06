using HospitalManagement.DAL;
using System.Data.SqlClient;
namespace HospitalManagement
{
    partial class addEmpUserPanel
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
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox11 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.startTime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.dateObirth = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.designationComboBox = new System.Windows.Forms.ComboBox();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.personalTextBox = new MetroFramework.Controls.MetroTextBox();
            this.homeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.officeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.genderTextBox = new MetroFramework.Controls.MetroTextBox();
            this.lastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.firstNameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.usernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox6 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox7 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox8 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox12 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox13 = new MetroFramework.Controls.MetroTextBox();
            this.empIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.selectedPanel = new MetroFramework.Controls.MetroPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(642, 298);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(46, 21);
            this.comboBox5.TabIndex = 77;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(523, 294);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(113, 25);
            this.metroLabel13.TabIndex = 76;
            this.metroLabel13.Text = "Room/Ward:";
            // 
            // metroTextBox11
            // 
            // 
            // 
            // 
            this.metroTextBox11.CustomButton.Image = null;
            this.metroTextBox11.CustomButton.Location = new System.Drawing.Point(44, 2);
            this.metroTextBox11.CustomButton.Name = "";
            this.metroTextBox11.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.metroTextBox11.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox11.CustomButton.TabIndex = 1;
            this.metroTextBox11.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox11.CustomButton.UseSelectable = true;
            this.metroTextBox11.CustomButton.Visible = false;
            this.metroTextBox11.Lines = new string[0];
            this.metroTextBox11.Location = new System.Drawing.Point(642, 334);
            this.metroTextBox11.MaxLength = 32767;
            this.metroTextBox11.Name = "metroTextBox11";
            this.metroTextBox11.PasswordChar = '\0';
            this.metroTextBox11.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox11.SelectedText = "";
            this.metroTextBox11.SelectionLength = 0;
            this.metroTextBox11.SelectionStart = 0;
            this.metroTextBox11.ShortcutsEnabled = true;
            this.metroTextBox11.Size = new System.Drawing.Size(142, 100);
            this.metroTextBox11.TabIndex = 75;
            this.metroTextBox11.UseSelectable = true;
            this.metroTextBox11.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox11.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(555, 333);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(81, 25);
            this.metroLabel12.TabIndex = 74;
            this.metroLabel12.Text = "Address:";
            // 
            // metroTextBox8
            // 
            // 
            // 
            // 
            this.metroTextBox8.CustomButton.Image = null;
            this.metroTextBox8.CustomButton.Location = new System.Drawing.Point(34, 2);
            this.metroTextBox8.CustomButton.Name = "";
            this.metroTextBox8.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.metroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox8.CustomButton.TabIndex = 1;
            this.metroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox8.CustomButton.UseSelectable = true;
            this.metroTextBox8.CustomButton.Visible = false;
            this.metroTextBox8.Lines = new string[0];
            this.metroTextBox8.Location = new System.Drawing.Point(642, 255);
            this.metroTextBox8.MaxLength = 32767;
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.PasswordChar = '\0';
            this.metroTextBox8.PromptText = "5.00";
            this.metroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox8.SelectedText = "";
            this.metroTextBox8.SelectionLength = 0;
            this.metroTextBox8.SelectionStart = 0;
            this.metroTextBox8.ShortcutsEnabled = true;
            this.metroTextBox8.Size = new System.Drawing.Size(52, 20);
            this.metroTextBox8.TabIndex = 73;
            this.metroTextBox8.UseSelectable = true;
            this.metroTextBox8.WaterMark = "5.00";
            this.metroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // startTime
            // 
            // 
            // 
            // 
            this.startTime.CustomButton.Image = null;
            this.startTime.CustomButton.Location = new System.Drawing.Point(34, 2);
            this.startTime.CustomButton.Name = "";
            this.startTime.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.startTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.startTime.CustomButton.TabIndex = 1;
            this.startTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.startTime.CustomButton.UseSelectable = true;
            this.startTime.CustomButton.Visible = false;
            this.startTime.Lines = new string[0];
            this.startTime.Location = new System.Drawing.Point(642, 227);
            this.startTime.MaxLength = 32767;
            this.startTime.Name = "startTime";
            this.startTime.PasswordChar = '\0';
            this.startTime.PromptText = "9.00";
            this.startTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.startTime.SelectedText = "";
            this.startTime.SelectionLength = 0;
            this.startTime.SelectionStart = 0;
            this.startTime.ShortcutsEnabled = true;
            this.startTime.Size = new System.Drawing.Size(52, 20);
            this.startTime.TabIndex = 72;
            this.startTime.UseSelectable = true;
            this.startTime.WaterMark = "9.00";
            this.startTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.startTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(590, 250);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(46, 25);
            this.metroLabel11.TabIndex = 71;
            this.metroLabel11.Text = "End:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(584, 222);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(52, 25);
            this.metroLabel10.TabIndex = 70;
            this.metroLabel10.Text = "Start:";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(645, 499);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(112, 41);
            this.metroButton2.TabIndex = 69;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            // 
            // dateObirth
            // 
            this.dateObirth.Location = new System.Drawing.Point(322, 235);
            this.dateObirth.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateObirth.Name = "dateObirth";
            this.dateObirth.Size = new System.Drawing.Size(148, 29);
            this.dateObirth.TabIndex = 68;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(205, 239);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(116, 25);
            this.metroLabel9.TabIndex = 67;
            this.metroLabel9.Text = "Date of Birth:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(482, 499);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 41);
            this.metroButton1.TabIndex = 66;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // designationComboBox
            // 
            this.designationComboBox.FormattingEnabled = true;
            this.designationComboBox.Items.AddRange(new object[] {
            "Doctor",
            "Supervisor"});
            this.designationComboBox.Location = new System.Drawing.Point(642, 102);
            this.designationComboBox.Name = "designationComboBox";
            this.designationComboBox.Size = new System.Drawing.Size(142, 21);
            this.designationComboBox.TabIndex = 61;
            this.designationComboBox.SelectedIndexChanged += new System.EventHandler(this.designationComboBox_SelectedIndexChanged);
            // 
            // metroTextBox7
            // 
            // 
            // 
            // 
            this.metroTextBox7.CustomButton.Image = null;
            this.metroTextBox7.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.metroTextBox7.CustomButton.Name = "";
            this.metroTextBox7.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox7.CustomButton.TabIndex = 1;
            this.metroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox7.CustomButton.UseSelectable = true;
            this.metroTextBox7.CustomButton.Visible = false;
            this.metroTextBox7.Lines = new string[0];
            this.metroTextBox7.Location = new System.Drawing.Point(970, 98);
            this.metroTextBox7.MaxLength = 32767;
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.PasswordChar = '\0';
            this.metroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox7.SelectedText = "";
            this.metroTextBox7.SelectionLength = 0;
            this.metroTextBox7.SelectionStart = 0;
            this.metroTextBox7.ShortcutsEnabled = true;
            this.metroTextBox7.Size = new System.Drawing.Size(148, 29);
            this.metroTextBox7.TabIndex = 60;
            this.metroTextBox7.UseSelectable = true;
            this.metroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // personalTextBox
            // 
            // 
            // 
            // 
            this.personalTextBox.CustomButton.Image = null;
            this.personalTextBox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.personalTextBox.CustomButton.Name = "";
            this.personalTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.personalTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.personalTextBox.CustomButton.TabIndex = 1;
            this.personalTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.personalTextBox.CustomButton.UseSelectable = true;
            this.personalTextBox.CustomButton.Visible = false;
            this.personalTextBox.Lines = new string[0];
            this.personalTextBox.Location = new System.Drawing.Point(322, 383);
            this.personalTextBox.MaxLength = 32767;
            this.personalTextBox.Name = "personalTextBox";
            this.personalTextBox.PasswordChar = '\0';
            this.personalTextBox.PromptText = "Personal";
            this.personalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.personalTextBox.SelectedText = "";
            this.personalTextBox.SelectionLength = 0;
            this.personalTextBox.SelectionStart = 0;
            this.personalTextBox.ShortcutsEnabled = true;
            this.personalTextBox.Size = new System.Drawing.Size(148, 29);
            this.personalTextBox.TabIndex = 59;
            this.personalTextBox.UseSelectable = true;
            this.personalTextBox.WaterMark = "Personal";
            this.personalTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.personalTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // homeTextBox
            // 
            // 
            // 
            // 
            this.homeTextBox.CustomButton.Image = null;
            this.homeTextBox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.homeTextBox.CustomButton.Name = "";
            this.homeTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.homeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.homeTextBox.CustomButton.TabIndex = 1;
            this.homeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.homeTextBox.CustomButton.UseSelectable = true;
            this.homeTextBox.CustomButton.Visible = false;
            this.homeTextBox.Lines = new string[0];
            this.homeTextBox.Location = new System.Drawing.Point(322, 346);
            this.homeTextBox.MaxLength = 32767;
            this.homeTextBox.Name = "homeTextBox";
            this.homeTextBox.PasswordChar = '\0';
            this.homeTextBox.PromptText = "Home";
            this.homeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.homeTextBox.SelectedText = "";
            this.homeTextBox.SelectionLength = 0;
            this.homeTextBox.SelectionStart = 0;
            this.homeTextBox.ShortcutsEnabled = true;
            this.homeTextBox.Size = new System.Drawing.Size(148, 29);
            this.homeTextBox.TabIndex = 58;
            this.homeTextBox.UseSelectable = true;
            this.homeTextBox.WaterMark = "Home";
            this.homeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.homeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // officeTextBox
            // 
            // 
            // 
            // 
            this.officeTextBox.CustomButton.Image = null;
            this.officeTextBox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.officeTextBox.CustomButton.Name = "";
            this.officeTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.officeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.officeTextBox.CustomButton.TabIndex = 1;
            this.officeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.officeTextBox.CustomButton.UseSelectable = true;
            this.officeTextBox.CustomButton.Visible = false;
            this.officeTextBox.Lines = new string[0];
            this.officeTextBox.Location = new System.Drawing.Point(322, 310);
            this.officeTextBox.MaxLength = 32767;
            this.officeTextBox.Name = "officeTextBox";
            this.officeTextBox.PasswordChar = '\0';
            this.officeTextBox.PromptText = "Office";
            this.officeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.officeTextBox.SelectedText = "";
            this.officeTextBox.SelectionLength = 0;
            this.officeTextBox.SelectionStart = 0;
            this.officeTextBox.ShortcutsEnabled = true;
            this.officeTextBox.Size = new System.Drawing.Size(148, 29);
            this.officeTextBox.TabIndex = 57;
            this.officeTextBox.UseSelectable = true;
            this.officeTextBox.WaterMark = "Office";
            this.officeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.officeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // genderTextBox
            // 
            // 
            // 
            // 
            this.genderTextBox.CustomButton.Image = null;
            this.genderTextBox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.genderTextBox.CustomButton.Name = "";
            this.genderTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.genderTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.genderTextBox.CustomButton.TabIndex = 1;
            this.genderTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.genderTextBox.CustomButton.UseSelectable = true;
            this.genderTextBox.CustomButton.Visible = false;
            this.genderTextBox.Lines = new string[0];
            this.genderTextBox.Location = new System.Drawing.Point(322, 274);
            this.genderTextBox.MaxLength = 32767;
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.PasswordChar = '\0';
            this.genderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.genderTextBox.SelectedText = "";
            this.genderTextBox.SelectionLength = 0;
            this.genderTextBox.SelectionStart = 0;
            this.genderTextBox.ShortcutsEnabled = true;
            this.genderTextBox.Size = new System.Drawing.Size(148, 29);
            this.genderTextBox.TabIndex = 56;
            this.genderTextBox.UseSelectable = true;
            this.genderTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.genderTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lastNameTextBox
            // 
            // 
            // 
            // 
            this.lastNameTextBox.CustomButton.Image = null;
            this.lastNameTextBox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.lastNameTextBox.CustomButton.Name = "";
            this.lastNameTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.lastNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastNameTextBox.CustomButton.TabIndex = 1;
            this.lastNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastNameTextBox.CustomButton.UseSelectable = true;
            this.lastNameTextBox.CustomButton.Visible = false;
            this.lastNameTextBox.Lines = new string[0];
            this.lastNameTextBox.Location = new System.Drawing.Point(322, 201);
            this.lastNameTextBox.MaxLength = 32767;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.SelectionLength = 0;
            this.lastNameTextBox.SelectionStart = 0;
            this.lastNameTextBox.ShortcutsEnabled = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(148, 29);
            this.lastNameTextBox.TabIndex = 55;
            this.lastNameTextBox.UseSelectable = true;
            this.lastNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // firstNameTextbox
            // 
            // 
            // 
            // 
            this.firstNameTextbox.CustomButton.Image = null;
            this.firstNameTextbox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.firstNameTextbox.CustomButton.Name = "";
            this.firstNameTextbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.firstNameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstNameTextbox.CustomButton.TabIndex = 1;
            this.firstNameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstNameTextbox.CustomButton.UseSelectable = true;
            this.firstNameTextbox.CustomButton.Visible = false;
            this.firstNameTextbox.Lines = new string[0];
            this.firstNameTextbox.Location = new System.Drawing.Point(322, 165);
            this.firstNameTextbox.MaxLength = 32767;
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.PasswordChar = '\0';
            this.firstNameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameTextbox.SelectedText = "";
            this.firstNameTextbox.SelectionLength = 0;
            this.firstNameTextbox.SelectionStart = 0;
            this.firstNameTextbox.ShortcutsEnabled = true;
            this.firstNameTextbox.Size = new System.Drawing.Size(148, 29);
            this.firstNameTextbox.TabIndex = 54;
            this.firstNameTextbox.UseSelectable = true;
            this.firstNameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstNameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // usernameTextBox
            // 
            // 
            // 
            // 
            this.usernameTextBox.CustomButton.Image = null;
            this.usernameTextBox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.usernameTextBox.CustomButton.Name = "";
            this.usernameTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.usernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameTextBox.CustomButton.TabIndex = 1;
            this.usernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextBox.CustomButton.UseSelectable = true;
            this.usernameTextBox.CustomButton.Visible = false;
            this.usernameTextBox.Lines = new string[0];
            this.usernameTextBox.Location = new System.Drawing.Point(322, 130);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.SelectionLength = 0;
            this.usernameTextBox.SelectionStart = 0;
            this.usernameTextBox.ShortcutsEnabled = true;
            this.usernameTextBox.Size = new System.Drawing.Size(148, 29);
            this.usernameTextBox.TabIndex = 53;
            this.usernameTextBox.UseSelectable = true;
            this.usernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(539, 134);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(97, 25);
            this.metroLabel8.TabIndex = 52;
            this.metroLabel8.Text = "Duty Time:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(525, 97);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(111, 25);
            this.metroLabel7.TabIndex = 51;
            this.metroLabel7.Text = "Designation:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(906, 98);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 25);
            this.metroLabel6.TabIndex = 50;
            this.metroLabel6.Text = "Email:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(226, 134);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 25);
            this.metroLabel5.TabIndex = 49;
            this.metroLabel5.Text = "Username:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(255, 315);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 25);
            this.metroLabel4.TabIndex = 48;
            this.metroLabel4.Text = "Phone:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(248, 278);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 25);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "Gender:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(222, 205);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 25);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Last Name:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(220, 171);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 25);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "First Name:";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(87, 39);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(193, 25);
            this.metroLabel14.TabIndex = 78;
            this.metroLabel14.Text = "Add a New Employee";
            // 
            // metroCheckBox6
            // 
            this.metroCheckBox6.AutoSize = true;
            this.metroCheckBox6.Location = new System.Drawing.Point(642, 197);
            this.metroCheckBox6.Name = "metroCheckBox6";
            this.metroCheckBox6.Size = new System.Drawing.Size(39, 15);
            this.metroCheckBox6.TabIndex = 85;
            this.metroCheckBox6.Text = "Sat";
            this.metroCheckBox6.UseSelectable = true;
            // 
            // metroCheckBox7
            // 
            this.metroCheckBox7.AutoSize = true;
            this.metroCheckBox7.Location = new System.Drawing.Point(706, 177);
            this.metroCheckBox7.Name = "metroCheckBox7";
            this.metroCheckBox7.Size = new System.Drawing.Size(36, 15);
            this.metroCheckBox7.TabIndex = 84;
            this.metroCheckBox7.Text = "Fri";
            this.metroCheckBox7.UseSelectable = true;
            // 
            // metroCheckBox8
            // 
            this.metroCheckBox8.AutoSize = true;
            this.metroCheckBox8.Location = new System.Drawing.Point(642, 176);
            this.metroCheckBox8.Name = "metroCheckBox8";
            this.metroCheckBox8.Size = new System.Drawing.Size(46, 15);
            this.metroCheckBox8.TabIndex = 83;
            this.metroCheckBox8.Text = "Thrs";
            this.metroCheckBox8.UseSelectable = true;
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Location = new System.Drawing.Point(706, 155);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(47, 15);
            this.metroCheckBox4.TabIndex = 82;
            this.metroCheckBox4.Text = "Wed";
            this.metroCheckBox4.UseSelectable = true;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Location = new System.Drawing.Point(642, 155);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(43, 15);
            this.metroCheckBox3.TabIndex = 81;
            this.metroCheckBox3.Text = "Tue";
            this.metroCheckBox3.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(706, 135);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(48, 15);
            this.metroCheckBox2.TabIndex = 80;
            this.metroCheckBox2.Text = "Mon";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(642, 134);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(43, 15);
            this.metroCheckBox1.TabIndex = 79;
            this.metroCheckBox1.Text = "Sun";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(873, 135);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(91, 25);
            this.metroLabel15.TabIndex = 86;
            this.metroLabel15.Text = "Password:";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(804, 171);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(160, 25);
            this.metroLabel16.TabIndex = 87;
            this.metroLabel16.Text = "Confirm Password:";
            // 
            // metroTextBox12
            // 
            // 
            // 
            // 
            this.metroTextBox12.CustomButton.Image = null;
            this.metroTextBox12.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.metroTextBox12.CustomButton.Name = "";
            this.metroTextBox12.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox12.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox12.CustomButton.TabIndex = 1;
            this.metroTextBox12.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox12.CustomButton.UseSelectable = true;
            this.metroTextBox12.CustomButton.Visible = false;
            this.metroTextBox12.Lines = new string[0];
            this.metroTextBox12.Location = new System.Drawing.Point(970, 171);
            this.metroTextBox12.MaxLength = 32767;
            this.metroTextBox12.Name = "metroTextBox12";
            this.metroTextBox12.PasswordChar = '*';
            this.metroTextBox12.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox12.SelectedText = "";
            this.metroTextBox12.SelectionLength = 0;
            this.metroTextBox12.SelectionStart = 0;
            this.metroTextBox12.ShortcutsEnabled = true;
            this.metroTextBox12.Size = new System.Drawing.Size(148, 29);
            this.metroTextBox12.TabIndex = 89;
            this.metroTextBox12.UseSelectable = true;
            this.metroTextBox12.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox12.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox13
            // 
            // 
            // 
            // 
            this.metroTextBox13.CustomButton.Image = null;
            this.metroTextBox13.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.metroTextBox13.CustomButton.Name = "";
            this.metroTextBox13.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox13.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox13.CustomButton.TabIndex = 1;
            this.metroTextBox13.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox13.CustomButton.UseSelectable = true;
            this.metroTextBox13.CustomButton.Visible = false;
            this.metroTextBox13.Lines = new string[0];
            this.metroTextBox13.Location = new System.Drawing.Point(970, 135);
            this.metroTextBox13.MaxLength = 32767;
            this.metroTextBox13.Name = "metroTextBox13";
            this.metroTextBox13.PasswordChar = '*';
            this.metroTextBox13.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox13.SelectedText = "";
            this.metroTextBox13.SelectionLength = 0;
            this.metroTextBox13.SelectionStart = 0;
            this.metroTextBox13.ShortcutsEnabled = true;
            this.metroTextBox13.Size = new System.Drawing.Size(148, 29);
            this.metroTextBox13.TabIndex = 88;
            this.metroTextBox13.UseSelectable = true;
            this.metroTextBox13.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox13.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // empIdTextBox
            // 
            // 
            // 
            // 
            this.empIdTextBox.CustomButton.Image = null;
            this.empIdTextBox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.empIdTextBox.CustomButton.Name = "";
            this.empIdTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.empIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empIdTextBox.CustomButton.TabIndex = 1;
            this.empIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empIdTextBox.CustomButton.UseSelectable = true;
            this.empIdTextBox.CustomButton.Visible = false;
            this.empIdTextBox.Lines = new string[0];
            this.empIdTextBox.Location = new System.Drawing.Point(322, 93);
            this.empIdTextBox.MaxLength = 32767;
            this.empIdTextBox.Name = "empIdTextBox";
            this.empIdTextBox.PasswordChar = '\0';
            this.empIdTextBox.ReadOnly = true;
            this.empIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empIdTextBox.SelectedText = "";
            this.empIdTextBox.SelectionLength = 0;
            this.empIdTextBox.SelectionStart = 0;
            this.empIdTextBox.ShortcutsEnabled = true;
            this.empIdTextBox.Size = new System.Drawing.Size(148, 29);
            this.empIdTextBox.TabIndex = 91;
            this.empIdTextBox.UseSelectable = true;
            this.empIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.Location = new System.Drawing.Point(204, 97);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(117, 25);
            this.metroLabel17.TabIndex = 90;
            this.metroLabel17.Text = "Employee ID:";
            // 
            // selectedPanel
            // 
            this.selectedPanel.HorizontalScrollbarBarColor = true;
            this.selectedPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.selectedPanel.HorizontalScrollbarSize = 10;
            this.selectedPanel.Location = new System.Drawing.Point(804, 206);
            this.selectedPanel.Name = "selectedPanel";
            this.selectedPanel.Size = new System.Drawing.Size(314, 256);
            this.selectedPanel.TabIndex = 92;
            this.selectedPanel.VerticalScrollbarBarColor = true;
            this.selectedPanel.VerticalScrollbarHighlightOnWheel = false;
            this.selectedPanel.VerticalScrollbarSize = 10;
            this.selectedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.selectedPanel_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(700, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 21);
            this.comboBox1.TabIndex = 77;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(700, 255);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(46, 21);
            this.comboBox2.TabIndex = 77;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // addEmpUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.selectedPanel);
            this.Controls.Add(this.empIdTextBox);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroTextBox12);
            this.Controls.Add(this.metroTextBox13);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroCheckBox6);
            this.Controls.Add(this.metroCheckBox7);
            this.Controls.Add(this.metroCheckBox8);
            this.Controls.Add(this.metroCheckBox4);
            this.Controls.Add(this.metroCheckBox3);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroTextBox11);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroTextBox8);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.dateObirth);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.designationComboBox);
            this.Controls.Add(this.metroTextBox7);
            this.Controls.Add(this.personalTextBox);
            this.Controls.Add(this.homeTextBox);
            this.Controls.Add(this.officeTextBox);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "addEmpUserPanel";
            this.Size = new System.Drawing.Size(1148, 552);
            this.Load += new System.EventHandler(this.addEmpUserPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox5;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox metroTextBox11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroTextBox startTime;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroDateTime dateObirth;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ComboBox designationComboBox;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroTextBox personalTextBox;
        private MetroFramework.Controls.MetroTextBox homeTextBox;
        private MetroFramework.Controls.MetroTextBox officeTextBox;
        private MetroFramework.Controls.MetroTextBox genderTextBox;
        private MetroFramework.Controls.MetroTextBox lastNameTextBox;
        private MetroFramework.Controls.MetroTextBox firstNameTextbox;
        private MetroFramework.Controls.MetroTextBox usernameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox7;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox8;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBox12;
        private MetroFramework.Controls.MetroTextBox metroTextBox13;
        private MetroFramework.Controls.MetroTextBox empIdTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel17;


        private void addEmp()
        {

        }

        private MetroFramework.Controls.MetroPanel selectedPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
