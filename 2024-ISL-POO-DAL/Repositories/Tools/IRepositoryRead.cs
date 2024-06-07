using _2024_ISL_POO_Domain.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Repositories.Bases
{
    public interface IRepositoryRead<TModel, Tid>
        where TModel : IModelBase
    {
        TModel Read(Tid id);
        IEnumerable<TModel> Read();
    }
}
