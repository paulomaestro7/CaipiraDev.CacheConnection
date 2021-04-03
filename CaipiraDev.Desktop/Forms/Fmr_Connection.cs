﻿using CaipiraDev.CacheConnection.Controller.Interface;
using CaipiraDev.Util;
using System.Windows.Forms;

namespace CaipiraDev.Desktop.Forms
{
    public partial class Fmr_Connection : Form
    {
        private readonly ICacheConnection _iCacheConnection;
        public Fmr_Connection(ICacheConnection ICacheConnection)
        {
            _iCacheConnection = ICacheConnection;
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

        private void Txt_Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_Test_Click(object sender, System.EventArgs e)
        {
            _iCacheConnection.ConnectionString = Txt_Address.Text;
            _iCacheConnection.ConnectionStringPort = int.Parse(Txt_Port.Text);
            _iCacheConnection.User = Txt_User.Text;
            _iCacheConnection.Password = Txt_Password.Text;
            _iCacheConnection.CacheConnection();
            if (_iCacheConnection.Connection.IsConnected)
                MessageBox.Show(string.Format(MessageDefault.TestConnectionOk, Txt_Name.Text));
        }
    }
}
