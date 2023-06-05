using ApiFuncoes.Services.V1.Interfaces;
using NCalc;

namespace ApiFuncoes.Services.V1;

public class ExpressaoMatematicaService : IExpressaoMatematicaService
{
    private List<char> Operadores = new() { '+', '-', '*', '/' };

    public double ExpressaoMatematicaSimples(string expressao)
    {
        foreach (var item in expressao.Replace(" ", "+"))
        {
            if (!char.IsDigit(item) && !Operadores.Contains(item))               
                throw new Exception($"Expressão não permitida.");              
        }

        return CalcularExpressaoMatematica(expressao);
    }

    private static double CalcularExpressaoMatematica(string expressao)
    {
        try
        {
            var expr = new Expression(expressao.Replace(" ","+"));
            return (double)expr.Evaluate();
        }
        catch (Exception)
        {
            throw new Exception($"Falha ao efetuar a expressão, favor informar ao administrador.");
        }
    }
}
