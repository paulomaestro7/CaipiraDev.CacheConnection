using CaipiraDev.Desktop.Forms;
using System;
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
            new Fmr_Connection().ShowDialog();
        }
    }
}
