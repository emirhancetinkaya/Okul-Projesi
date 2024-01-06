using System;
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
    public partial class FRMkulüp : Form
    {
        public FRMkulüp()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRCET\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True ");
        void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLKULUPLER ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FRMkulüp_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKULUPLER (kulupad)values(@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtkulupad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kulüp kaydedildi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkulupıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtkulupad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBLKULUPLER where KULUPID=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", txtkulupıd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silme işlemi gerçekleşti", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tblkulupler SET kulupad=@p1 where kulupıd=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", txtkulupad.Text);
            komut.Parameters.AddWithValue("@p2", txtkulupıd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("güncelleme başarıyla yapıldı");
            liste();
        }
    }
}
