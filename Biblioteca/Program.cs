using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.View;
using Biblioteca.Controller;

namespace Biblioteca
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DataBase.Init();
            //DataBase.Clear();  quieres resetear la base de datos? usa descomenta esto
            DataBase.ChargeData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ViewMediator.Init(new BibliotecaController());
            Application.Run(ViewMediator.Operaciones);
        }
    }
}
