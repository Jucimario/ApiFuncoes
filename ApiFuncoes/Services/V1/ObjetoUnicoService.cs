using ApiFuncoes.Services.V1.Interfaces;

namespace ApiFuncoes.Services.V1;

public class ObjetoUnicoService<T> : IObjetoUnicoService<T>
{   
    public List<T> RemoverDuplicados(List<T> listaObjeto)
    {
        return listaObjeto.Distinct().ToList();             
    }
}
