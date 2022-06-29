using Biblioteca.Utils;

namespace Biblioteca.Model
{
    public static class DataBase
    {
        public static ColeccionDeSocios Socios { get; set; }
        public static ColeccionDeLibros Libros { get; set; }
        public static ColeccionDePrestamos Prestamos { get; set; }
        public static HisotorialDePrestamosYDevoluciones Historial { get; set; }

        public static void Init()
        {
            Socios = new ColeccionDeSocios();
            Libros = new ColeccionDeLibros();
            Prestamos = new ColeccionDePrestamos();
            Historial = new HisotorialDePrestamosYDevoluciones();
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


  