using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YgoProPatcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new YgoProPatcher());
            }catch(Exception e)
            {
                MessageBox.Show("UNEXPECTED ERROR HAS OCCURED IN THE YGOPROPATCHER!\nIF YOU SEE THIS MESSAGE AGAIN, PLEASE SEND SCREENSHOT OF THIS MESSAGE TO THE DEVELOPER!\n\n"+e.Message+"\n"+e.ToString(),"Unexpected Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
