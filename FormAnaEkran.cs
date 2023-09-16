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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Personel_Kayit
{
    public partial class FormAnaEkran : Form
    {
        public FormAnaEkran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=SeyhmusPC;Initial Catalog=PersonelVeriTabani;Integrated Security=True");




        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtmeslek.Text = "";
            txtsoyad.Text = "";
            mskmaas.Text = "";
            cmbsehirler.Text = "";
            button_bekar.Checked = false;
            button_evli.Checked = false;
            txtad.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbsehirler.Text);
            komut.Parameters.AddWithValue("@p4",mskmaas.Text);
            komut.Parameters.AddWithValue("@p5", txtmeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);

            komut.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("Personel Eklendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_evli_CheckedChanged(object sender, EventArgs e)
        {
            if (button_evli.Checked==true)
            {
                label8.Text = "True";
            }
           
        }

        private void button_bekar_CheckedChanged(object sender, EventArgs e)
        {
            if (button_bekar.Checked == true)
            {
                label8.Text = "False";
            }
            
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbsehirler.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                button_evli.Checked = true;
            }
            if(label8.Text == "False")
            {
                button_bekar.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil=new SqlCommand("Delete From Tbl_Personel Where Perid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtid.Text);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Personel Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1",txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cmbsehirler.Text);
            komutguncelle.Parameters.AddWithValue("@a4", mskmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7",txtid.Text);
            komutguncelle.ExecuteNonQuery();
               


            baglanti.Close();
            MessageBox.Show("Personel Bilgi Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            formistatistik fr=new formistatistik();
            fr.Show();
        }

        private void btngrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg = new FrmGrafikler();
            frg.Show();
        }
    }
}
