using EmlakOtomasyonProjesi.Context;
using EmlakOtomasyonProjesi.Models;
using System.ComponentModel;


namespace EmlakOtomasyonProjesi
{
    public partial class formEntry : Form
    {
       

        public formEntry()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            formNewCompany newCompany=new formNewCompany();
            newCompany.Show();
            this.Hide();
        }
        MyDbContext db=new MyDbContext();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            var state=db.Companies.FirstOrDefault(x=>x.UserName==txtUserName.Text&&x.Password==txtPassword.Text);
            if (state!=null)
            {
                formMain main = new formMain();
                main.Show();
                this.Hide();
            }
        }

        private void formEntry_Load(object sender, EventArgs e)
        {
            
        }
    }
}