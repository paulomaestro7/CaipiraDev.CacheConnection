using CaipiraDev.CacheConnection.Configuration;
using CaipiraDev.Desktop.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaipiraDev.Desktop
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            services.CacheConnection();
            services.AddScoped<Fmr_View>();
            services.AddScoped<Fmr_Connection>();
            
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var fmrView = serviceProvider.GetRequiredService<Fmr_View>();
                Application.Run(fmrView);
            }
        }
    }
}
