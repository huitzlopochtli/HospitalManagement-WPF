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
    public partial class viewEmployeeUC : UserControl
    {
        public viewEmployeeUC()
        {
            
            InitializeComponent();
        }

        private void refreshEmpQryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.refreshEmpQry(this.employeeDataSet.employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
