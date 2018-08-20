using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftScheduler_API.Repository
{
    public interface IEmployeeRepository<TEntity, U> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(U id);
        void Create();
        void Update();
        void Delete();
    }
}
