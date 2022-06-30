using System;
using Biblioteca.Model;
using Biblioteca.Utils;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Biblioteca.Controller
{
    public class SociosController
    {
        public MessageResult AñadirNuevoSocioComun(string nombre, string apellido, string numeroIdentificador)
        {
            if (!ulong.TryParse(numeroIdentificador, out ulong SocioID))
            {
                return new MessageResult("El Numero de identificación no corresponde al formato requerido, utilice unicamente numeros positivos para identificar un socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (DataBase.Socios.ContainsKey(SocioID))
            {
                return new MessageResult("Ya existe un socio con ese número de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Socio socio = new SocioComun(nombre, apellido, SocioID);
            DataBase.Socios.Add(socio.NumeroDeIdentificacion, Tuple.Create("Común", socio));
            DataBase.Socios.Update();

            return new MessageResult($"El Socio {socio.Nombre} {socio.Apellido} ha sido añadido", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public MessageResult AñadirNuevoSocioVip(string nombre, string apellido, string numeroIdentificador, string cuotaMensual)
        {
            if (!ulong.TryParse(numeroIdentificador, out ulong SocioID))
            {
                return new MessageResult("El Numero de identificación no corresponde al formato requerido, utilice unicamente numeros positivos para identificar un socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (DataBase.Socios.ContainsKey(SocioID))
            {
                return new MessageResult("Ya existe un socio con ese número de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!decimal.TryParse(cuotaMensual, out decimal cuotaMensualParsed))
            {
                return new MessageResult("La cuota mensual debe ser expresada como decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Socio socio = new SocioVip(nombre, apellido, SocioID, cuotaMensualParsed);
            DataBase.Socios.Add(socio.NumeroDeIdentificacion, Tuple.Create("VIP", socio));
            DataBase.Socios.Update();
            return new MessageResult($"El Socio {socio.Nombre} {socio.Apellido} ha sido añadido", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<string[]> ObtenerListadoSocios()
        {
            List<string[]> filas = new List<string[]>();

            int i = 1;
            foreach (var key in DataBase.Socios.Keys)
            {
                string nombre = DataBase.Socios[key].Item2.Nombre;
                string apellido = DataBase.Socios[key].Item2.Apellido;
                ulong numeroDeIdentificacion = key;
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
