namespace CSharpEgitimKampi601
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Customer = new System.Windows.Forms.DataGridView();
            this.button_CustomerList = new System.Windows.Forms.Button();
            this.lbl_CustomerIDTitle = new System.Windows.Forms.Label();
            this.textBox_CustomerID = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.lbl_CustomerNameTitle = new System.Windows.Forms.Label();
            this.textBox_CustomerSurname = new System.Windows.Forms.TextBox();
            this.lbl_CustomerSurnameTitle = new System.Windows.Forms.Label();
            this.lbl_CustomerCityTitle = new System.Windows.Forms.Label();
            this.textBox_CustomerBalance = new System.Windows.Forms.TextBox();
            this.lbl_CustomerBalanceTitle = new System.Windows.Forms.Label();
            this.textBox_CustomerCity = new System.Windows.Forms.TextBox();
            this.textBox_CustomerShoppingCount = new System.Windows.Forms.TextBox();
            this.lbl_CustomerShoppingCountTitle = new System.Windows.Forms.Label();
            this.button_CustomerAdd = new System.Windows.Forms.Button();
            this.button_CustomerUpdate = new System.Windows.Forms.Button();
            this.button_CustomerDelete = new System.Windows.Forms.Button();
            this.button_GetCustomerByID = new System.Windows.Forms.Button();
            this.button_CustomerListBson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Customer
            // 
            this.dataGridView_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Customer.Location = new System.Drawing.Point(316, 32);
            this.dataGridView_Customer.Name = "dataGridView_Customer";
            this.dataGridView_Customer.Size = new System.Drawing.Size(673, 501);
            this.dataGridView_Customer.TabIndex = 0;
            // 
            // button_CustomerList
            // 
            this.button_CustomerList.Location = new System.Drawing.Point(33, 200);
            this.button_CustomerList.Name = "button_CustomerList";
            this.button_CustomerList.Size = new System.Drawing.Size(131, 23);
            this.button_CustomerList.TabIndex = 1;
            this.button_CustomerList.Text = "Müşteri Listele";
            this.button_CustomerList.UseVisualStyleBackColor = true;
            this.button_CustomerList.Click += new System.EventHandler(this.button_CustomerList_Click);
            // 
            // lbl_CustomerIDTitle
            // 
            this.lbl_CustomerIDTitle.AutoSize = true;
            this.lbl_CustomerIDTitle.Location = new System.Drawing.Point(30, 35);
            this.lbl_CustomerIDTitle.Name = "lbl_CustomerIDTitle";
            this.lbl_CustomerIDTitle.Size = new System.Drawing.Size(58, 13);
            this.lbl_CustomerIDTitle.TabIndex = 2;
            this.lbl_CustomerIDTitle.Text = "Müşteri ID:";
            // 
            // textBox_CustomerID
            // 
            this.textBox_CustomerID.Location = new System.Drawing.Point(132, 32);
            this.textBox_CustomerID.Name = "textBox_CustomerID";
            this.textBox_CustomerID.Size = new System.Drawing.Size(131, 20);
            this.textBox_CustomerID.TabIndex = 3;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(132, 57);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(131, 20);
            this.textBoxCustomerName.TabIndex = 5;
            // 
            // lbl_CustomerNameTitle
            // 
            this.lbl_CustomerNameTitle.AutoSize = true;
            this.lbl_CustomerNameTitle.Location = new System.Drawing.Point(30, 60);
            this.lbl_CustomerNameTitle.Name = "lbl_CustomerNameTitle";
            this.lbl_CustomerNameTitle.Size = new System.Drawing.Size(62, 13);
            this.lbl_CustomerNameTitle.TabIndex = 4;
            this.lbl_CustomerNameTitle.Text = "Müşteri Adı:";
            // 
            // textBox_CustomerSurname
            // 
            this.textBox_CustomerSurname.Location = new System.Drawing.Point(132, 82);
            this.textBox_CustomerSurname.Name = "textBox_CustomerSurname";
            this.textBox_CustomerSurname.Size = new System.Drawing.Size(131, 20);
            this.textBox_CustomerSurname.TabIndex = 7;
            // 
            // lbl_CustomerSurnameTitle
            // 
            this.lbl_CustomerSurnameTitle.AutoSize = true;
            this.lbl_CustomerSurnameTitle.Location = new System.Drawing.Point(30, 85);
            this.lbl_CustomerSurnameTitle.Name = "lbl_CustomerSurnameTitle";
            this.lbl_CustomerSurnameTitle.Size = new System.Drawing.Size(79, 13);
            this.lbl_CustomerSurnameTitle.TabIndex = 6;
            this.lbl_CustomerSurnameTitle.Text = "Müşteri Soyadı:";
            // 
            // lbl_CustomerCityTitle
            // 
            this.lbl_CustomerCityTitle.AutoSize = true;
            this.lbl_CustomerCityTitle.Location = new System.Drawing.Point(30, 110);
            this.lbl_CustomerCityTitle.Name = "lbl_CustomerCityTitle";
            this.lbl_CustomerCityTitle.Size = new System.Drawing.Size(71, 13);
            this.lbl_CustomerCityTitle.TabIndex = 8;
            this.lbl_CustomerCityTitle.Text = "Müşteri Şehir:";
            // 
            // textBox_CustomerBalance
            // 
            this.textBox_CustomerBalance.Location = new System.Drawing.Point(132, 132);
            this.textBox_CustomerBalance.Name = "textBox_CustomerBalance";
            this.textBox_CustomerBalance.Size = new System.Drawing.Size(131, 20);
            this.textBox_CustomerBalance.TabIndex = 11;
            // 
            // lbl_CustomerBalanceTitle
            // 
            this.lbl_CustomerBalanceTitle.AutoSize = true;
            this.lbl_CustomerBalanceTitle.Location = new System.Drawing.Point(30, 135);
            this.lbl_CustomerBalanceTitle.Name = "lbl_CustomerBalanceTitle";
            this.lbl_CustomerBalanceTitle.Size = new System.Drawing.Size(42, 13);
            this.lbl_CustomerBalanceTitle.TabIndex = 10;
            this.lbl_CustomerBalanceTitle.Text = "Bakiye:";
            // 
            // textBox_CustomerCity
            // 
            this.textBox_CustomerCity.Location = new System.Drawing.Point(132, 107);
            this.textBox_CustomerCity.Name = "textBox_CustomerCity";
            this.textBox_CustomerCity.Size = new System.Drawing.Size(131, 20);
            this.textBox_CustomerCity.TabIndex = 9;
            // 
            // textBox_CustomerShoppingCount
            // 
            this.textBox_CustomerShoppingCount.Location = new System.Drawing.Point(132, 158);
            this.textBox_CustomerShoppingCount.Name = "textBox_CustomerShoppingCount";
            this.textBox_CustomerShoppingCount.Size = new System.Drawing.Size(131, 20);
            this.textBox_CustomerShoppingCount.TabIndex = 13;
            // 
            // lbl_CustomerShoppingCountTitle
            // 
            this.lbl_CustomerShoppingCountTitle.AutoSize = true;
            this.lbl_CustomerShoppingCountTitle.Location = new System.Drawing.Point(30, 161);
            this.lbl_CustomerShoppingCountTitle.Name = "lbl_CustomerShoppingCountTitle";
            this.lbl_CustomerShoppingCountTitle.Size = new System.Drawing.Size(76, 13);
            this.lbl_CustomerShoppingCountTitle.TabIndex = 12;
            this.lbl_CustomerShoppingCountTitle.Text = "Alışveriş Tutar:";
            // 
            // button_CustomerAdd
            // 
            this.button_CustomerAdd.Location = new System.Drawing.Point(99, 229);
            this.button_CustomerAdd.Name = "button_CustomerAdd";
            this.button_CustomerAdd.Size = new System.Drawing.Size(131, 23);
            this.button_CustomerAdd.TabIndex = 14;
            this.button_CustomerAdd.Text = "Müşteri Ekle";
            this.button_CustomerAdd.UseVisualStyleBackColor = true;
            this.button_CustomerAdd.Click += new System.EventHandler(this.button_CustomerAdd_Click);
            // 
            // button_CustomerUpdate
            // 
            this.button_CustomerUpdate.Location = new System.Drawing.Point(99, 258);
            this.button_CustomerUpdate.Name = "button_CustomerUpdate";
            this.button_CustomerUpdate.Size = new System.Drawing.Size(131, 23);
            this.button_CustomerUpdate.TabIndex = 15;
            this.button_CustomerUpdate.Text = "Müşteri Güncelle";
            this.button_CustomerUpdate.UseVisualStyleBackColor = true;
            this.button_CustomerUpdate.Click += new System.EventHandler(this.button_CustomerUpdate_Click);
            // 
            // button_CustomerDelete
            // 
            this.button_CustomerDelete.Location = new System.Drawing.Point(99, 391);
            this.button_CustomerDelete.Name = "button_CustomerDelete";
            this.button_CustomerDelete.Size = new System.Drawing.Size(131, 23);
            this.button_CustomerDelete.TabIndex = 16;
            this.button_CustomerDelete.Text = "Müşteri Sil";
            this.button_CustomerDelete.UseVisualStyleBackColor = true;
            this.button_CustomerDelete.Click += new System.EventHandler(this.button_CustomerDelete_Click);
            // 
            // button_GetCustomerByID
            // 
            this.button_GetCustomerByID.Location = new System.Drawing.Point(99, 287);
            this.button_GetCustomerByID.Name = "button_GetCustomerByID";
            this.button_GetCustomerByID.Size = new System.Drawing.Size(131, 23);
            this.button_GetCustomerByID.TabIndex = 17;
            this.button_GetCustomerByID.Text = "Müşteri ID\'e göre getir";
            this.button_GetCustomerByID.UseVisualStyleBackColor = true;
            this.button_GetCustomerByID.Click += new System.EventHandler(this.button_GetCustomerByID_Click);
            // 
            // button_CustomerListBson
            // 
            this.button_CustomerListBson.Location = new System.Drawing.Point(179, 200);
            this.button_CustomerListBson.Name = "button_CustomerListBson";
            this.button_CustomerListBson.Size = new System.Drawing.Size(131, 23);
            this.button_CustomerListBson.TabIndex = 18;
            this.button_CustomerListBson.Text = "Müşteri Listele Bson";
            this.button_CustomerListBson.UseVisualStyleBackColor = true;
            this.button_CustomerListBson.Click += new System.EventHandler(this.button_CustomerListBson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.button_CustomerListBson);
            this.Controls.Add(this.button_GetCustomerByID);
            this.Controls.Add(this.button_CustomerDelete);
            this.Controls.Add(this.button_CustomerUpdate);
            this.Controls.Add(this.button_CustomerAdd);
            this.Controls.Add(this.textBox_CustomerShoppingCount);
            this.Controls.Add(this.lbl_CustomerShoppingCountTitle);
            this.Controls.Add(this.textBox_CustomerBalance);
            this.Controls.Add(this.lbl_CustomerBalanceTitle);
            this.Controls.Add(this.textBox_CustomerCity);
            this.Controls.Add(this.lbl_CustomerCityTitle);
            this.Controls.Add(this.textBox_CustomerSurname);
            this.Controls.Add(this.lbl_CustomerSurnameTitle);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.lbl_CustomerNameTitle);
            this.Controls.Add(this.textBox_CustomerID);
            this.Controls.Add(this.lbl_CustomerIDTitle);
            this.Controls.Add(this.button_CustomerList);
            this.Controls.Add(this.dataGridView_Customer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Customer;
        private System.Windows.Forms.Button button_CustomerList;
        private System.Windows.Forms.Label lbl_CustomerIDTitle;
        private System.Windows.Forms.TextBox textBox_CustomerID;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label lbl_CustomerNameTitle;
        private System.Windows.Forms.TextBox textBox_CustomerSurname;
        private System.Windows.Forms.Label lbl_CustomerSurnameTitle;
        private System.Windows.Forms.Label lbl_CustomerCityTitle;
        private System.Windows.Forms.TextBox textBox_CustomerBalance;
        private System.Windows.Forms.Label lbl_CustomerBalanceTitle;
        private System.Windows.Forms.TextBox textBox_CustomerCity;
        private System.Windows.Forms.TextBox textBox_CustomerShoppingCount;
        private System.Windows.Forms.Label lbl_CustomerShoppingCountTitle;
        private System.Windows.Forms.Button button_CustomerAdd;
        private System.Windows.Forms.Button button_CustomerUpdate;
        private System.Windows.Forms.Button button_CustomerDelete;
        private System.Windows.Forms.Button button_GetCustomerByID;
        private System.Windows.Forms.Button button_CustomerListBson;
    }
}

