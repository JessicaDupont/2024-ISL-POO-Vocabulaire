using _2024_ISL_POO_DAL.ADO;
using _2024_ISL_POO_Domain.IModels;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Mapping.Bases
{
    internal interface IMapping<TData, TModel>
    where TData : DbDataReader
    where TModel : IModelBase
    {
        Command Mapping(TModel model, CRUD type);
        TModel Mapping(TData data);
    }
}
