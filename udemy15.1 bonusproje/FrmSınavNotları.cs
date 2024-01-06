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
    public partial class FrmSınavNotları : Form
    {
        public FrmSınavNotları()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLNOTLARTableAdapter ds = new DataSet1TableAdapters.TBLNOTLARTableAdapter();
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRCET\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True ");
        
        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtıd.Text));
        }
        private void FrmSınavNotları_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLDERSLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "DERSAD";
            comboBox1.ValueMember = "DERSID";
            comboBox1.DataSource = dt;
            baglanti.Close();
        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtsınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsınav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();


        }
        int sınav1, sınav2, sınav3, proje;
        double ortalama;
        string durum;

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            
            sınav1 = Convert.ToInt16(txtsınav1.Text);
            sınav2 = Convert.ToInt16(txtsınav2.Text);
            sınav3 = Convert.ToInt16(txtsınav3.Text);
            proje = Convert.ToInt16(txtproje.Text);
            ortalama = (sınav1 + sınav2 + sınav3) / 4;
            txtortalama.Text = ortalama.ToString();
            if(ortalama>=50)
            {
                txtdurum.Text = "true";
            }
            else
            {
                txtdurum.Text="false";
            }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            ds.NotGüncelle(byte.Parse(comboBox1.SelectedValue.ToString()), int.Parse(txtıd.Text),byte.Parse(txtsınav1.Text),byte.Parse(txtsınav2.Text),byte.Parse(txtsınav3.Text),byte.Parse(txtproje.Text),decimal.Parse(txtortalama.Text),bool.Parse(txtdurum.Text),notid);
        }
    }
}
