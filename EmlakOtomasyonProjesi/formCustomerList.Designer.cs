namespace EmlakOtomasyonProjesi
{
    partial class formCustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCustomerList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEstateAdd = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbHeating = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtHousingAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBalcony = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuildingFloor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuldinAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLandSpace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbRent = new System.Windows.Forms.RadioButton();
            this.rdbSale = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(783, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnEstateAdd);
            this.groupBox1.Controls.Add(this.txtCustomerId);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(10, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(978, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteriler";
            // 
            // btnEstateAdd
            // 
            this.btnEstateAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEstateAdd.Enabled = false;
            this.btnEstateAdd.ForeColor = System.Drawing.Color.White;
            this.btnEstateAdd.Location = new System.Drawing.Point(821, 155);
            this.btnEstateAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEstateAdd.Name = "btnEstateAdd";
            this.btnEstateAdd.Size = new System.Drawing.Size(145, 33);
            this.btnEstateAdd.TabIndex = 15;
            this.btnEstateAdd.Text = "GayriMenkul Ekle";
            this.btnEstateAdd.UseVisualStyleBackColor = false;
            this.btnEstateAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(821, 123);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(94, 27);
            this.txtCustomerId.TabIndex = 14;
            this.txtCustomerId.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(821, 198);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(787, 479);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Kaydet";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cmbHeating);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtHousingAddress);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtBalcony);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtBuildingFloor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFloor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBuldinAge);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSalon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRoom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLandSpace);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbType);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(29, 290);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(959, 559);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konut Bilgisi";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDescription);
            this.groupBox4.Location = new System.Drawing.Point(416, 355);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(323, 185);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Açıklama";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(18, 25);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(284, 135);
            this.txtDescription.TabIndex = 0;
            // 
            // cmbHeating
            // 
            this.cmbHeating.FormattingEnabled = true;
            this.cmbHeating.Items.AddRange(new object[] {
            "Doğalgaz",
            "Soba",
            "Merkezi"});
            this.cmbHeating.Location = new System.Drawing.Point(589, 293);
            this.cmbHeating.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbHeating.Name = "cmbHeating";
            this.cmbHeating.Size = new System.Drawing.Size(145, 28);
            this.cmbHeating.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Averta-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(455, 300);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 20);
            this.label18.TabIndex = 22;
            this.label18.Text = "Isınma :";
            // 
            // txtHousingAddress
            // 
            this.txtHousingAddress.Location = new System.Drawing.Point(134, 373);
            this.txtHousingAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHousingAddress.Multiline = true;
            this.txtHousingAddress.Name = "txtHousingAddress";
            this.txtHousingAddress.Size = new System.Drawing.Size(267, 142);
            this.txtHousingAddress.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Averta-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(16, 379);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Adres :";
            // 
            // txtBalcony
            // 
            this.txtBalcony.Location = new System.Drawing.Point(589, 251);
            this.txtBalcony.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBalcony.Name = "txtBalcony";
            this.txtBalcony.Size = new System.Drawing.Size(94, 27);
            this.txtBalcony.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Averta-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(455, 257);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Balkon :";
            // 
            // txtBuildingFloor
            // 
            this.txtBuildingFloor.Location = new System.Drawing.Point(589, 211);
            this.txtBuildingFloor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBuildingFloor.Name = "txtBuildingFloor";
            this.txtBuildingFloor.Size = new System.Drawing.Size(94, 27);
            this.txtBuildingFloor.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Averta-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(455, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Kay Sayısı :";
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(589, 170);
            this.txtFloor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(94, 27);
            this.txtFloor.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Averta-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(455, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bulunduğu Kat :";
            // 
            // txtBuldinAge
            // 
            this.txtBuldinAge.Location = new System.Drawing.Point(589, 128);
            this.txtBuldinAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBuldinAge.Name = "txtBuldinAge";
            this.txtBuldinAge.Size = new System.Drawing.Size(94, 27);
            this.txtBuldinAge.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bina Yaşı :";
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(134, 302);
            this.txtSalon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(94, 27);
            this.txtSalon.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Salon :";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(134, 261);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(94, 27);
            this.txtRoom.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oda Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "m2";
            // 
            // txtLandSpace
            // 
            this.txtLandSpace.Location = new System.Drawing.Point(134, 215);
            this.txtLandSpace.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLandSpace.Name = "txtLandSpace";
            this.txtLandSpace.Size = new System.Drawing.Size(94, 27);
            this.txtLandSpace.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alan :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(134, 172);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(145, 27);
            this.txtPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fiyat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Konut Tipi :";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Daire",
            "Residance",
            "Müstakil",
            "Villa"});
            this.cmbType.Location = new System.Drawing.Point(134, 127);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(145, 28);
            this.cmbType.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbRent);
            this.groupBox3.Controls.Add(this.rdbSale);
            this.groupBox3.Location = new System.Drawing.Point(16, 35);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(343, 77);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Konut Durumu";
            // 
            // rdbRent
            // 
            this.rdbRent.AutoSize = true;
            this.rdbRent.Location = new System.Drawing.Point(203, 29);
            this.rdbRent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbRent.Name = "rdbRent";
            this.rdbRent.Size = new System.Drawing.Size(72, 24);
            this.rdbRent.TabIndex = 1;
            this.rdbRent.Text = "Kiralık";
            this.rdbRent.UseVisualStyleBackColor = true;
            // 
            // rdbSale
            // 
            this.rdbSale.AutoSize = true;
            this.rdbSale.Location = new System.Drawing.Point(60, 29);
            this.rdbSale.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbSale.Name = "rdbSale";
            this.rdbSale.Size = new System.Drawing.Size(72, 24);
            this.rdbSale.TabIndex = 0;
            this.rdbSale.Text = "Satılık";
            this.rdbSale.UseVisualStyleBackColor = true;
            // 
            // formCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 896);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Averta-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formCustomerList";
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.formCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnBack;
        private Button btnAdd;
        private GroupBox groupBox2;
        private ComboBox cmbHeating;
        private Label label18;
        private TextBox txtHousingAddress;
        private Label label11;
        private TextBox txtBalcony;
        private Label label10;
        private TextBox txtBuildingFloor;
        private Label label9;
        private TextBox txtFloor;
        private Label label8;
        private TextBox txtBuldinAge;
        private Label label7;
        private TextBox txtSalon;
        private Label label6;
        private TextBox txtRoom;
        private Label label5;
        private Label label4;
        private TextBox txtLandSpace;
        private Label label3;
        private TextBox txtPrice;
        private Label label2;
        private Label label1;
        private ComboBox cmbType;
        private GroupBox groupBox3;
        private RadioButton rdbRent;
        private RadioButton rdbSale;
        private GroupBox groupBox4;
        private TextBox txtDescription;
        private TextBox txtCustomerId;
        private Button btnEstateAdd;
    }
}