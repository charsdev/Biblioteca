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
            DataBase.Clear(); // Desea que persista la base de datos? Comente esta linea
            DataBase.ChargeData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ViewMediator viewMediator = new ViewMediator();
            Application.Run(viewMediator.VistaActual);
        }
    }
}


