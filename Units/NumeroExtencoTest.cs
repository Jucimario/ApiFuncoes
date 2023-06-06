using ApiFuncoes.Services.V1;

namespace Units;

public class NumeroExtencoTest
{
    private readonly TestMock _testMock;

    private readonly NumeroExtencoService _serviceMock;

    public NumeroExtencoTest()
    {
        _testMock = new TestMock();
        _serviceMock = _testMock.ObterInstanciaMock<NumeroExtencoService>();
    }

    [Theory(DisplayName = "Retorna numero por extenso")]
    [InlineData(1, "Um")]
    [InlineData(10, "Dez")]
    [InlineData(100, "Cem")]
    [InlineData(130, "Cento e Trinta")]
    [InlineData(1000000, "Um Milhão")]
    [InlineData(2000000, "Dois Milhões")]
    [InlineData(2536253652, "Dois Bilhões e Quinhentos e Trinta e Seis Milhões e Duzentos e Cinquenta e Três Mil e Seiscentos e Cinquenta e Dois")]
    [Trait("Categoria", "NumeroExtenso")]
    public void Retorna_Numero_Por_Extenso(long numero, string esperado)
    {
        // Arrange + Act
        var resultado = _serviceMock.NumeroExtenso(numero);

        // Assert        
        Assert.Equal(esperado, resultado);
    }
}
