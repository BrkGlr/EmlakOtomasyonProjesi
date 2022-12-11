using EmlakOtomasyonProjesi.Context;
using EmlakOtomasyonProjesi.Models;
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
    public partial class formAddCustomer : Form
    {
        public formAddCustomer()
        {
            InitializeComponent();
        }
        MyDbContext db = new MyDbContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = new CustomerEntity();
            customer.FirstName=txtFirstName.Text;
            customer.LastName=txtLastName.Text;
            customer.TelNumber=txtTel.Text;
            customer.MobilNumber = txtMobil.Text;
            customer.Email = txtEmail.Text;
            customer.Address = txtAddress.Text;
            db.Customers.Add(customer);
            db.SaveChanges();
            formMain main=new formMain();
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
