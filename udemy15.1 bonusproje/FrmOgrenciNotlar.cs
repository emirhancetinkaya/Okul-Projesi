﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace udemy15._1_bonusproje
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRCET\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True ");
        public string numara;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        { 
            SqlCommand komut = new SqlCommand("select dersad,sınav1,sınav2,sınav3,proje,ortalama,durum from TBLNOTLAR INNER JOIN TBLDERSLER ON TBLNOTLAR.DERSID = TBLDERSLER.DERSID where OGRID=@P1", baglanti);
            komut.Parameters.AddWithValue("@p1",numara);
            //this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
