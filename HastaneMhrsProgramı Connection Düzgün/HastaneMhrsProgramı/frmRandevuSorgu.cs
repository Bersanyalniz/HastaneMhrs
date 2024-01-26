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
    public partial class frmRandevuSorgu : Form
    {
        public frmRandevuSorgu()
        {
            InitializeComponent();
        }

        private void frmRandevuSorgu_Load(object sender, EventArgs e)
        {
            VeriAl();
        }
        private void VeriAl()
        {
            var RandevuList = DbHelper.GetRandevuList();
            bsHarcama.DataSource = RandevuList;
        }
    }
}
