using Moq.AutoMock;

namespace Units;

public class TestMock : IDisposable
{
    private readonly AutoMocker _mocker = new AutoMocker();

    public T ObterInstanciaMock<T>() where T : class => _mocker.CreateInstance<T>();

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
