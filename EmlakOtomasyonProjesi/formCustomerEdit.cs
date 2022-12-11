using EmlakOtomasyonProjesi.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonProjesi
{
    public partial class formCustomerEdit : Form
    {
        public formCustomerEdit()
        {
            InitializeComponent();
        }
        MyDbContext db = new MyDbContext();
        private void formCustomerEdit_Load(object sender, EventArgs e)
        {

            var customerList = db.Customers.ToList();
            dataGridView1.DataSource = customerList;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirstName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtLastName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMobil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCustemerId.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = db.Customers.FirstOrDefault(x => x.Id == int.Parse(txtCustemerId.Text));
            customer.FirstName= txtFirstName.Text;
            customer.LastName= txtLastName.Text;
            customer.TelNumber= txtTel.Text;
            customer.MobilNumber=txtMobil.Text;
            customer.Email = txtEmail.Text;
            customer.Address = txtAddress.Text;
            customer.ModifiedDate = DateTime.Now;

            db.Customers.Update(customer);
            db.SaveChanges();
            formMain main = new formMain();
            main.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formMain main = new formMain();
            main.Show();
            this.Hide();
        }

       
    }
}
