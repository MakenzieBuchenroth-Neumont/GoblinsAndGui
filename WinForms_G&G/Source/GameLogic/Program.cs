using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogic;


namespace Dungeons_Diners_Drive_Ins_Dragons_Dives
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controller m_owner = new Controller();

            Application.Run(FormManager.Current);
            // create characters
            Character character = new Character();
     

            m_owner.playGame();
        }
    }
}
