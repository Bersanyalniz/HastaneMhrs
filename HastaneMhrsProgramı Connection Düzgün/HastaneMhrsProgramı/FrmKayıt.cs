using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneMhrsProgramı
{
    public partial class FrmKayıt : Form
    {
        int hastaId;
        public FrmKayıt()
        {
            InitializeComponent();
            ComboDoldur();
        }
        private void ComboDoldur()
        {
            var kategories = DbHelper.GetKategoriList().ToArray();
            CmbBranş.Items.AddRange(kategories);
        }

        private void FrmKayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CmbBranş.Text != "" && comboBox1.Text != "" &&txtAd.Text != "" &&txtSoyad.Text !="")
            {
                var Hastane = new Randevu
                {
                    HastaId = hastaId,
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Tarih = dateTimePicker1.Value,
                    Branş = CmbBranş.Text,
                    Doktor = comboBox1.Text,
                    Aciklama = AciklamaTb.Text
                };
                DbHelper.AddRandevu(Hastane);
                Close();
                MessageBox.Show("Kaydınız Oluşturulmuştur");
            }
            else
            {
                MessageBox.Show("Gerekli Değerleri Giriniz");
            }
        }

        private void CmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            var brans = CmbBranş.Text;
            var Doktorlar = DbHelper.GetDoktorList(brans).ToArray();
            comboBox1.Items.AddRange(Doktorlar);
        }
    }
}
