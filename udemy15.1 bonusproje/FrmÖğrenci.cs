using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace udemy15._1_bonusproje
{
    public partial class FrmÖğrenci : Form
    {
        public FrmÖğrenci()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRCET\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True ");

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
       
        private void FrmÖğrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ÖğrenciListele();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKULUPLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KULUPAD";
            comboBox1.ValueMember = "KULUPID";
            comboBox1.DataSource = dt;
            baglanti.Close();
        }

        string c = " ";
        private void btnekle_Click(object sender, EventArgs e)
        {
            
            if(radioButton1.Checked==true)
            {
                c = "Kız";
            }
            if(radioButton2.Checked==true)
            {
                c = "Erkek";
            }
            ds.ÖğrenciEkle(txtad.Text, txtsoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c);
            MessageBox.Show("ekleme başarılı");
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ÖğrenciListele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.ÖğrenciSil(int.Parse(txtıd.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            // = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            // = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            ds.ÖğrenciGüncelle(txtad.Text, txtsoyad.Text,byte.Parse (comboBox1.SelectedValue.ToString()),c,int.Parse(txtıd.Text));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                c = "Kız";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= ds.ÖğrenciGetir(txtara.Text);
        }
    }
}
