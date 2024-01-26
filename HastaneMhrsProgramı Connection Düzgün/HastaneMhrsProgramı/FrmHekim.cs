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
    public partial class FrmHekim : Form
    {
        public FrmHekim()
        {
            InitializeComponent();
            ComboDoldur();
            //EnterDegiskeni(e);
        }
        private void ComboDoldur()
        {
            var kategories = DbHelper.GetKategoriList().ToArray();
            CmbBranş.Items.AddRange(kategories);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && CmbBranş.Text !=null)
            {
                var Hekim = new Hekim
                {
                    Ad = textBox1.Text,
                    Soyad = textBox2.Text,
                    Branş = CmbBranş.Text
                };
                DbHelper.AddHekim(Hekim);
                Close();
                MessageBox.Show("Kaydınız Oluşturulmuştur");
            }
            else
            {
                MessageBox.Show("Gerekli Değerleri Giriniz");
            }
        }
        //private void EnterDegiskeni(KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        button1.PerformClick();
        //        e.SuppressKeyPress = true;
        //    }
        //}Neden Olmuyor ??
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
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

        private void CmbBranş_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
