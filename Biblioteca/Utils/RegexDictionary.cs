using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;

namespace Biblioteca.Utils
{
    public static class RegexDictionary
    {
        public const string NumberFormat = "^[0-9]*$";
        public const string ISBNFormat = "^[0-9]{13,13}$";
        public const string DNIFormat = "^[0-9]{8,8}$";
        public const string LettersFormat = "^[a-zA-Z]+$";
        public const string LetterAndSymbolsFormat = @"^[!@#$%^&*(),.?\-\+\*:{}|<>a-zA-Z]+$";
    }
}
