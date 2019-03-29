using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDados
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void btn_access_Click(object sender, EventArgs e)
        {
            Form frm = new FSQL();
            frm.Show();
        }
    }
}
