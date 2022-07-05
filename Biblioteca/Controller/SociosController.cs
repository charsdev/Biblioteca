using System;
using Biblioteca.Model;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Biblioteca.Controller
{
    public class SociosController
    {
        public void AñadirNuevoSocio(
            string nombre,
            string apellido,
            string numeroIdentificador,
            bool esVIP,
            decimal cuotaMensual
           )
        {
            if (DataBase.Socios.ContainsKey(numeroIdentificador))
            {
                MessageBox.Show("Ya existe un socio con ese número de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Socio socio = null;
            Tuple<string, Socio> socioWrapper;

            if (esVIP)
            {
                socio = new SocioVip(nombre, apellido, numeroIdentificador, cuotaMensual);
                socioWrapper = Tuple.Create("VIP", socio);
            }
            else
            {
                socio = new SocioComun(nombre, apellido, numeroIdentificador);
                socioWrapper = Tuple.Create("Común", socio);
            }

            DataBase.Socios.Add(socio.NumeroDeIdentificacion, socioWrapper);
            DataBase.Socios.Update();
            MessageBox.Show($"El Socio {socio.Nombre} {socio.Apellido} ha sido añadido", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<string[]> ObtenerListadoSocios()
        {
            List<string[]> filas = new List<string[]>();

            int i = 1;
            foreach (var key in DataBase.Socios.Keys)
            {
                string nombre = DataBase.Socios[key].Item2.Nombre;
                string apellido = DataBase.Socios[key].Item2.Apellido;
                string numeroDeIdentificacion = key;
                string tipo = DataBase.Socios[key].Item1;

                string[] row = new string[]
                {
                    i.ToString(),
                    nombre,
                    apellido,
                    numeroDeIdentificacion.ToString(),
                    tipo
                };
                filas.Add(row);
                i++;
            }
            return filas;
        }
    }
}


