namespace CSharpEgitimKampi601
{
    partial class FrmEmployee
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
            this.button_GetPersonalByID = new System.Windows.Forms.Button();
            this.button_PersonalDelete = new System.Windows.Forms.Button();
            this.button_PersonalUpdate = new System.Windows.Forms.Button();
            this.button_PersonalAdd = new System.Windows.Forms.Button();
            this.textBox_PersonalSurname = new System.Windows.Forms.TextBox();
            this.lbl_CustomerSurnameTitle = new System.Windows.Forms.Label();
            this.textBox_PersonelName = new System.Windows.Forms.TextBox();
            this.lbl_CustomerNameTitle = new System.Windows.Forms.Label();
            this.textBox_PersonelID = new System.Windows.Forms.TextBox();
            this.lbl_CustomerIDTitle = new System.Windows.Forms.Label();
            this.button_PersonalList = new System.Windows.Forms.Button();
            this.dataGridView_Personal = new System.Windows.Forms.DataGridView();
            this.textBox_PersonalSalary = new System.Windows.Forms.TextBox();
            this.lbl_PersonalSalary = new System.Windows.Forms.Label();
            this.lbl_PersonalDepartment = new System.Windows.Forms.Label();
            this.comboBox_PersonalDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Personal)).BeginInit();
            this.SuspendLayout();
            // 
            // button_GetPersonalByID
            // 
            this.button_GetPersonalByID.Location = new System.Drawing.Point(68, 285);
            this.button_GetPersonalByID.Name = "button_GetPersonalByID";
            this.button_GetPersonalByID.Size = new System.Drawing.Size(131, 23);
            this.button_GetPersonalByID.TabIndex = 50;
            this.button_GetPersonalByID.Text = "Personel ID\'e göre getir";
            this.button_GetPersonalByID.UseVisualStyleBackColor = true;
            this.button_GetPersonalByID.Click += new System.EventHandler(this.button_GetPersonalByID_Click);
            // 
            // button_PersonalDelete
            // 
            this.button_PersonalDelete.Location = new System.Drawing.Point(68, 389);
            this.button_PersonalDelete.Name = "button_PersonalDelete";
            this.button_PersonalDelete.Size = new System.Drawing.Size(131, 23);
            this.button_PersonalDelete.TabIndex = 49;
            this.button_PersonalDelete.Text = "Personel Sil";
            this.button_PersonalDelete.UseVisualStyleBackColor = true;
            this.button_PersonalDelete.Click += new System.EventHandler(this.button_PersonalDelete_Click);
            // 
            // button_PersonalUpdate
            // 
            this.button_PersonalUpdate.Location = new System.Drawing.Point(68, 256);
            this.button_PersonalUpdate.Name = "button_PersonalUpdate";
            this.button_PersonalUpdate.Size = new System.Drawing.Size(131, 23);
            this.button_PersonalUpdate.TabIndex = 48;
            this.button_PersonalUpdate.Text = "Personel Güncelle";
            this.button_PersonalUpdate.UseVisualStyleBackColor = true;
            this.button_PersonalUpdate.Click += new System.EventHandler(this.button_PersonalUpdate_Click);
            // 
            // button_PersonalAdd
            // 
            this.button_PersonalAdd.Location = new System.Drawing.Point(68, 227);
            this.button_PersonalAdd.Name = "button_PersonalAdd";
            this.button_PersonalAdd.Size = new System.Drawing.Size(131, 23);
            this.button_PersonalAdd.TabIndex = 47;
            this.button_PersonalAdd.Text = "Personel Ekle";
            this.button_PersonalAdd.UseVisualStyleBackColor = true;
            this.button_PersonalAdd.Click += new System.EventHandler(this.button_PersonalAdd_Click);
            // 
            // textBox_PersonalSurname
            // 
            this.textBox_PersonalSurname.Location = new System.Drawing.Point(111, 62);
            this.textBox_PersonalSurname.Name = "textBox_PersonalSurname";
            this.textBox_PersonalSurname.Size = new System.Drawing.Size(131, 20);
            this.textBox_PersonalSurname.TabIndex = 44;
            // 
            // lbl_CustomerSurnameTitle
            // 
            this.lbl_CustomerSurnameTitle.AutoSize = true;
            this.lbl_CustomerSurnameTitle.Location = new System.Drawing.Point(6, 65);
            this.lbl_CustomerSurnameTitle.Name = "lbl_CustomerSurnameTitle";
            this.lbl_CustomerSurnameTitle.Size = new System.Drawing.Size(86, 13);
            this.lbl_CustomerSurnameTitle.TabIndex = 43;
            this.lbl_CustomerSurnameTitle.Text = "Personel Soyadı:";
            // 
            // textBox_PersonelName
            // 
            this.textBox_PersonelName.Location = new System.Drawing.Point(111, 37);
            this.textBox_PersonelName.Name = "textBox_PersonelName";
            this.textBox_PersonelName.Size = new System.Drawing.Size(131, 20);
            this.textBox_PersonelName.TabIndex = 42;
            // 
            // lbl_CustomerNameTitle
            // 
            this.lbl_CustomerNameTitle.AutoSize = true;
            this.lbl_CustomerNameTitle.Location = new System.Drawing.Point(23, 40);
            this.lbl_CustomerNameTitle.Name = "lbl_CustomerNameTitle";
            this.lbl_CustomerNameTitle.Size = new System.Drawing.Size(69, 13);
            this.lbl_CustomerNameTitle.TabIndex = 41;
            this.lbl_CustomerNameTitle.Text = "Personel Adı:";
            // 
            // textBox_PersonelID
            // 
            this.textBox_PersonelID.Location = new System.Drawing.Point(111, 12);
            this.textBox_PersonelID.Name = "textBox_PersonelID";
            this.textBox_PersonelID.Size = new System.Drawing.Size(131, 20);
            this.textBox_PersonelID.TabIndex = 40;
            // 
            // lbl_CustomerIDTitle
            // 
            this.lbl_CustomerIDTitle.AutoSize = true;
            this.lbl_CustomerIDTitle.Location = new System.Drawing.Point(27, 15);
            this.lbl_CustomerIDTitle.Name = "lbl_CustomerIDTitle";
            this.lbl_CustomerIDTitle.Size = new System.Drawing.Size(65, 13);
            this.lbl_CustomerIDTitle.TabIndex = 39;
            this.lbl_CustomerIDTitle.Text = "Personel ID:";
            // 
            // button_PersonalList
            // 
            this.button_PersonalList.Location = new System.Drawing.Point(68, 198);
            this.button_PersonalList.Name = "button_PersonalList";
            this.button_PersonalList.Size = new System.Drawing.Size(131, 23);
            this.button_PersonalList.TabIndex = 38;
            this.button_PersonalList.Text = "Personel Listele";
            this.button_PersonalList.UseVisualStyleBackColor = true;
            this.button_PersonalList.Click += new System.EventHandler(this.button_PersonalList_Click);
            // 
            // dataGridView_Personal
            // 
            this.dataGridView_Personal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Personal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Personal.Location = new System.Drawing.Point(295, 12);
            this.dataGridView_Personal.Name = "dataGridView_Personal";
            this.dataGridView_Personal.Size = new System.Drawing.Size(519, 463);
            this.dataGridView_Personal.TabIndex = 37;
            // 
            // textBox_PersonalSalary
            // 
            this.textBox_PersonalSalary.Location = new System.Drawing.Point(111, 88);
            this.textBox_PersonalSalary.Name = "textBox_PersonalSalary";
            this.textBox_PersonalSalary.Size = new System.Drawing.Size(131, 20);
            this.textBox_PersonalSalary.TabIndex = 52;
            // 
            // lbl_PersonalSalary
            // 
            this.lbl_PersonalSalary.AutoSize = true;
            this.lbl_PersonalSalary.Location = new System.Drawing.Point(12, 91);
            this.lbl_PersonalSalary.Name = "lbl_PersonalSalary";
            this.lbl_PersonalSalary.Size = new System.Drawing.Size(80, 13);
            this.lbl_PersonalSalary.TabIndex = 51;
            this.lbl_PersonalSalary.Text = "Personel Maaş:";
            // 
            // lbl_PersonalDepartment
            // 
            this.lbl_PersonalDepartment.AutoSize = true;
            this.lbl_PersonalDepartment.Location = new System.Drawing.Point(30, 118);
            this.lbl_PersonalDepartment.Name = "lbl_PersonalDepartment";
            this.lbl_PersonalDepartment.Size = new System.Drawing.Size(62, 13);
            this.lbl_PersonalDepartment.TabIndex = 53;
            this.lbl_PersonalDepartment.Text = "Departman:";
            // 
            // comboBox_PersonalDepartment
            // 
            this.comboBox_PersonalDepartment.FormattingEnabled = true;
            this.comboBox_PersonalDepartment.Location = new System.Drawing.Point(111, 115);
            this.comboBox_PersonalDepartment.Name = "comboBox_PersonalDepartment";
            this.comboBox_PersonalDepartment.Size = new System.Drawing.Size(131, 21);
            this.comboBox_PersonalDepartment.TabIndex = 54;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 494);
            this.Controls.Add(this.comboBox_PersonalDepartment);
            this.Controls.Add(this.lbl_PersonalDepartment);
            this.Controls.Add(this.textBox_PersonalSalary);
            this.Controls.Add(this.lbl_PersonalSalary);
            this.Controls.Add(this.button_GetPersonalByID);
            this.Controls.Add(this.button_PersonalDelete);
            this.Controls.Add(this.button_PersonalUpdate);
            this.Controls.Add(this.button_PersonalAdd);
            this.Controls.Add(this.textBox_PersonalSurname);
            this.Controls.Add(this.lbl_CustomerSurnameTitle);
            this.Controls.Add(this.textBox_PersonelName);
            this.Controls.Add(this.lbl_CustomerNameTitle);
            this.Controls.Add(this.textBox_PersonelID);
            this.Controls.Add(this.lbl_CustomerIDTitle);
            this.Controls.Add(this.button_PersonalList);
            this.Controls.Add(this.dataGridView_Personal);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Personal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_GetPersonalByID;
        private System.Windows.Forms.Button button_PersonalDelete;
        private System.Windows.Forms.Button button_PersonalUpdate;
        private System.Windows.Forms.Button button_PersonalAdd;
        private System.Windows.Forms.TextBox textBox_PersonalSurname;
        private System.Windows.Forms.Label lbl_CustomerSurnameTitle;
        private System.Windows.Forms.TextBox textBox_PersonelName;
        private System.Windows.Forms.Label lbl_CustomerNameTitle;
        private System.Windows.Forms.TextBox textBox_PersonelID;
        private System.Windows.Forms.Label lbl_CustomerIDTitle;
        private System.Windows.Forms.Button button_PersonalList;
        private System.Windows.Forms.DataGridView dataGridView_Personal;
        private System.Windows.Forms.TextBox textBox_PersonalSalary;
        private System.Windows.Forms.Label lbl_PersonalSalary;
        private System.Windows.Forms.Label lbl_PersonalDepartment;
        private System.Windows.Forms.ComboBox comboBox_PersonalDepartment;
    }
}