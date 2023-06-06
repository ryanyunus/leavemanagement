using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveMs
{
    public partial class Login : Form
    {
        Functions Con;
        public Login()
        {
            InitializeComponent();
            Con = new Functions();
        }
        public static int EmpId;
        public static string EmpName = "";

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Info!!!");
            }
            else
            {
                if (UnameTb.Text == "Admin" && PasswordTb.Text == "")
                {
                    Employee Obj = new Employee();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    try
                    {
                        string Query = "Select * from EmployeeTbl where EmpName = '{0}' and EmpPass = '{1}'";
                        Query = string.Format(Query, UnameTb.Text, PasswordTb.Text);
                        DataTable dt = Con.GetData(Query);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Incorrect Password!!!");
                            UnameTb.Text = "";
                            PasswordTb.Text = "";
                        }
                        else
                        {
                            EmpId = Convert.ToInt32(dt.Rows[0][0].ToString());
                            EmpName = dt.Rows[0][1].ToString();
                            ViewLeaves Obj = new ViewLeaves();
                            Obj.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }
    }
}
