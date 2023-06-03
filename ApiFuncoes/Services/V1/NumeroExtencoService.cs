using ApiFuncoes.Services.V1.Interfaces;

namespace ApiFuncoes.Services.V1;

public class NumeroExtencoService : INumeroExtencoService
{
    private readonly string[] unidades =
    {
        "Zero", "Um", "Dois", "Três", "Quatro", 
        "Cinco", "Seis", "Sete", "Oito", 
        "Nove", "Dez", "Onze", "Doze", 
        "Treze", "Quatorze", "Quinze", "Dezesseis", 
        "Dezessete", "Dezoito", "Dezenove"
    };

    private readonly string[] dezenas =
    {
        "Vinte", "Trinta", "Quarenta", 
        "Cinquenta", "Sessenta", "Setenta", 
        "Oitenta", "Noventa"
    };

    private readonly string[] centenas =
    {
        "Cem", "Cento", "Duzentos", "Trezentos",
        "Quatrocentos", "Quinhentos", "Seiscentos",
        "Setecentos", "Oitocentos", "Novecentos"
    };

    public string NumeroExtenso(long numero)
    {
        return ConverterNumeroParaExtenso(numero);
    }

    public string ConverterNumeroParaExtenso(long numero)
    {
        string extenso;
        switch (numero)
        {
            case < 0:
                extenso = "Menos " + ConverterNumeroParaExtenso(Math.Abs(numero));
                break;
            case < 20:
                extenso = unidades[numero];
                break;
            case < 100:
                extenso = dezenas[(numero / 10) - 2] +
                    ((numero % 10 != 0) ? " e " + ConverterNumeroParaExtenso(numero % 10) : "");
                break;
            case 100:
                extenso = centenas[(numero / 100) - 1];
                break;
            case < 1000:
                extenso = centenas[numero / 100] +
                    ((numero % 100 != 0) ? " e " + ConverterNumeroParaExtenso(numero % 100) : "");
                break;
            case < 1000000:
                extenso = ConverterNumeroParaExtenso(numero / 1000) +
                    " Mil" +
                    ((numero % 1000 != 0) ? " e " + ConverterNumeroParaExtenso(numero % 1000) : "");
                break;
            case < 1000000000:
                extenso = ConverterNumeroParaExtenso(numero / 1000000) +
                    $"{(numero / 1000000 == 1 ? " Milhão" : " Milhões")}" +
                    ((numero % 1000000 != 0) ? " e " + ConverterNumeroParaExtenso(numero % 1000000) : "");
                break;
            case < 1000000000000:
                extenso = ConverterNumeroParaExtenso(numero / 1000000000) +
                    $"{(numero / 1000000000 == 1 ? " Bilhão" : " Bilhões")}" +
                    ((numero % 1000000000 != 0) ? " e " + ConverterNumeroParaExtenso(numero % 1000000000) : "");
                break;
            case < 1000000000000000:
                extenso = ConverterNumeroParaExtenso(numero / 1000000000000) +
                    $"{(numero / 1000000000000 == 1 ? " Trilhão" : " Trilhões")}" +
                    ((numero % 1000000000000 != 0) ? " e " + ConverterNumeroParaExtenso(numero % 1000000000000) : "");
                break;
            case < 1000000000000000000:
                extenso = ConverterNumeroParaExtenso(numero / 1000000000000000) +
                    $"{(numero / 1000000000000000 == 1 ? " Quatrilhão" : " Quatrilhões")}" +
                    ((numero % 1000000000000000 != 0) ? " e " + ConverterNumeroParaExtenso(numero % 1000000000000000) : "");
                break;
            default:
                throw new Exception($"Valor Desconhecido, favor informar ao administrador para efetuar a implementação");
        }

        return extenso;
    }
}
