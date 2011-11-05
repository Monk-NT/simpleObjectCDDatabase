using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cddb.GUI;
using cddb.cddbDAO;

namespace cddb
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            SimpleAccessControl.getInstance().openDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            SimpleAccessControl.getInstance().closeDatabase();
        }
    }
}
