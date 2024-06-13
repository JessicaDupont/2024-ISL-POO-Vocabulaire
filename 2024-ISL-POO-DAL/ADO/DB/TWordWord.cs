using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.ADO.DB
{
    public class TWordWord : ITable
    {
        public string NomTable => "word_word";
        public string ChampIdWord1 => "id_word1";
        public string ChampIdWord2 => "id_word2";
        public string ChampNbTest => "nb_test";
        public string ChampNbTestFail => "nb_test_fail";
    }
}
