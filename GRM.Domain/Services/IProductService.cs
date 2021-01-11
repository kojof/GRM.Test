using System;
using System.Collections.Generic;
using System.Text;
using GRM.Domain.Entities;
using GRM.Domain.Filter;

namespace GRM.Domain.Services
{
    public interface IProductService
    {
        IEnumerable<MusicContract> Search(SearchFilter searchFilter);
    }

}
