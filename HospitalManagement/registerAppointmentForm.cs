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
    public partial class registerAppointmentForm : MetroFramework.Forms.MetroForm
    {
        public registerAppointmentForm()
        {
            InitializeComponent();


            userPanel.Controls.Clear();
            userPanel.Controls.Add(new registerAppointmentUserControl());
        }

        private void registerAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerAppointmentForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
