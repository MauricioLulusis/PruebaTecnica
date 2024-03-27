using PruebaTecnica.Validadores;

namespace Test.ValidadoresTest
{
    public class CUITValidationTest
    {
        [Fact]
        public void VerificarCUITValido()
        {
            string cuitValido = "20-26316843-8";
            bool resultado = ValidateCUIT.Validate(cuitValido);
            Assert.True(resultado);
        }

        [Fact]
        public void ValidoElCuitDeMauricio()
        {
            string cuitValido = "20-26316843-8";
            bool resultado = ValidateCUIT.Validate(cuitValido);
            Assert.True(resultado);
        }

        [Fact]
        public void VerificarCUITInvalido()
        {
            string cuitInvalido = "12345678901";
            bool resultado = ValidateCUIT.Validate(cuitInvalido);
            Assert.False(resultado);
        }

        [Fact]
        public void ValidarQueTodosSusCaracteresSeanNumeros()
        {
            string cuitInvalido = "20a193b341.";
            bool resultado = ValidateCUIT.Validate(cuitInvalido);
            Assert.False(resultado);
        }

        [Fact]
        public void VerificarOtroCUITInvalido()
        {
            string cuitValido = "27-37783962-1";
            bool resultado = ValidateCUIT.Validate(cuitValido);
            Assert.False(resultado);
        }

        [Fact]
        public void VerificarOtroCUITInvalido2()
        {
            string cuitValido = "27-377-3962-1";
            bool resultado = ValidateCUIT.Validate(cuitValido);
            Assert.False(resultado);
        }
        [Fact]
        public void CalculoCorrectamenteElDigitoVerificador()
        {
            var entrada = "20-26316843";
            var resultado = ValidateCUIT.CalcularDigitoVerificador(entrada);
            Assert.Equal(8, resultado);
        }
        [Fact]
        public void SiElDigitoEsMayorA9DevolvemosMenos1()
        {
            var entrada = "27-24567892";
            var resultado = ValidateCUIT.CalcularDigitoVerificador(entrada);
            Assert.Equal(-1, resultado);
        }
    }
}