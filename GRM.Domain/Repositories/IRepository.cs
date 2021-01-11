using System;
using System.Collections.Generic;
using System.Text;

namespace GRM.Domain.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
