using System;
using System.Threading;
using System.Windows.Forms;

namespace SpeechTelop
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex mutex = new Mutex(false, "SpeechTelop");

            if (mutex.WaitOne(0, false) == false)
            {
                MessageBox.Show("Prevent multiple instances running", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}
