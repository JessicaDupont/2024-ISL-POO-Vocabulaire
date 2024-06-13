using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.ADO.DB
{
    public class TWords : ITable
    {
        public string NomTable => "words";
        public string ChampId => "id";
        public string ChampName => "name";
        public string ChampGrammaticalGroup => "grammatical_group";
        public string ChampIdLanguage => "id_language";
    }
}
