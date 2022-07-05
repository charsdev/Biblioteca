using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Biblioteca.Model
{
	public class PrestamoBuilder
	{
		private Ejemplar _ejemplar;
		private Socio _socio;
		private DateTime _fechaDePrestamo;

		public PrestamoBuilder() { }

		public PrestamoBuilder WithEjemplar(Ejemplar ejemplar)
		{
			_ejemplar = ejemplar;
			return this;
		}

		public PrestamoBuilder WithSocio(Socio socio)
		{
			_socio = socio;
			return this;
		}

		public PrestamoBuilder WithFechaDePrestamo(DateTime fechaDePrestamo)
		{
			_fechaDePrestamo = fechaDePrestamo;
			return this;
		}

		public Prestamo Build()
		{
			return new Prestamo
			{
				Ejemplar = _ejemplar,
				Socio = _socio,
				FechaDePrestamo = _fechaDePrestamo
			};
		}
	}
}
