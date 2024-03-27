using System.Text.RegularExpressions;

namespace PruebaTecnica.Validadores
{
    public class ValidateEmail
    {
        public static bool Validate(string email)
        {
            string regularExp = @"^[\w\-.]+@([\w-]+\.)+[\w-]{2,}$";

            Regex regex = new Regex(regularExp);
            return regex.IsMatch(email);
        }
    }
}
