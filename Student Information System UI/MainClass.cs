using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface
{
    static class MainClass
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeWindows());
        }
    }
}
