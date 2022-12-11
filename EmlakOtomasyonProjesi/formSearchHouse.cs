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

    public partial class formSearchHouse : Form
    {
        public formSearchHouse()
        {
            InitializeComponent();
        }
        MyDbContext db = new MyDbContext();





        private void btnList_Click(object sender, EventArgs e)
        {


            if (rdbRent.Checked)
            {


                var housingList = db.Housings.Where(x => x.RealEstate == "Kiralık").ToList();
                dataGridView1.DataSource = housingList;
                if (cmbType.Text == "")
                {
                    dataGridView1.DataSource = housingList;
                }
                else
                {
                    var estateType = db.Housings.Where(x => x.RealEstate == "Kiralık" && x.RealEstateType == cmbType.Text).ToList();
                    if (estateType != null)
                    {
                        dataGridView1.DataSource = estateType;
                        if (txtPriceMin.Text == "" && txtPriceMax.Text == "")
                        {
                            dataGridView1.DataSource = estateType;
                        }
                        else
                        {
                            var priceHouse = db.Housings.Where(x => x.RealEstate == "Kiralık" && x.RealEstateType == cmbType.Text && x.Price >= Convert.ToDecimal(txtPriceMin.Text) && x.Price <= Convert.ToDecimal(txtPriceMax.Text)).ToList();
                            if (priceHouse != null)
                            {
                                dataGridView1.DataSource = priceHouse;
                                if (txtFloorMin.Text == "" && txtFloorMax.Text == "")
                                {
                                    dataGridView1.DataSource = priceHouse;
                                }
                                else
                                {
                                    var floor = db.Housings.Where(x => x.RealEstate == "Kiralık" && x.RealEstateType == cmbType.Text && x.Price >= Convert.ToDecimal(txtPriceMin.Text) && x.Price <= Convert.ToDecimal(txtPriceMax.Text) && x.Floor >= int.Parse(txtFloorMin.Text) && x.Floor <= int.Parse(txtFloorMax.Text)).ToList();
                                    if (floor != null)
                                    {
                                        dataGridView1.DataSource = floor;
                                        if (txtLandSpaceMin.Text == "" && txtLandSpaceMax.Text == "")
                                        {
                                            dataGridView1.DataSource = floor;
                                        }
                                        else
                                        {
                                            var landSpace = db.Housings.Where(x => x.RealEstate == "Kiralık" && x.RealEstateType == cmbType.Text && x.Price >= Convert.ToDecimal(txtPriceMin.Text) && x.Price <= Convert.ToDecimal(txtPriceMax.Text) && x.Floor >= int.Parse(txtFloorMin.Text) && x.Floor <= int.Parse(txtFloorMax.Text) && x.LandSpace >= int.Parse(txtLandSpaceMin.Text) && x.LandSpace <= int.Parse(txtLandSpaceMax.Text)).ToList();
                                            if (landSpace != null)
                                            {
                                                dataGridView1.DataSource = landSpace;
                                                if (txtRoomMin.Text == "" && txtRoomMax.Text == "")
                                                {
                                                    dataGridView1.DataSource = landSpace;
                                                }
                                                else
                                                {
                                                    var room = db.Housings.Where(x => x.RealEstate == "Kiralık" && x.RealEstateType == cmbType.Text && x.Price >= Convert.ToDecimal(txtPriceMin.Text) && x.Price <= Convert.ToDecimal(txtPriceMax.Text) && x.Floor >= int.Parse(txtFloorMin.Text) && x.Floor <= int.Parse(txtFloorMax.Text) && x.LandSpace >= int.Parse(txtLandSpaceMin.Text) && x.LandSpace <= int.Parse(txtLandSpaceMax.Text) && x.Room >= int.Parse(txtRoomMin.Text) && x.Room <= int.Parse(txtRoomMax.Text)).ToList();
                                                    dataGridView1.DataSource = room;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }



                    }


                }


            }





            if (rdbSale.Checked)
            {

                var housingList = db.Housings.Where(x => x.RealEstate == "Satılık").ToList();
                dataGridView1.DataSource = housingList;
                if (cmbType.Text == "")
                {
                    dataGridView1.DataSource = housingList;
                }
                else
                {
                    var estateType = db.Housings.Where(x => x.RealEstate == "Satılık" && x.RealEstateType == cmbType.Text).ToList();
                    if (estateType != null)
                    {
                        dataGridView1.DataSource = estateType;
                        if (txtPriceMin.Text == "" && txtPriceMax.Text == "")
                        {
                            dataGridView1.DataSource = estateType;
                        }
                        else
                        {
                            var priceHouse = db.Housings.Where(x => x.RealEstate == "Satılık" && x.RealEstateType == cmbType.Text && x.Price >= Convert.ToDecimal(txtPriceMin.Text) && x.Price <= Convert.ToDecimal(txtPriceMax.Text)).ToList();
                            if (priceHouse != null)
                            {
                                dataGridView1.DataSource = priceHouse;
                                if (txtFloorMin.Text == "" && txtFloorMax.Text == "")
                                {
                                    dataGridView1.DataSource = priceHouse;
                                }
                                else
                                {
                                    var floor = db.Housings.Where(x => x.RealEstate == "Satılık" && x.RealEstateType == cmbType.Text && x.Price >= Convert.ToDecimal(txtPriceMin.Text) && x.Price <= Convert.ToDecimal(txtPriceMax.Text) && x.Floor >= int.Parse(txtFloorMin.Text) && x.Floor <= int.Parse(txtFloorMax.Text)).ToList();
                                    if (floor != null)
                                    {
                                        dataGridView1.DataSource = floor;
                                        if (txtLandSpaceMin.Text == "" && txtLandSpaceMax.Text == "")
                                        {
                                            dataGridView1.DataSource = floor;
                                        }
                                        else
                                        {
                                            var landSpace = db.Housings.Where(x => x.RealEstate == "Satılık" && x.RealEstateType == cmbType.Text && x.Price >= Convert.ToDecimal(txtPriceMin.Text) && x.Price <= Convert.ToDecimal(txtPriceMax.Text) && x.Floor >= int.Parse(txtFloorMin.Text) && x.Floor <= int.Parse(txtFloorMax.Text) && x.LandSpace >= int.Parse(txtLandSpaceMin.Text) && x.LandSpace <= int.Parse(txtLandSpaceMax.Text)).ToList();
                                            if (landSpace != null)
                                            {
                                                dataGridView1.DataSource = landSpace;
                                                if (txtRoomMin.Text == "" && txtRoomMax.Text == "")
                                                {
                                                    dataGridView1.DataSource = landSpace;
                                                }
                                                else
                                                {
                                                    var room = db.Housings.Where(x => x.RealEstate == "Satılık" && x.RealEstateType == cmbType.Text && x.Price >= Convert.ToDecimal(txtPriceMin.Text) && x.Price <= Convert.ToDecimal(txtPriceMax.Text) && x.Floor >= int.Parse(txtFloorMin.Text) && x.Floor <= int.Parse(txtFloorMax.Text) && x.LandSpace >= int.Parse(txtLandSpaceMin.Text) && x.LandSpace <= int.Parse(txtLandSpaceMax.Text) && x.Room >= int.Parse(txtRoomMin.Text) && x.Room <= int.Parse(txtRoomMax.Text)).ToList();
                                                    dataGridView1.DataSource = room;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }



                    }


                }
            }

        }

        private void formSearchHouse_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formMain main = new formMain();
            main.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush solidBrush = new SolidBrush(Color.Black);
                font = new Font("Arial", 16,FontStyle.Bold);
                e.Graphics.DrawString("Konut Listesi", font, solidBrush, 350,75);
                font = new Font("Arial", 14, FontStyle.Bold);
                e.Graphics.DrawString("Durum", font, solidBrush, 30,170);
                e.Graphics.DrawString("Konut Tipi", font, solidBrush,120,170);
                e.Graphics.DrawString("Fiyat", font, solidBrush, 240,170);
                e.Graphics.DrawString("m2", font, solidBrush, 350,170);
                e.Graphics.DrawString("Oda", font, solidBrush, 410,170);
                e.Graphics.DrawString("Salon", font, solidBrush, 470,170);
                e.Graphics.DrawString("Kat", font, solidBrush, 530,170);
                e.Graphics.DrawString("Balkon", font, solidBrush, 570,170);
                e.Graphics.DrawString("Isıtma", font, solidBrush, 650,170);
                
                int x = 0;
                int y = 210;
                while (x <= dataGridView1.Rows.Count) 
                {
                    font = new Font("Arial", 14);
                    e.Graphics.DrawString(dataGridView1.Rows[x].Cells[0].Value.ToString(),font,solidBrush,30,y);
                    e.Graphics.DrawString(dataGridView1.Rows[x].Cells[1].Value.ToString(),font,solidBrush,120,y);
                    e.Graphics.DrawString(dataGridView1.Rows[x].Cells[2].Value.ToString(),font,solidBrush,240,y);
                    e.Graphics.DrawString(dataGridView1.Rows[x].Cells[4].Value.ToString(), font, solidBrush, 350, y);
                    e.Graphics.DrawString(dataGridView1.Rows[x].Cells[5].Value.ToString(), font, solidBrush, 410, y);
                    e.Graphics.DrawString(dataGridView1.Rows[x].Cells[6].Value.ToString(), font, solidBrush, 470, y);
                    e.Graphics.DrawString(dataGridView1.Rows[x].Cells[8].Value.ToString(), font, solidBrush, 530, y);
                    e.Graphics.DrawString(dataGridView1.Rows[x].Cells[11].Value.ToString(), font, solidBrush, 570, y);
                    e.Graphics.DrawString(dataGridView1.Rows[x].Cells[10].Value.ToString(), font, solidBrush, 650, y);
                    font = new Font("Arial", 14, FontStyle.Bold);
                    e.Graphics.DrawString("Açıklama", font, solidBrush, 30, y + 40);
                    font = new Font("Arial", 14);
                    e.Graphics.DrawString(dataGridView1.Rows[x].Cells[12].Value.ToString(), font, solidBrush, 30, y+80);
                    y += 200;
                    x += 1;
                }

                




            }
            catch (Exception)
            {

                
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }

    


}


