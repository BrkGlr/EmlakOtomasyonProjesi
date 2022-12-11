namespace EmlakOtomasyonProjesi
{
    partial class formSearchHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSearchHouse));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFloorMax = new System.Windows.Forms.TextBox();
            this.txtLandSpaceMax = new System.Windows.Forms.TextBox();
            this.txtRoomMax = new System.Windows.Forms.TextBox();
            this.txtPriceMax = new System.Windows.Forms.TextBox();
            this.txtFloorMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRoomMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLandSpaceMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriceMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbRent = new System.Windows.Forms.RadioButton();
            this.rdbSale = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 315);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(33, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(918, 255);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konut Arama";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(689, 196);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(212, 38);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFloorMax);
            this.groupBox3.Controls.Add(this.txtLandSpaceMax);
            this.groupBox3.Controls.Add(this.txtRoomMax);
            this.groupBox3.Controls.Add(this.txtPriceMax);
            this.groupBox3.Controls.Add(this.txtFloorMin);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtRoomMin);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtLandSpaceMin);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtPriceMin);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbType);
            this.groupBox3.Location = new System.Drawing.Point(200, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(485, 224);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seçim Paneli";
            // 
            // txtFloorMax
            // 
            this.txtFloorMax.Location = new System.Drawing.Point(318, 101);
            this.txtFloorMax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFloorMax.Name = "txtFloorMax";
            this.txtFloorMax.Size = new System.Drawing.Size(94, 27);
            this.txtFloorMax.TabIndex = 57;
            // 
            // txtLandSpaceMax
            // 
            this.txtLandSpaceMax.Location = new System.Drawing.Point(318, 140);
            this.txtLandSpaceMax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLandSpaceMax.Name = "txtLandSpaceMax";
            this.txtLandSpaceMax.Size = new System.Drawing.Size(94, 27);
            this.txtLandSpaceMax.TabIndex = 56;
            // 
            // txtRoomMax
            // 
            this.txtRoomMax.Location = new System.Drawing.Point(318, 178);
            this.txtRoomMax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRoomMax.Name = "txtRoomMax";
            this.txtRoomMax.Size = new System.Drawing.Size(94, 27);
            this.txtRoomMax.TabIndex = 55;
            // 
            // txtPriceMax
            // 
            this.txtPriceMax.Location = new System.Drawing.Point(318, 63);
            this.txtPriceMax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPriceMax.Name = "txtPriceMax";
            this.txtPriceMax.Size = new System.Drawing.Size(145, 27);
            this.txtPriceMax.TabIndex = 54;
            // 
            // txtFloorMin
            // 
            this.txtFloorMin.Location = new System.Drawing.Point(149, 101);
            this.txtFloorMin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFloorMin.Name = "txtFloorMin";
            this.txtFloorMin.Size = new System.Drawing.Size(94, 27);
            this.txtFloorMin.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Averta-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(16, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Bulunduğu Kat :";
            // 
            // txtRoomMin
            // 
            this.txtRoomMin.Location = new System.Drawing.Point(149, 178);
            this.txtRoomMin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRoomMin.Name = "txtRoomMin";
            this.txtRoomMin.Size = new System.Drawing.Size(94, 27);
            this.txtRoomMin.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Oda Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "m2";
            // 
            // txtLandSpaceMin
            // 
            this.txtLandSpaceMin.Location = new System.Drawing.Point(149, 140);
            this.txtLandSpaceMin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLandSpaceMin.Name = "txtLandSpaceMin";
            this.txtLandSpaceMin.Size = new System.Drawing.Size(94, 27);
            this.txtLandSpaceMin.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Alan :";
            // 
            // txtPriceMin
            // 
            this.txtPriceMin.Location = new System.Drawing.Point(149, 63);
            this.txtPriceMin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPriceMin.Name = "txtPriceMin";
            this.txtPriceMin.Size = new System.Drawing.Size(145, 27);
            this.txtPriceMin.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Fiyat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 44;
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
            this.cmbType.Location = new System.Drawing.Point(149, 25);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(145, 28);
            this.cmbType.TabIndex = 43;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.CadetBlue;
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(689, 154);
            this.btnList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(212, 38);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbRent);
            this.groupBox2.Controls.Add(this.rdbSale);
            this.groupBox2.Location = new System.Drawing.Point(5, 51);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(173, 198);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konut Durumu";
            // 
            // rdbRent
            // 
            this.rdbRent.AutoSize = true;
            this.rdbRent.Location = new System.Drawing.Point(29, 100);
            this.rdbRent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbRent.Name = "rdbRent";
            this.rdbRent.Size = new System.Drawing.Size(72, 24);
            this.rdbRent.TabIndex = 1;
            this.rdbRent.TabStop = true;
            this.rdbRent.Text = "Kiralık";
            this.rdbRent.UseVisualStyleBackColor = true;
            // 
            // rdbSale
            // 
            this.rdbSale.AutoSize = true;
            this.rdbSale.Location = new System.Drawing.Point(29, 46);
            this.rdbSale.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbSale.Name = "rdbSale";
            this.rdbSale.Size = new System.Drawing.Size(72, 24);
            this.rdbSale.TabIndex = 0;
            this.rdbSale.TabStop = true;
            this.rdbSale.Text = "Satılık";
            this.rdbSale.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.CadetBlue;
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(821, 584);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(212, 38);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Görüntüle";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(821, 628);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(212, 38);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // formSearchHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 759);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Averta-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formSearchHouse";
            this.Text = "Konu Arama";
            this.Load += new System.EventHandler(this.formSearchHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnList;
        private GroupBox groupBox2;
        private RadioButton rdbRent;
        private RadioButton rdbSale;
        private GroupBox groupBox3;
        private TextBox txtFloorMax;
        private TextBox txtLandSpaceMax;
        private TextBox txtRoomMax;
        private TextBox txtPriceMax;
        private TextBox txtFloorMin;
        private Label label8;
        private TextBox txtRoomMin;
        private Label label5;
        private Label label4;
        private TextBox txtLandSpaceMin;
        private Label label3;
        private TextBox txtPriceMin;
        private Label label2;
        private Label label1;
        private ComboBox cmbType;
        private Button btnBack;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnShow;
        private Button btnPrint;
    }
}