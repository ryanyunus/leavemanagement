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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmployees();
        }
        private void ShowEmployees()
        {
            string Query = "select * from EmployeeTbl";
            EmployeeList.DataSource = Con.GetData(Query);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (CapNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data !!!");
                }
                else
                {
                    string Category = CapNameTb.Text;
                    string Query = "insert into CategoryTbl values('{0}')";
                    //string Query = "INSERT INTO CategoryTable (CatName) VALUES ('{0}')";

                    Query = string.Format(Query, Category);
                    Con.SetData(Query);
                    ShowCategories();
                    CapNameTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
    }
}
