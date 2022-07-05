using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Biblioteca.Utils
{
	public static class Validator
    {
		public static bool TryCheckTextboxRule(TextBox textBox, ValidationRule<TextBox> validationRule, ErrorProvider errorProvider) 
		{
			if (!validationRule.CheckIsValid(textBox))
            {
				errorProvider.SetError(textBox, validationRule.ErrorMessage);
				return false;
            }
			return true;
		}
	}
	
}
