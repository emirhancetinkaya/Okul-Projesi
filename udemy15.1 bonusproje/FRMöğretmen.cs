using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udemy15._1_bonusproje
{
    public partial class FRMöğretmen : Form
    {
        public FRMöğretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMkulüp fr = new FRMkulüp();
            fr.Show();
        }

        private void btnders_Click(object sender, EventArgs e)
        {
            FrmDersler fr = new FrmDersler();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmÖğrenci fr = new FrmÖğrenci();
            fr.Show();
        }

        private void btnSınavNotlar_Click(object sender, EventArgs e)
        {
            FrmSınavNotları fr = new FrmSınavNotları();
            fr.Show();
        }
    }
}
