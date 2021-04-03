using CaipiraDev.Desktop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaipiraDev.Desktop
{
    public partial class Fmr_View : Form
    {
        public Fmr_View()
        {
            InitializeComponent();
        }

        private void Btn_ConnectRedis_Click(object sender, EventArgs e)
        {
            new Fmr_Connection().Show();
        }
    }
}
