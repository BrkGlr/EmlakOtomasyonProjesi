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
using EmlakOtomasyonProjesi.Context;


namespace EmlakOtomasyonProjesi
{
    public partial class formNewCompany : Form
    {
       
        
        public formNewCompany()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formEntry formBack=new formEntry();
            formBack.Show();
            this.Hide();
        }
        MyDbContext db = new MyDbContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            var company = new CompanyEntity();
            company.CompanyName = txtCompanyName.Text;
            company.Competent = txtCompetent.Text;
            company.UserName=txtUserName.Text.Trim();
            company.Password = txtPassword.Text;
            company.Address = txtAddress.Text;
            company.TelNumber = txtTelNo.Text;
            company.MobilNumber = txtMobilNo.Text;
            company.FaxNumber=txtFaxNo.Text;
            company.Email = txtEmail.Text;
            db.Companies.Add(company);
            db.SaveChanges();
            formEntry formBack = new formEntry();
            formBack.Show();
            this.Hide();




        }
    }
}
