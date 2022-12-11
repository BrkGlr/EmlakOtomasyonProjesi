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
    public partial class formCustomerList : Form
    {
        public formCustomerList()
        {
            InitializeComponent();
        }
        MyDbContext db = new MyDbContext();
        private void formCustomerList_Load(object sender, EventArgs e)
        {
            
            var customerList = db.Customers.ToList();
            dataGridView1.DataSource = customerList;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var housing = new HousingEntity();
            var customer = db.Customers.FirstOrDefault(x => x.Id == int.Parse(txtCustomerId.Text));
            if (rdbRent.Checked)
            {
                housing.RealEstate = "Kiralık";
            }
            if (rdbSale.Checked)
            {
                housing.RealEstate = "Satılık";
            }
            housing.RealEstateType = cmbType.Text;
            housing.Price = Convert.ToDecimal(txtPrice.Text);
            housing.Address = txtHousingAddress.Text;
            housing.LandSpace = Convert.ToDecimal(txtLandSpace.Text);
            housing.Room = int.Parse(txtRoom.Text);
            housing.Saloon = int.Parse(txtSalon.Text);
            housing.BuldingAge = int.Parse(txtBuldinAge.Text);
            housing.Floor = int.Parse(txtFloor.Text);
            housing.BuildinFloor = int.Parse(txtBuildingFloor.Text);
            housing.Balcony = int.Parse(txtBalcony.Text);
            housing.Heating = cmbHeating.Text;
            housing.Description = txtDescription.Text;
            housing.CustomerId =int.Parse( txtCustomerId.Text);
           
            

            db.Housings.Add(housing);
            db.SaveChanges();
            formMain main = new formMain();
            main.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtCustomerId.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            btnEstateAdd.Enabled = true;
            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            rdbRent.Visible = true;
            rdbSale.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label18.Visible = true;
            cmbType.Visible = true;
            cmbHeating.Visible = true;
            txtPrice.Visible = true;
            txtLandSpace.Visible = true;
            txtRoom.Visible = true;
            txtSalon.Visible = true;
            txtHousingAddress.Visible = true;
            txtBuldinAge.Visible = true;
            txtFloor.Visible = true;
            txtBuildingFloor.Visible = true;
            txtBalcony.Visible = true;
            txtDescription.Visible = true;
            btnAdd.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formMain main=new formMain();
            main.Show();
            this.Hide();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
