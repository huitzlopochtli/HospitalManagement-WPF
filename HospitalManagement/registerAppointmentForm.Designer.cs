namespace HospitalManagement
{
    partial class registerAppointmentForm
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
            this.userPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // userPanel
            // 
            this.userPanel.HorizontalScrollbarBarColor = true;
            this.userPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.userPanel.HorizontalScrollbarSize = 10;
            this.userPanel.Location = new System.Drawing.Point(1, 82);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(500, 700);
            this.userPanel.TabIndex = 0;
            this.userPanel.VerticalScrollbarBarColor = true;
            this.userPanel.VerticalScrollbarHighlightOnWheel = false;
            this.userPanel.VerticalScrollbarSize = 10;
            this.userPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // registerAppointmentForm
            // 
            this.ClientSize = new System.Drawing.Size(508, 800);
            this.Controls.Add(this.userPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "registerAppointmentForm";
            this.Text = "Appointment Form";
            this.Load += new System.EventHandler(this.registerAppointmentForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel userPanel;
    }
}