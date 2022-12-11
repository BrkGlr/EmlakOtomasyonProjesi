using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmlakOtomasyonProjesi.Context;
using EmlakOtomasyonProjesi.Models;

namespace EmlakOtomasyonProjesi
{
    public partial class formHouseUpdate : Form
    {
        public formHouseUpdate()
        {
            InitializeComponent();
        }
        MyDbContext db = new MyDbContext();
        private void formHouseUpdate_Load(object sender, EventArgs e)
        {
            var housingList = db.Housings.ToList();
            dataGridView1.DataSource = housingList;


            dataGridView1.Columns["ModifiedDate"].Visible = false;
            dataGridView1.Columns["IsActive"].Visible = false;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == "Satılık")
            {
                rdbSale.Checked = true;
            }
            else
            {
                rdbRent.Checked = true;
            }
            cmbType.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtLandSpace.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtRoom.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSalon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtBuldinAge.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtFloor.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtBalcony.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            cmbHeating.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtHousingAddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBuildingFloor.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            
            txtId.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();





        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MyDbContext db = new MyDbContext();

            var housing = db.Housings.FirstOrDefault(x => x.Id == int.Parse(txtId.Text));
            if (rdbRent.Checked)
            {
                housing.RealEstate = "Kiralık";
            }
            if (rdbSale.Checked)
            {
                housing.RealEstate = "Satılık";
            }
            if (rdbActive.Checked)
            {
                housing.IsActive = true;
            }
            if (rdbPassive.Checked)
            {
                housing.IsActive = false;
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
            
          
            housing.ModifiedDate = DateTime.Now;

            

            db.Housings.Update(housing);
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

