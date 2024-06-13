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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriForm musteriForm = new MusteriForm();
            musteriForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               UrunForm urunForm = new UrunForm();
            urunForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SiparisForm siparisForm = new SiparisForm();
            siparisForm.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
