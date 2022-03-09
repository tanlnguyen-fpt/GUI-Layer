using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentBLL studentBLL = new();
        private void ShowGridView()
        {
            dgvStudent.DataSource = studentBLL.SelectAllStudent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowGridView();
        }

        int position = -1;
        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if (position == -1) return;
            DataGridViewRow row = dgvStudent.Rows[position];
            txtStudentID.Text = row.Cells[0].Value.ToString();
            txtFullName.Text = row.Cells[1].Value.ToString();
            txtClassID.Text = row.Cells[2].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Student st = new Student(txtStudentID.Text, txtFullName.Text, txtClassID.Text);
            if (studentBLL.InsertStudent(st))
                ShowGridView();
            else
                MessageBox.Show("Insert Failed!!!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student st = new Student(txtStudentID.Text, txtFullName.Text, txtClassID.Text);
            if (studentBLL.UpdateStudent(st))
                ShowGridView();
            else
                MessageBox.Show("Update failed!!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            if (studentBLL.DeleteStudent(studentID))
            {
                ShowGridView();
                txtStudentID.Text = "";
                txtFullName.Text = "";
                txtClassID.Text = "";
            }
            else
            {
                MessageBox.Show("Delete failed!!!");
            }
        }
    }
}
