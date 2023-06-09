﻿using System;
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
    public partial class Categories : Form
    {
        Functions Con;
        public Categories()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCategories();
        }
        private void ShowCategories()
        {
            string Query = "select * from CategoryTbl";
            CategoryList.DataSource = Con.GetData(Query);
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
        int Key = 0;
        private void CategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CapNameTb.Text = CategoryList.SelectedRows[0].Cells[1].Value.ToString();
            if (CapNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CategoryList.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditBtn_Click(object sender, EventArgs e)
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
                    string Query = "Update CategoryTbl set CatName = '{0}' where CatId = {1}";
                    Query = string.Format(Query, Category, Key);
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Missing Data !!!");
                }
                else
                {
                    string Category = CapNameTb.Text;
                    string Query = "delete from CategoryTbl where CatId = {0}";
                    Query = string.Format(Query, Key);
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

        private void EmpLbl_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();
            Obj.Show();
            this.Hide();
        }

        private void LeaveLbl_Click(object sender, EventArgs e)
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
    }
}
