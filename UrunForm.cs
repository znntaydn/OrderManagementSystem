using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityFrameworkPrj
{
    public partial class UrunForm : Form
    {
        ProjelerVTEntities entities = new ProjelerVTEntities();

        public UrunForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tumKayitlariGoster();
        }

        private void tumKayitlariGoster()
        {
            //var urunler = entities.Urun.ToList();
            // dataGridView1.DataSource = urunler;

            var urunler = (from urun in entities.Urun
                              select new
                              {
                                  urun.UrunID,
                                  urun.Adi,
                                  urun.Fiyati    

                              }).ToList();
            dataGridView1.DataSource = urunler;


            dataGridView1.ClearSelection();
            metinKutulariniTemizle();
        }

        private void metinKutulariniTemizle()
        {
            textBoxAdi.Clear();
            textBoxFiyati.Clear();
            textBoxUrunID.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Adi = textBoxAdi.Text;
            urun.Fiyati = Convert.ToInt32 (textBoxFiyati.Text);
            
            try
            {
                entities.Urun.Add(urun);
                entities.SaveChanges();
                MessageBox.Show("Ürün kaydı eklendi");
                tumKayitlariGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanı işlemleri sırasında hata oluştu, HataKodu: H010 \n + " +
                                ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = dataGridView1.SelectedCells[0].RowIndex;
            textBoxUrunID.Text = dataGridView1.Rows[secilenSatır].Cells[0].Value.ToString();
            textBoxAdi.Text = dataGridView1.Rows[secilenSatır].Cells[1].Value.ToString();
            textBoxFiyati.Text = dataGridView1.Rows[secilenSatır].Cells[2].Value.ToString();

        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            tumKayitlariGoster();
            textBoxUrunID.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int urunID = Convert.ToInt32(textBoxUrunID.Text);
                var urun = entities.Urun.Find(urunID);
                entities.Urun.Remove(urun);
                entities.SaveChanges();
                MessageBox.Show("Ürün kaydı silindi");
                tumKayitlariGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanı işlemleri sırasında hata oluştu, HataKodu: H011 \n + " +
                                ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int urunID = Convert.ToInt32(textBoxUrunID.Text);
                var urun = entities.Urun.Find(urunID);
                urun.Adi = textBoxAdi.Text;
                urun.Fiyati = Convert.ToInt32(textBoxFiyati.Text);
                entities.SaveChanges();
                MessageBox.Show("Ürün bilgileri güncellendi");
                tumKayitlariGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanı işlemleri sırasında hata oluştu, HataKodu: H012 \n + " +
                                ex.Message);
            }

        } 
    }
}
