namespace PruebaTecnica.Validadores
{
    public class ValidateCUIT
    {
        public static bool Validate(string cuit)
        {
            bool rv = false;
            int verificador;
            int resultado = 0;

            if (cuit.Length == 13)
            {
                if (cuit.Substring(0, 2).All(char.IsDigit) &&
                    cuit.Substring(2, 1) == "-" &&
                    cuit.Substring(3, 8).All(char.IsDigit) &&
                    cuit.Substring(11, 1) == "-" &&
                    cuit.Substring(12, 1).All(char.IsDigit))
                {
                    resultado = int.Parse(cuit.Substring(12, 1));
                    verificador = ValidateCUIT.CalcularDigitoVerificador(cuit.Substring(0, 11));
                    rv = resultado == verificador;
                }
            }
            return rv;
        }
        public static readonly int[] multiplicadores = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
        public static int CalcularDigitoVerificador(string cuit)
        {
            string cuitSinGuiones = cuit.Replace("-", "").Replace(" ", "");
            char[] cuitArray = cuitSinGuiones.ToCharArray();
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                suma += int.Parse(cuitArray[i].ToString()) * multiplicadores[i];
            }
            int resto = suma % 11;
            int digitoVerificador;

            if (resto == 0)
            {
                digitoVerificador = 0;
            }
            else
            {
                digitoVerificador = 11 - resto;
                if (digitoVerificador > 9)
                {
                    digitoVerificador = -1;
                }
            }
            return digitoVerificador;
        }
    }
}
