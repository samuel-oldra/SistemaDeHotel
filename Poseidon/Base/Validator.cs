using System.Text.RegularExpressions;

namespace Poseidon.Base
{
    public class Validator
    {
        internal static bool EhCEP(string texto)
        {
            return Regex.IsMatch(texto, "^[0-9]{5}-[0-9]{3}$");
        }

        internal static bool EhCPF(string texto)
        {
            return Regex.IsMatch(texto, "^[0-9]{3}\\.[0-9]{3}\\.[0-9]{3}-[0-9]{2}$");
        }

        internal static bool EhIgual(string texto1, string texto2)
        {
            return string.Compare(texto1, texto2) == 0;
        }

        internal static bool EhNuloOuVazio(string texto)
        {
            return string.IsNullOrEmpty(texto);
        }

        internal static bool EhTelefone(string texto)
        {
            return Regex.IsMatch(texto, "^\\([0-9]{2}\\) [0-9]{4}\\.[0-9]{4}$");
        }
    }
}