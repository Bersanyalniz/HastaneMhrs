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
    public partial class frmPoliklinikEkle : Form
    {
        public frmPoliklinikEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1==null)
            {
                MessageBox.Show("Bir Değer Giriniz");
            }
            else
            {
                var Hastane = new Randevu
                {
                    Ad = textBox1.Text,
                };
                DbHelper.AddPoliklinik(Hastane);
                Close();
                MessageBox.Show("Kaydınız Oluşturulmuştur");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
