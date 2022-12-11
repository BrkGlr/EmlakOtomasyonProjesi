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
using EmlakOtomasyonProjesi.Models;

namespace EmlakOtomasyonProjesi
{
    public partial class formAddHousing : Form
    {
        public formAddHousing()
        {
            InitializeComponent();
        }
        MyDbContext db = new MyDbContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            //var customer = db.Customers.FirstOrDefault(x => x.Id==);
            var housing=new HousingEntity();
            if (rdbRent.Checked)
            {
                housing.RealEstate = "Kiralık";
            }
            if(rdbSale.Checked)
            {
                housing.RealEstate = "Satılık";
            }
            housing.RealEstateType = cmbType.Text;
            housing.Price = Convert.ToDecimal(txtPrice.Text);
            housing.Address=txtHousingAddress.Text;
            housing.LandSpace =Convert.ToDecimal( txtLandSpace.Text);
            housing.Room = int.Parse(txtRoom.Text);
            housing.Saloon =int.Parse( txtSalon.Text);
            housing.BuldingAge =int.Parse( txtBuldinAge.Text);
            housing.Floor = int.Parse(txtFloor.Text);
            housing.BuildinFloor =int.Parse( txtBuildingFloor.Text);
            housing.Balcony = int.Parse(txtBalcony.Text);
            housing.Heating = cmbHeating.Text;
            housing.Description=txtDescription.Text;
            
          
           
            var customer = new CustomerEntity();
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.TelNumber = txtTelNo.Text;
            customer.MobilNumber = txtMobilNo.Text;
            customer.Email = txtEmail.Text;
            customer.Address = txtHostAddress.Text;
            db.Customers.Add(customer);
            db.SaveChanges();
            housing.CustomerId=customer.Id;
            db.Housings.Add(housing);
            db.SaveChanges();
            formMain main=new formMain();
            main.Show();
            this.Hide();
            
            
        }

        private void formAddHousing_Load(object sender, EventArgs e)
        {
            cmbHeating.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formMain main = new formMain();
            main.Show();
            this.Hide();
        }
    }
}
