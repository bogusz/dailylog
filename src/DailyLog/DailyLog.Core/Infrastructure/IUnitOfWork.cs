using System;
namespace DailyLog.Core.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        void Rollback();
    }
}
