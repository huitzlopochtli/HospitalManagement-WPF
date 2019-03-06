using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class addEmpUserPanel : UserControl
    {
        public addEmpUserPanel()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            addEmp();
        }

        private void designationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.designationComboBox.SelectedItem.ToString() == "Doctor")
            {
                selectedPanel.Controls.Clear();
                selectedPanel.Controls.Add(new selectDoctorPanel());
            }
            else if (this.designationComboBox.SelectedItem.ToString() == "Supervisor")
            {
                selectedPanel.Controls.Clear();
                selectedPanel.Controls.Add(new selectSupervisorPanel());
            }
            else
                selectedPanel.Controls.Clear();
        }

        private void selectedPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addEmpUserPanel_Load(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
