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
    internal class WordMapping : IMapping<DbDataReader, IWord>
    {
        private readonly TWords _table = new TWords();
        public Command Mapping(IWord model, CRUD type)
        {
            Command result;
            switch (type)
            {
                case CRUD.List:
                    result = new Command("select * from "+_table.NomTable+";", false);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return result;
        }

        public IWord Mapping(DbDataReader data)
        {
            IWord result = new Word(
                (int)data[_table.ChampId], 
                data[_table.ChampName].ToString(), 
                data[_table.ChampGrammaticalGroup].ToString(),
                new Language((int)data[_table.ChampIdLanguage])
                );
            return result;
        }
    }
}
