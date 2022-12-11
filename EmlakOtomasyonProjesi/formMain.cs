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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnHouseAdd_Click(object sender, EventArgs e)
        {
            formAddHousing addhousing = new formAddHousing();
            addhousing.Show();
            this.Hide();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            MyDbContext db = new MyDbContext();
            var housingList = db.Housings.ToList();
            dataGridView1.DataSource=housingList;
            
            dataGridView1.Columns["Description"].Visible = false;
            dataGridView1.Columns["ModifiedDate"].Visible = false;
            dataGridView1.Columns["IsActive"].Visible = false;
            dataGridView1.Columns["Customer"].Visible = false;

            var companyNameLabel = db.Companies.FirstOrDefault(x => x.Id == 1);
            lblCompanyName.Text = companyNameLabel.CompanyName;

        }

        private void btnHouseSearch_Click(object sender, EventArgs e)
        {
            formSearchHouse searchhousing = new formSearchHouse();
            searchhousing.Show();
            this.Hide();
        }

        private void btnHouseUpdate_Click(object sender, EventArgs e)
        {
           formHouseUpdate houseupdate=new formHouseUpdate();
            houseupdate.Show();
            this.Hide();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            formAddCustomer customer = new formAddCustomer();
            customer.Show();
            this.Hide();
        }

        private void btnCostemerList_Click(object sender, EventArgs e)
        {
            formCustomerList customerList = new formCustomerList();
            customerList.Show();
            this.Hide();
        }

        private void btnCostemerUpdate_Click(object sender, EventArgs e)
        {
            formCustomerEdit customerEdit = new formCustomerEdit();
            customerEdit.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
