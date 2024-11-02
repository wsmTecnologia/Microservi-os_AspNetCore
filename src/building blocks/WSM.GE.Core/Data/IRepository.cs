using WSM.GE.Core.DomainObjects;

namespace WSM.GE.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        
    }
}