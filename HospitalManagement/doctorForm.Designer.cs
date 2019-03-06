namespace HospitalManagement
{
    partial class doctorForm
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
            this.MainPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnNotification = new MetroFramework.Controls.MetroButton();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.myAccountButton = new MetroFramework.Controls.MetroButton();
            this.btnSettings = new MetroFramework.Controls.MetroButton();
            this.patirntHistoryButton = new MetroFramework.Controls.MetroButton();
            this.btnProfile = new MetroFramework.Controls.MetroButton();
            this.btnAddEmployee = new MetroFramework.Controls.MetroButton();
            this.upper = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 10;
            this.MainPanel.Location = new System.Drawing.Point(175, 118);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1151, 555);
            this.MainPanel.TabIndex = 11;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.DimGray;
            this.metroPanel1.Controls.Add(this.txtSearch);
            this.metroPanel1.Controls.Add(this.btnLogout);
            this.metroPanel1.Controls.Add(this.btnNotification);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(318, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(675, 70);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(165, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(313, 14);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(193, 30);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(549, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 50);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LOG&OUT";
            this.btnLogout.UseSelectable = true;
            // 
            // btnNotification
            // 
            this.btnNotification.Location = new System.Drawing.Point(164, 4);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(100, 50);
            this.btnNotification.TabIndex = 0;
            this.btnNotification.Text = "&NOTIFICATION(0)";
            this.btnNotification.UseSelectable = true;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.myAccountButton);
            this.metroPanel4.Controls.Add(this.btnSettings);
            this.metroPanel4.Controls.Add(this.patirntHistoryButton);
            this.metroPanel4.Controls.Add(this.btnProfile);
            this.metroPanel4.Controls.Add(this.btnAddEmployee);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(2, 96);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(147, 531);
            this.metroPanel4.TabIndex = 10;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // myAccountButton
            // 
            this.myAccountButton.Location = new System.Drawing.Point(13, 271);
            this.myAccountButton.Name = "myAccountButton";
            this.myAccountButton.Size = new System.Drawing.Size(120, 45);
            this.myAccountButton.TabIndex = 12;
            this.myAccountButton.Text = "My Account";
            this.myAccountButton.UseSelectable = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(13, 355);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(120, 45);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseSelectable = true;
            // 
            // patirntHistoryButton
            // 
            this.patirntHistoryButton.Location = new System.Drawing.Point(13, 189);
            this.patirntHistoryButton.Name = "patirntHistoryButton";
            this.patirntHistoryButton.Size = new System.Drawing.Size(120, 45);
            this.patirntHistoryButton.TabIndex = 10;
            this.patirntHistoryButton.Text = "Patient History";
            this.patirntHistoryButton.UseSelectable = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(13, 22);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(120, 45);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseSelectable = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(13, 107);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(120, 45);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Today\'s Apointment";
            this.btnAddEmployee.UseSelectable = true;
            // 
            // upper
            // 
            this.upper.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.upper.HorizontalScrollbarBarColor = true;
            this.upper.HorizontalScrollbarHighlightOnWheel = false;
            this.upper.HorizontalScrollbarSize = 10;
            this.upper.Location = new System.Drawing.Point(2, 52);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(316, 43);
            this.upper.TabIndex = 9;
            this.upper.VerticalScrollbarBarColor = true;
            this.upper.VerticalScrollbarHighlightOnWheel = false;
            this.upper.VerticalScrollbarSize = 10;
            // 
            // doctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.upper);
            this.Name = "doctorForm";
            this.Text = "Doctor : ";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel MainPanel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnNotification;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroButton myAccountButton;
        private MetroFramework.Controls.MetroButton btnSettings;
        private MetroFramework.Controls.MetroButton patirntHistoryButton;
        private MetroFramework.Controls.MetroButton btnProfile;
        private MetroFramework.Controls.MetroButton btnAddEmployee;
        private MetroFramework.Controls.MetroPanel upper;
    }
}