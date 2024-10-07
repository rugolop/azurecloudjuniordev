// dotnet add DebugAppTest\DebugAppTest.csproj reference DebugApp\DebugApp.csproj

namespace CalculadoraSpace;

[TestClass]
public class CalculadoraTest
{
    [TestMethod]
    public void Suma_5_3_y_da_8()
    {
        //Arrange
        Calculadora calculadora = new Calculadora();
        int num1 = 5;
        int num2 = 3;
        int resultadoEspearado = 8;

        int resultado = calculadora.Suma(num1, num2);

        Assert.AreEqual(resultadoEspearado, resultado);
    }
}