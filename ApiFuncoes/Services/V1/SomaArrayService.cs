using ApiFuncoes.Services.V1.Interfaces;

namespace ApiFuncoes.Services.V1;

public class SomaArrayService : ISomaArrayService
{
    public long SomaArray(long[] array)
    {
        if (array.Length < 1) throw new ArgumentNullException(nameof(array));

        if (array.Length > 1000000)
        {
            throw new Exception($"Quantidade de valores excede o limite permitido pela função, favor contate o administrador");
        }

        return EfetuaSomaArray(array);
    }

    private static long EfetuaSomaArray(long[] array)
    {
        return array.Sum();
    }
}
