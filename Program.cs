using AracKiralama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralama
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Form1'in doğru ad alanı kullanılarak başlatılması
            Application.Run(new Form1()); // Eğer Form1 başka bir namespace'te ise, burada adıyla birlikte namespace'i belirtin.
        }
    }
}
