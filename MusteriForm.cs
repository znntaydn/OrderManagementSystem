using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkPrj
{
    public partial class MusteriForm : Form
    {
        ProjelerVTEntities entities = new ProjelerVTEntities();

        public MusteriForm()
        {
            InitializeComponent();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            tumKayitlariGoster();
        }

        private void tumKayitlariGoster()
        {
            // var musterileri = entities.Musteri.ToList();
            //dataGridView1.DataSource = musterileri;

            var musteriler = (from musteri in entities.Musteri
                              select new
                              {
                                  musteri.MusteriID,
                                  musteri.Ad,
                                  musteri.Soyad,
                                  musteri.Sehir
                              }).ToList();
            dataGridView1.DataSource = musteriler;

            dataGridView1.ClearSelection();
            metinKutulariniTemizle();
        }

        private void metinKutulariniTemizle()
        {
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxSehir.Clear();
            textBoxMusteriID.Text = "0";

        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            tumKayitlariGoster();
            textBoxMusteriID.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = textBoxAd.Text;
            musteri.Soyad = textBoxSoyad.Text;
            musteri.Sehir = textBoxSehir.Text;
            try
            {
                entities.Musteri.Add(musteri);
                entities.SaveChanges();
                MessageBox.Show("Müşteri kaydı eklendi");
                tumKayitlariGoster();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Veri tabanı işlemleri sırasında hata oluştu, HataKodu: H001 \n + " +
                                ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = dataGridView1.SelectedCells[0].RowIndex;
            textBoxMusteriID.Text = dataGridView1.Rows[secilenSatır].Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView1.Rows[secilenSatır].Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView1.Rows[secilenSatır].Cells[2].Value.ToString();
            textBoxSehir.Text = dataGridView1.Rows[secilenSatır].Cells[3].Value.ToString();
        }

        private void textBoxMusteriID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int musteriID = Convert.ToInt32(textBoxMusteriID.Text);
                var musteri = entities.Musteri.Find(musteriID);
                entities.Musteri.Remove(musteri);
                entities.SaveChanges();
                MessageBox.Show("Müşteri kaydı silindi");
                tumKayitlariGoster();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Veri tabanı işlemleri sırasında hata oluştu, HataKodu: H002 \n + " +
                                ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int musteriID = Convert.ToInt32(textBoxMusteriID.Text);
                var musteri = entities.Musteri.Find(musteriID);
                musteri.Ad = textBoxAd.Text;
                musteri.Soyad = textBoxSoyad.Text;
                musteri.Sehir = textBoxSehir.Text;
                entities.SaveChanges();
                MessageBox.Show("Müşteri bilgileri güncellendi");
                tumKayitlariGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanı işlemleri sırasında hata oluştu, HataKodu: H003 \n + " +
                                ex.Message);
            }
        }
    }
}
