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
    public partial class RegisterTestForm : MetroFramework.Forms.MetroForm
    {
        public RegisterTestForm()
        {
            InitializeComponent();
            metroPanel.Controls.Clear();
            metroPanel.Controls.Add(new RegisterTestUC());
        }

        private void RegisterTestForm_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
