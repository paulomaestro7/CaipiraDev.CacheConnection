using CaipiraDev.Desktop.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CaipiraDev.Desktop
{
    public partial class Fmr_View : Form
    {
        private readonly IServiceProvider _iServiceProvider;
        public Fmr_View(IServiceProvider IServiceProvider)
        {
            _iServiceProvider = IServiceProvider;
            InitializeComponent();
        }

        private void Btn_ConnectRedis_Click(object sender, EventArgs e)
        {
            var fmrConnection = _iServiceProvider.GetRequiredService<Fmr_Connection>();
            fmrConnection.ShowDialog();
        }
    }
}
