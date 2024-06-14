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
        private readonly TWords _tableW = new TWords();
        private readonly TWordWord _tableWW = new TWordWord();
        public Command Mapping(IWord model, CRUD type)
        {
            Command result;
            switch (type)
            {
                case CRUD.List:
                    string request =
                        $"select " +
                            $"w.{_tableW.ChampId}, " +
                            $"w.{_tableW.ChampName}, " +
                            $"w.{_tableW.ChampIdLanguage}, " +
                            $"w.{_tableW.ChampGrammaticalGroup}, " +
                            $"w1.{_tableW.ChampId} as tradId, " +
                            $"w1.{_tableW.ChampName} as tradName, " +
                            $"w1.{_tableW.ChampIdLanguage} as tradIdLg, " +
                            $"w1.{_tableW.ChampGrammaticalGroup} as tradGg " +
                        $"from {_tableW.NomTable} w " +
                        $"inner join {_tableWW.NomTable} ww1 on ww1.{_tableWW.ChampIdWord1} = w.{_tableW.ChampId} " +
                        $"left join {_tableW.NomTable} w1 on w1.{_tableW.ChampId} = ww1.{_tableWW.ChampIdWord2} " +
                        $"union " +
                        $"select " +
                            $"w.{_tableW.ChampId}, " +
                            $"w.{_tableW.ChampName}, " +
                            $"w.{_tableW.ChampIdLanguage}, " +
                            $"w.{_tableW.ChampGrammaticalGroup}, " +
                            $"w2.{_tableW.ChampId} as tradId, " +
                            $"w2.{_tableW.ChampName} as tradName, " +
                            $"w2.{_tableW.ChampIdLanguage} as tradIdLg, " +
                            $"w2.{_tableW.ChampGrammaticalGroup} as tradGg " +
                        $"from {_tableW.NomTable} w " +
                        $"inner join {_tableWW.NomTable} ww2 on {_tableWW.ChampIdWord2} = w.{_tableW.ChampId} " +
                        $"left join {_tableW.NomTable} w2 on w2.{_tableW.ChampId} = ww2.{_tableWW.ChampIdWord1} " +
                        $"order by w.{_tableW.ChampName} ASC;";
                    result = new Command(request, false);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return result;
        }

        public IWord Mapping(DbDataReader data)
        {
            IWord result = new Word(
                (int)data[_tableW.ChampId], 
                data[_tableW.ChampName].ToString(), 
                data[_tableW.ChampGrammaticalGroup].ToString(),
                new Language((int)data[_tableW.ChampIdLanguage])
                );
            Word temp = new Word((int)data["tradId"]);
            result.Traduction.Add(temp);
            //TODO serie
            return result;
        }
    }
}
