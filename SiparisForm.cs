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
    public partial class SiparisForm : Form
    {
        ProjelerVTEntities entities = new ProjelerVTEntities();

        public SiparisForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tumKayitlariGoster();
        }

        private void tumKayitlariGoster()
        {
            var siparisler = (from siparis in entities.Siparis
                              select new
                              {
                                  siparis.SiparisNo,
                                  siparis.Tarih,
                                  siparis.MusteriID,
                                  siparis.UrunID,
                                  siparis.Adet
                              }).ToList();
            dataGridView1.DataSource = siparisler;
            textBoxSiparisNo.Text = "0";
            dataGridView1.ClearSelection();
            metinKutulariniTemizle();
        }

        private void metinKutulariniTemizle()
        {
            textBoxSiparisNo.Text = "0";
            textBoxAdet.Clear();
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            tumKayitlariGoster();

            var musteriler = (from musteri in entities.Musteri
                              select new
                              {
                                  musteri.MusteriID,
                                  musteri.Ad,
                                  musteri.Soyad
                              }).ToList();
            comboBoxMusteriID.ValueMember = "MusteriID";
            comboBoxMusteriID.DisplayMember = "Ad" + "Soyad";
            comboBoxMusteriID.DataSource = musteriler;

            var urunler = (from urun in entities.Urun
                              select new
                              {
                                  urun.UrunID,
                                  urun.Adi,
                                  urun.Fiyati
                              }).ToList();
            comboBoxUrunID.ValueMember = "UrunID";
            comboBoxUrunID.DisplayMember = "Adi" + "Fiyati";
            comboBoxUrunID.DataSource = urunler;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Siparis siparis = new Siparis();
                siparis.Tarih = dateTimePicker1.Value;
                siparis.MusteriID = Convert.ToInt32(comboBoxMusteriID.SelectedValue.ToString());
                siparis.UrunID = Convert.ToInt32(comboBoxUrunID.SelectedValue.ToString());
                siparis.Adet = Convert.ToInt32(textBoxAdet.Text);
                entities.Siparis.Add(siparis);
                entities.SaveChanges();
                MessageBox.Show("Sipariş kaydı eklendi");

                tumKayitlariGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanı işlemleri sırasında hata oluştu, HataKodu: H021 \n + " +
                                ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = dataGridView1.SelectedCells[0].RowIndex;
            textBoxSiparisNo.Text = dataGridView1.Rows[secilenSatır].Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilenSatır].Cells[1].Value.ToString();
            int musteriID = Convert.ToInt32(dataGridView1.Rows[secilenSatır].Cells[2].Value.ToString());
            comboBoxMusteriID.SelectedValue = musteriID;
            int urunID  =Convert.ToInt32(dataGridView1.Rows[secilenSatır].Cells[3].Value.ToString());
            comboBoxUrunID.SelectedValue = urunID;
            textBoxAdet.Text = dataGridView1.Rows[secilenSatır].Cells[4].Value.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int siparisNo = Convert.ToInt32(textBoxSiparisNo.Text);
                var siparis = entities.Siparis.Find(siparisNo);
                siparis.Tarih = dateTimePicker1.Value;
                siparis.MusteriID = Convert.ToInt32(comboBoxMusteriID.SelectedValue.ToString());
                siparis.UrunID = Convert.ToInt32(comboBoxUrunID.SelectedValue.ToString());
                siparis.Adet = Convert.ToInt32(textBoxAdet.Text);
                entities.SaveChanges();
                MessageBox.Show("Sipariş bilgileri güncellendi");
                tumKayitlariGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanı işlemleri sırasında hata oluştu, HataKodu: H022 \n + " +
                                ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int siparisNo = Convert.ToInt32(textBoxSiparisNo.Text);
                var siparis = entities.Siparis.Find(siparisNo);
                entities.Siparis.Remove(siparis);
                entities.SaveChanges();
                MessageBox.Show("Sipariş kaydı silindi");
                tumKayitlariGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanı işlemleri sırasında hata oluştu, HataKodu: H020 \n + " +
                                ex.Message);
            }
        }
    }
}
