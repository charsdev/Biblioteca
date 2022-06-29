using Biblioteca.Utils;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Biblioteca.Model
{
    public static class DataBase
    {
        public static Socios Socios { get; set; }
        public static Libros Libros { get; set; }
        public static Prestamos Prestamos { get; set; }
        public static Historial Historial { get; set; }

        public static void Init()
        {
            Socios = new Socios();
            Libros = new Libros();
            Prestamos = new Prestamos();
            Historial = new Historial();
        }

        //carga datos desde los archivos xml
        public static void ChargeData()
        {
            Socios = Socios.Deserialize(Socios.File);
            Libros = Libros.Deserialize(Libros.File);
            Prestamos = Prestamos.Deserialize(Prestamos.File);
            Historial = Historial.Deserialize(Historial.File);
        }

        //borra toda la base de datos y la resetea a 0 unicamente para debug
        public static void Clear()
        {
            Socios.Clear();
            Libros.Clear();
            Prestamos.Clear();
            Historial.Clear();
            UpdateAll();
        }

        public static void UpdateAll()
        {
            Socios.Update();
            Libros.Update();
            Prestamos.Update();
            Historial.Update();
        }

    }

}


  