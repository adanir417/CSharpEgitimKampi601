using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
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
    public partial class Form1 : Form
    {

        // Operations
        CustomerOperations customerOperations = new CustomerOperations();

        public Form1()
        {
            InitializeComponent();
            RefreshList();
        }



        // Form Controls
        VScrollBar vscrollbar = new VScrollBar();
        HScrollBar hscrollbar = new HScrollBar();

        private void RefreshList() {
            dataGridView_Customer.DataSource = customerOperations.GetCustomers().Select(
                x => new {
                MusteriAdi = x.CustomerName,
                MusteriSoyadi = x.CustomerSurname,
                Sehir = x.CustomerCity,
                MusteriBakiye = x.CustomerBalance,
                MusteriAlisveris = x.CustomerBalance
                }
                ).ToList() ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vscrollbar.Dock = DockStyle.Right;
            hscrollbar.Dock = DockStyle.Bottom;
            Controls.Add(vscrollbar);
            Controls.Add(hscrollbar);
        }

        private void button_CustomerAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer() { 
            CustomerName = textBoxCustomerName.Text,
            CustomerSurname = textBox_CustomerSurname.Text,
            CustomerCity = textBox_CustomerCity.Text,
            CustomerBalance = decimal.Parse(textBox_CustomerBalance.Text),
            CustomerShoppingCount = int.Parse(textBox_CustomerShoppingCount.Text),
            };

            customerOperations.AddCustomer(customer);

            MessageBox.Show("Müşteri Ekleme Başarılı!");
            RefreshList();
        }

        private void button_CustomerListBson_Click(object sender, EventArgs e)
        {
            dataGridView_Customer.DataSource = customerOperations.GetCustomersFromBson();
        }

        private void button_CustomerList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button_CustomerUpdate_Click(object sender, EventArgs e)
        {
            string id = textBox_CustomerID.Text;
            Customer customer = new Customer
            {
                CustomerId = id,
                CustomerName = textBoxCustomerName.Text,
                CustomerSurname = textBox_CustomerSurname.Text,
                CustomerCity = textBox_CustomerCity.Text,
                CustomerBalance = decimal.Parse(textBox_CustomerBalance.Text),
                CustomerShoppingCount = int.Parse(textBox_CustomerShoppingCount.Text)

            };

            customerOperations.UpdateCustomer(customer);
            RefreshList();
        }

        private void button_CustomerDelete_Click(object sender, EventArgs e)
        {
            string id = textBox_CustomerID.Text;
            customerOperations.DeleteCustomer(id);
            RefreshList();
        }

        private void button_GetCustomerByID_Click(object sender, EventArgs e)
        {
            dataGridView_Customer.DataSource = customerOperations.GetCustomerById(textBox_CustomerID.Text);
        }
    }
}
