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
    public partial class RegisterAdmitForm : MetroFramework.Forms.MetroForm
    {
        public RegisterAdmitForm()
        {
            InitializeComponent();
            metroPanel.Controls.Clear();
            metroPanel.Controls.Add(new registerAdmitUC());
        }

        private void RegisterAdmitForm_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
