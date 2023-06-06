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

    [Fact(DisplayName = "Efetua a soma de expressao matematica simples")]
    [Trait("Categoria", "ExpressaoMatematica")]
    public void Retorna_A_Soma_De_Expressao_Matematica_Simples()
    {
        // Arrange
        var expressao = "7/2";
        double esperado = 3.5;

        // Act        
        var resultado = _serviceMock.ExpressaoMatematicaSimples(expressao);

        // Assert
        Assert.Equal(esperado, resultado);
    }
}
