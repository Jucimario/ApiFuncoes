using ApiFuncoes.Services.V1;

namespace Units;

public class ExpressaoMatematicaTest
{
    private readonly TestMock _testMock;

    private readonly ExpressaoMatematicaService _serviceMock;

    public ExpressaoMatematicaTest()
    {
        _testMock = new TestMock();
        _serviceMock = _testMock.ObterInstanciaMock<ExpressaoMatematicaService>();
    }

    [Theory(DisplayName = "Efetua a soma de expressao matematica simples")]
    [InlineData("7/2", 3.5)]
    [InlineData("7*2", 14)]
    [InlineData("7+2", 9)]
    [InlineData("7-2", 5)]
    [InlineData("7/2+3*4-2", 13.5)]
    [InlineData("7/2+3*4-2/2", 14.5)]
    [InlineData("7/2+3*4-2/2+1", 15.5)]
    [InlineData("7/2+3*4-2/2+1-1", 14.5)]
    [InlineData("7/2+3*4-2/2+1-1+1", 15.5)]
    [InlineData("7/2+3*4-2/2+1-1+1-1", 14.5)]
    [InlineData("7/2+3*4-2/2+1-1+1-1+1", 15.5)]
    [Trait("Categoria", "ExpressaoMatematica")]
    public void Retorna_A_Soma_De_Expressao_Matematica_Simples(string expressao, double esperado)
    {
        // Arrange + Act        
        var resultado = _serviceMock.ExpressaoMatematicaSimples(expressao);

        // Assert
        Assert.Equal(esperado, resultado);
    }
}
