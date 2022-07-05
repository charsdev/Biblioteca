using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.View;
using Biblioteca.Controller;
using System.Runtime.InteropServices;

namespace Biblioteca
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DataBase.Init();
            DataBase.ChargeData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ViewMediator());
        }
    }
}


