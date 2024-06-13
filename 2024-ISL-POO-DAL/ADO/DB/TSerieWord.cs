using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.ADO.DB
{
    public class TSerieWord : ITable
    {
        public string NomTable => "serie_word";
        public string ChampIdWord1 => "id_word";
        public string ChampIdWord2 => "id_serie";
    }
}
