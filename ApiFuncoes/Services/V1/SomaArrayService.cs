using ApiFuncoes.Services.V1.Interfaces;

namespace ApiFuncoes.Services.V1;

public class SomaArrayService : ISomaArrayService
{
    public long SomaArray(long[] numeros)
    {
        if (numeros.Length < 1) throw new Exception($"Não há valores suficiente para efetuar o calculo.");

        if (numeros.Length > 1000000)
        {
            throw new Exception($"Quantidade de valores excede o limite permitido pela função, favor contate o administrador");
        }

        return EfetuaSomaArray(numeros);
    }

    private static long EfetuaSomaArray(long[] numeros)
    {
        return numeros.Sum();
    }
}
