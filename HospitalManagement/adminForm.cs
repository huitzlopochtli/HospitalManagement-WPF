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
    public partial class frmAdmin : MetroFramework.Forms.MetroForm
    {
        public frmAdmin()
        {
            InitializeComponent();
            MainPanel.Controls.Add(new adminProfileUserControl());
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //AddEmpoyee addEmpoyeeForm = new AddEmpoyee();
            //addEmpoyeeForm.ShowDialog();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new addEmpUserPanel());
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new adminProfileUserControl());
        }

        private void btnViewEmpolyee_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new viewEmployeeUC());
        }
    }
}
