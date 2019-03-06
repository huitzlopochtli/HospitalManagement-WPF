using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace HospitalManagement
{
    public partial class registerAddPatientUserControl : UserControl
    {
        public registerAddPatientUserControl()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            RegisterAdmitForm admit = new RegisterAdmitForm();
            admit.Show();
        }

        private void appointmentButton_Click(object sender, EventArgs e)
        {
            registerAppointmentForm appointment = new registerAppointmentForm();
            appointment.Show();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            RegisterTestForm Test = new RegisterTestForm();
            Test.Show();
        }
    }
}
