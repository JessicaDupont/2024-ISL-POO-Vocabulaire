using _2024_ISL_POO_DAL.ADO;
using _2024_ISL_POO_DAL.Mapping.Bases;
using _2024_ISL_POO_Domain.IModels;
using _2024_ISL_POO_Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Mapping
{
    internal class LanguageMapping : IMapping<DbDataReader, ILanguage>
    {
        public Command Mapping(ILanguage model, CRUD type)
        {
            throw new NotImplementedException();
        }

        public ILanguage Mapping(DbDataReader data)
        {
            ILanguage result = new Language((int)data["Id"], data["name"].ToString());
            return result;
        }
    }
}
