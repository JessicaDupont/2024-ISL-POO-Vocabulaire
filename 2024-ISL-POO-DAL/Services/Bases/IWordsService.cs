using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_Domain.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Services.Bases
{
    public interface IWordsService
    {
        IEnumerable<Filter> MyFilters { get; }
        void AddFilter(Filter filter);
        IEnumerable<IWord> Words { get; set; }
    }
}
