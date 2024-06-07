using _2024_ISL_POO_Domain.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Repositories.Bases
{
    public interface IRepository<TModel, Tid> :
        IRepositoryCreate<TModel, Tid>,
        IRepositoryRead<TModel, Tid>,
        IRepositoryUpdate<TModel, Tid>,
        IRepositoryDelete<TModel, Tid>,
        IRepositorySearch<TModel, Tid>
        where TModel : IModelBase
    {
    }
}
