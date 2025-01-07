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
    public partial class FrmCustomer : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["postgreDBLearning"].ConnectionString;

        public FrmCustomer()
        {
            InitializeComponent();
        }

        public DataTable GetAllCustomer() { 
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * from Customers";
            var command = new NpgsqlCommand(query,connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            connection.Close();
            return datatable;

        }

        public void RefreshList() {
            dataGridView_Customer.DataSource = GetAllCustomer();
        }

        private void button_CustomerList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button_CustomerAdd_Click(object sender, EventArgs e)
        {
            string customerName = textBoxCustomerName.Text;
            string customerSurname = textBox_CustomerSurname.Text;
            string customerCity = textBox_CustomerCity.Text;

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Customers(CustomerName,CustomerSurname,CustomerCity) values (@customerName,@customerSurname,@customerCity)";
            var command = new NpgsqlCommand(@query,connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ekleme işlemi başarılı");
            RefreshList();
        }

        private void button_CustomerDelete_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "delete from Customers where CustomerId=@customerId";
            var command = new NpgsqlCommand(query,connection);
            command.Parameters.AddWithValue("@customerId", int.Parse(textBox_CustomerID.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Silme işlemi başarılı");
            RefreshList();

        }

        private void button_CustomerUpdate_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "update Customers set CustomerName=@customerName, CustomerSurname=@customerSurname, CustomerCity=@customerCity where CustomerId=@customerId";
            var command = new NpgsqlCommand(query,connection);
            command.Parameters.AddWithValue("@customerId", int.Parse(textBox_CustomerID.Text));
            command.Parameters.AddWithValue("@customerName", textBoxCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurname", textBox_CustomerSurname.Text);
            command.Parameters.AddWithValue("@customerCity", textBox_CustomerCity.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Güncelleme işlemi başarılı şekilde tamamlandı.");
            RefreshList();


        }
    }
}
