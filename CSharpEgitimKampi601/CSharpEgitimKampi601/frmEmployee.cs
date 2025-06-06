﻿using MongoDB.Bson;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            EmployeeList();
            DepartmentList();
        }
        // PASSWORD GIRMEZSEN CALISMAZ.
        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;userId=postgres;password=!!!PASSWORD!!!";
        void EmployeeList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Employees";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        void DepartmentList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Departments";
            var command = new NpgsqlCommand(query,connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbEmployeeDepartment.DisplayMember = "DepartmentName";
            cmbEmployeeDepartment.ValueMember = "DepartmentId";
            cmbEmployeeDepartment.DataSource = dataTable;
            connection.Close();
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            EmployeeList();
        }

        private void btnEmployeeCreate_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            string employeeSurname = txtEmployeeSurname.Text;
            decimal employeeSalary = decimal.Parse(txtEmployeeSalary.Text);
            int departmentId = int.Parse(cmbEmployeeDepartment.SelectedValue.ToString());

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Employees(EmployeeName,EmployeeSurname,EmployeeSalary,DepartmentId) values (@employeeName,@employeeSurname,@employeeSalary,@departmentId)";
            var command = new NpgsqlCommand(query,connection);
            command.Parameters.AddWithValue("@employeeName",employeeName);
            command.Parameters.AddWithValue("@employeeSurname",employeeSurname);
            command.Parameters.AddWithValue("@employeeSalary",employeeSalary);
            command.Parameters.AddWithValue("@departmentId",departmentId);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı.");
            EmployeeList();
        }
    }
}
