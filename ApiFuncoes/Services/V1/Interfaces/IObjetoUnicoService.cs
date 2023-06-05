namespace ApiFuncoes.Services.V1.Interfaces;

public interface IObjetoUnicoService<T>
{
    List<T> RemoverDuplicados(List<T> listaObjeto);    
}
