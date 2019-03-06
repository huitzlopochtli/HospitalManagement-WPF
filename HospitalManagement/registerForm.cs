using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class registerForm : MetroFramework.Forms.MetroForm
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new registerProfileUserControl());
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new registerAddPatientUserControl());
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewEmpolyee_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new registerAppointmentUserControl());
        }
    }
}
