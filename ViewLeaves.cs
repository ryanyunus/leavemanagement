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
    public partial class ViewLeaves : Form
    {
        Functions Con;  
        public ViewLeaves()
        {
            InitializeComponent();
            Con = new Functions();
            EmpIdLbl.Text = Login.EmpId + "";
            EmpNameLbl.Text = Login.EmpName;
            ShowLeaves();   
        }
        private void ShowLeaves()
        {
            string Query = "select * from LeaveTbl where Employee = {0}";
            Query = string.Format(Query, Login.EmpId);
            LeaveList.DataSource = Con.GetData(Query);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Leaves Obj = new Leaves();
            Obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }
    }
}
