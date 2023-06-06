using ApiFuncoes.Models;
using ApiFuncoes.Services.V1;

namespace Units;

public class ObjetoUnicoTest
{
    private readonly TestMock _testMock;

    private readonly ObjetoUnicoService<Produto> _serviceMock;

    public ObjetoUnicoTest()
    {
        _testMock = new TestMock();
        _serviceMock = _testMock.ObterInstanciaMock<ObjetoUnicoService<Produto>>();
    }

    [Fact(DisplayName = "Retorna objeto unico")]
    [Trait("Categoria", "ObjetoUnico")]
    public void Retorna_Objeto_Unico()
    {
        // Arrange
        List<Produto> listaObjeto = new List<Produto>()
        {
            new Produto { Id = 1, Nome = "Produto 1" },
            new Produto { Id = 2, Nome = "Produto 2" },
            new Produto { Id = 3, Nome = "Produto 3" },
            new Produto { Id = 2, Nome = "Produto 2" },
            new Produto { Id = 5, Nome = "Produto 5" },
            new Produto { Id = 5, Nome = "Produto 5" },
            new Produto { Id = 5, Nome = "Produto 5" },
            new Produto { Id = 6, Nome = "Produto 6" }
        };

        List<Produto> listaObjetoEsperado = new List<Produto>()
        {
            new Produto { Id = 1, Nome = "Produto 1" },
            new Produto { Id = 2, Nome = "Produto 2" },
            new Produto { Id = 3, Nome = "Produto 3" },
            new Produto { Id = 5, Nome = "Produto 5" },
            new Produto { Id = 6, Nome = "Produto 6" }
        };

        // Act
        var resultado = _serviceMock.RemoverDuplicados(listaObjeto);

        // Assert        
        Assert.Equal(listaObjetoEsperado, resultado);
    }
}