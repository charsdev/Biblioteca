using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Biblioteca.Utils
{
	public static class TextBoxRules
	{
		public static ValidationRule<TextBox> IsNotEmpty = new ValidationRule<TextBox>(
				"El valor no puede estar vacío",
				(x) =>  !string.IsNullOrWhiteSpace(x.Text) && !string.IsNullOrEmpty(x.Text)
				);

		public static ValidationRule<TextBox> OnlyTextRule = new ValidationRule<TextBox>(
				"Solamente se permiten letras",
				(x) => Regex.IsMatch(x.Text.RemoveWhitespace(), RegexDictionary.LettersFormat)
		);

		public static ValidationRule<TextBox> DNIFormatRule = new ValidationRule<TextBox>(
				"Coloque un DNI compuesto unicamente por 8 digitos",
				(x) => Regex.IsMatch(x.Text, RegexDictionary.DNIFormat)
		);


		public static ValidationRule<TextBox> ISBNFormatRule = new ValidationRule<TextBox>(
				"Coloque un Codigo ISBN compuesto unicamente por 13 digitos",
				(x) => Regex.IsMatch(x.Text, RegexDictionary.ISBNFormat)
		);

	}
	
}
