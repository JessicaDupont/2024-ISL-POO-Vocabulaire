using _2024_ISL_POO_DAL.ADO;
using _2024_ISL_POO_DAL.ADO.DB;
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
        private TLanguages _tableLanguages = new TLanguages();
        public Command Mapping(ILanguage model, CRUD type)
        {
            Command result;
            switch (type) 
            {
                case CRUD.List: 
                    result = new Command("select * from " + _tableLanguages.NomTable + ";", false);
                    break;
                default: 
                    throw new NotImplementedException();
            }
            return result;
        }

        public ILanguage Mapping(DbDataReader data)
        {
            ILanguage result = new Language((int)data[_tableLanguages.ChampId], data[_tableLanguages.ChampName].ToString());
            return result;
        }
    }
}
