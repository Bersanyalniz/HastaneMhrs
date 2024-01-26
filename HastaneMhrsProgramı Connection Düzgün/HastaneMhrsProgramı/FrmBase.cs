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
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //private void VeriAl()
        //{
        //    var RandevuList = DbHelper.GetRandevuList();
        //    bsHarcama.DataSource = RandevuList;
        //}
        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmHekim();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmKayıt();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void mevcutRandevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmRandevuSorgu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmPoliklinikEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Uygulama MHRS.gov.tr Tarafından Geliştirilmiş bir Uygulamadır");
        }
    }
}
