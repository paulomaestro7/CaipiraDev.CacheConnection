using System.Windows.Forms;

namespace CaipiraDev.Desktop.Forms
{
    public partial class Fmr_Connection : Form
    {
        public Fmr_Connection()
        {
            InitializeComponent();
        }

        private void Chk_Password_CheckedChanged(object sender, System.EventArgs e)
        {
            if (Chk_Password.Checked)
                Txt_Password.UseSystemPasswordChar = false;
            else
                Txt_Password.UseSystemPasswordChar = true;
        }

        private void Btn_Cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
