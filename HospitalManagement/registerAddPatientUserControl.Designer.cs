namespace HospitalManagement
{
    partial class registerAddPatientUserControl
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.testButton = new MetroFramework.Controls.MetroButton();
            this.admitButton = new MetroFramework.Controls.MetroButton();
            this.appointmentButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.testButton);
            this.metroPanel1.Controls.Add(this.admitButton);
            this.metroPanel1.Controls.Add(this.appointmentButton);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1150, 555);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // testButton
            // 
            this.testButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.testButton.Location = new System.Drawing.Point(839, 125);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(250, 200);
            this.testButton.TabIndex = 4;
            this.testButton.Text = "Test";
            this.testButton.UseSelectable = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // admitButton
            // 
            this.admitButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.admitButton.Location = new System.Drawing.Point(496, 125);
            this.admitButton.Name = "admitButton";
            this.admitButton.Size = new System.Drawing.Size(250, 200);
            this.admitButton.TabIndex = 3;
            this.admitButton.Text = "Admit";
            this.admitButton.UseSelectable = true;
            this.admitButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // appointmentButton
            // 
            this.appointmentButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.appointmentButton.Location = new System.Drawing.Point(157, 125);
            this.appointmentButton.Name = "appointmentButton";
            this.appointmentButton.Size = new System.Drawing.Size(250, 200);
            this.appointmentButton.TabIndex = 2;
            this.appointmentButton.Text = "Appointment";
            this.appointmentButton.UseSelectable = true;
            this.appointmentButton.Click += new System.EventHandler(this.appointmentButton_Click);
            // 
            // registerAddPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "registerAddPatientUserControl";
            this.Size = new System.Drawing.Size(1150, 555);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton testButton;
        private MetroFramework.Controls.MetroButton admitButton;
        private MetroFramework.Controls.MetroButton appointmentButton;
    }
}
