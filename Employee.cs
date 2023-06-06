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
        Functions Con;
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

                if (EmpNameTb.Text == ""||EmpPhoneTb.Text == ""||PasswordTb.Text == "" || EmpGenCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data !!!");
                }
                else
                {
                    string name = EmpNameTb.Text;
                    string Gender = EmpGenCb.SelectedItem.ToString();
                    string Phone = EmpPhoneTb.Text;
                    string Pass = PasswordTb.Text;
                    string Add = EmppAddTb.Text;
                    String Query = "insert into EmployeeTbl values('{0}','{1}','{2}','{3}','{4}')";
                    //ring Query = "INSERT INTO EmployeeTbl (EmpName, EmpGen, EmpPhone,EmpPass, EmAdd) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
                    MessageBox.Show("Employee Added !!!");
                    Query = string.Format(Query, name,Gender,Phone,Pass,Add);
                    Con.SetData(Query);
                    ShowEmployees();
                   //mpNameTb.Text = "";
                   //mpPhoneTb.Text = "";
                   //asswordTb.Text = "";
                   //mppAddTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        int Key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            EmpGenCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            EmpPhoneTb.Text = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            PasswordTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            EmppAddTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            if (EmpNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || PasswordTb.Text == "" || EmpGenCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data !!!");
                }
                else
                {
                    string name = EmpNameTb.Text;
                    string Gender = EmpGenCb.SelectedItem.ToString();
                    string Phone = EmpPhoneTb.Text;
                    string Pass = PasswordTb.Text;
                    string Add = EmppAddTb.Text;
                    String Query = "update EmployeeTbl set EmpName = '{0}',EmpGen = '{1}',EmpPhone = '{2}',EmpPass = '{3}',EmAdd = '{4}' where EmpId = {5}";
                    //ring Query = "INSERT INTO EmployeeTbl (EmpName, EmpGen, EmpPhone,EmpPass, EmAdd) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";

                    Query = string.Format(Query, name, Gender, Phone, Pass, Add,Key);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Updated !!!");
                    //mpNameTb.Text = "";
                    //mpPhoneTb.Text = "";
                    //asswordTb.Text = "";
                    //mppAddTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            try
            {

                if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || PasswordTb.Text == "" || EmpGenCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data !!!");
                }
                else
                {
                    string name = EmpNameTb.Text;
                    string Gender = EmpGenCb.SelectedItem.ToString();
                    string Phone = EmpPhoneTb.Text;
                    string Pass = PasswordTb.Text;
                    string Add = EmppAddTb.Text;
                    String Query = "delete from  EmployeeTbl where EmpId = {0}";
                    //ring Query = "INSERT INTO EmployeeTbl (EmpName, EmpGen, EmpPhone,EmpPass, EmAdd) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";

                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Deleted !!!");
                    //mpNameTb.Text = "";
                    //mpPhoneTb.Text = "";
                    //asswordTb.Text = "";
                    //mppAddTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
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

        private void CategoryLbl_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmpNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EmpPhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EmppAddTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void EmpGenCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
