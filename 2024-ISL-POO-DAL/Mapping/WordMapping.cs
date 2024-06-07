using _2024_ISL_POO_DAL.ADO;
using _2024_ISL_POO_DAL.Mapping.Bases;
using _2024_ISL_POO_Domain.IModels;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Mapping
{
    internal class WordMapping : IMapping<DbDataReader, IWord>
    {
        public Command Mapping(IWord model, CRUD type)
        {
            throw new NotImplementedException();
        }

        public IWord Mapping(DbDataReader data)
        {
            throw new NotImplementedException();
        }
    }
}
