using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class FrmEmployee : Form
    {


        string connectionString;

        public FrmEmployee()
        {
            InitializeComponent();
        }

        
        public void RefreshList() {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "select * from Employees order by EmployeeId";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView_Personal.DataSource = dataTable;
            connection.Close();


        }

        public void DepartmentList() { 
        var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "select * from Departments";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            comboBox_PersonalDepartment.DisplayMember = "DepartmentName";
            comboBox_PersonalDepartment.ValueMember = "DepartmentId";
            comboBox_PersonalDepartment.DataSource = dataTable;
            connection.Close();


        }

        private void button_PersonalList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["postgreDBLearning"].ConnectionString;
            RefreshList();
            DepartmentList();
        }

        private void button_PersonalAdd_Click(object sender, EventArgs e)
        {
            var employeeName = textBox_PersonelName.Text;
            var employeeSurname = textBox_PersonalSurname.Text;
            var employeeSalary = decimal.Parse(textBox_PersonalSalary.Text);
            var departmentId = int.Parse(comboBox_PersonalDepartment.SelectedValue.ToString());
            
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            var query = "insert into Employees(EmployeeName,EmployeeSurname,EmployeeSalary,DepartmentId) values (@employeeName, @employeeSurname, @employeeSalary, @departmentId)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeeName", employeeName);
            command.Parameters.AddWithValue("@employeeSurname", employeeSurname);
            command.Parameters.AddWithValue("@employeeSalary", employeeSalary);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Personel Eklendi");
            RefreshList();
            
        }

        private void button_PersonalUpdate_Click(object sender, EventArgs e)
        {

            var employeeID = int.Parse(textBox_PersonelID.Text);
            var employeeName = textBox_PersonelName.Text;
            var employeeSurname = textBox_PersonalSurname.Text;
            var employeeSalary = decimal.Parse(textBox_PersonalSalary.Text);
            var departmentId = int.Parse(comboBox_PersonalDepartment.SelectedValue.ToString());

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            var query = "UPDATE Employees SET EmployeeName=@employeeName, EmployeeSurname=@employeeSurname, EmployeeSalary=@employeeSalary, DepartmentId=@departmentId WHERE EmployeeID=@employeeID";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@employeeName", employeeName);
            command.Parameters.AddWithValue("@employeeSurname", employeeSurname);
            command.Parameters.AddWithValue("@employeeSalary", employeeSalary);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Personel Güncellendi");
            RefreshList();

        }

        private void button_GetPersonalByID_Click(object sender, EventArgs e)
        {
            var employeeID = int.Parse(textBox_PersonelID.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            var query = "SELECT * FROM Employees WHERE EmployeeID=@employeeID";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeeID", employeeID);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView_Personal.DataSource = dataTable;


        }

        private void button_PersonalDelete_Click(object sender, EventArgs e)
        {
            var employeeID = int.Parse(textBox_PersonelID.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            var query = "DELETE FROM Employees WHERE EmployeeID=@employeeID";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Personel Silindi");
            RefreshList();
        }
    }
}
