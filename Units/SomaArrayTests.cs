using ApiFuncoes.Services.V1;

namespace Units;

public class SomaArrayTests
{
    private readonly TestMock _testMock;

    private readonly SomaArrayService _serviceMock;

    public SomaArrayTests()
    {
        _testMock = new TestMock();
        _serviceMock = _testMock.ObterInstanciaMock<SomaArrayService>();
    }

    [Fact(DisplayName = "Efetua a soma do array")]
    [Trait("Categoria", "SomaArray")]
    public void Retorna_A_Soma_Todos_Os_Valores_Do_Array()
    {
        // Arrange
        var numeros = new long[] { 1, 2, 3, 4, 5 };
        long esperado = 15;

        // Act        
        var resultado = _serviceMock.SomaArray(numeros);

        // Assert
        Assert.Equal(esperado, resultado);
    }

    [Fact(DisplayName = "Valida a quantidade de itens no array em um milhão")]
    [Trait("Categoria", "SomaArray")]
    public void Retorna_Uma_Exeception_De_Limite_Maximo_Do_array()
    {
        // Arrange
        long[] numeros = new long[1000001];
        string esperado = "Quantidade de valores excede o limite permitido pela função, favor contate o administrador";

        for (int i = 0; i < 1000001; i++)
        {
            numeros[i] = i + 1;
        }

        // Act
        var ex = Assert.Throws<Exception>(() => _serviceMock.SomaArray(numeros));

        // Assert
        Assert.Equal(esperado, ex.Message);
    }

    [Fact(DisplayName = "Valida o array quando for vazio")]
    [Trait("Categoria", "SomaArray")]
    public void SomaArray_ValidaArrayNulo()
    {
        // Arrange
        long[] numeros = Array.Empty<long>();
        string esperado = "Não há valores suficiente para efetuar o calculo.";
        // Act
        var ex = Assert.Throws<Exception>(() => _serviceMock.SomaArray(numeros));

        // Assert
        Assert.Equal(esperado, ex.Message);
    }
}