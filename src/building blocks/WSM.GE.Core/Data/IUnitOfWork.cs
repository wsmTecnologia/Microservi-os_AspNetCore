using System.Threading.Tasks;

namespace WSM.GE.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}