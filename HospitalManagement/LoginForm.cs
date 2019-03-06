using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.DAL;
using System.Data.SqlClient;

namespace HospitalManagement
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select designation from Login where username = '" + txtUserName.Text + "' and password = '" + txtPassword.Text + "'", new Connection().getConnection());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString().Trim() == "admin")
                    {
                        frmAdmin a = new frmAdmin();
                        a.Show();
                        this.Hide();
                    }
                    if (dt.Rows[0][0].ToString().Trim() == "doctor")
                    {
                        doctorForm a = new doctorForm();//change the code
                        a.Show();
                        this.Hide();
                    }
                    if (dt.Rows[0][0].ToString().Trim() == "reseptionist")
                    {
                        registerForm a = new registerForm();//change the code
                        a.Show();
                        this.Hide();
                    }
                    if (dt.Rows[0][0].ToString().Trim() == "pharmacist")
                    {
                        frmAdmin a = new frmAdmin();//change the code
                        a.Show();
                        this.Hide();
                    }
                    if (dt.Rows[0][0].ToString().Trim() == "digonostics")
                    {
                        frmAdmin a = new frmAdmin();//change the code
                        a.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Password or username mismatch!");
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
            }
            catch (SqlException ex)
            {
                
            }
                
        }
    }
}
