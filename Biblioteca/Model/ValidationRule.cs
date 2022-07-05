using System;

namespace Biblioteca.Utils
{
	public class ValidationRule<T>
	{
		public string ErrorMessage { get; private set; }
		public Predicate<T> Predicate { get; private set; }

		public ValidationRule(string errorMessage, Predicate<T> predicate)
        {
            ErrorMessage = errorMessage;
            Predicate = predicate;
        }

		public bool CheckIsValid(T value)
		{
			return Predicate(value);
		}
	}
}
