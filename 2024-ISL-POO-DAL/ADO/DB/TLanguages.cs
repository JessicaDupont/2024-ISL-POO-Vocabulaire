using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.ADO.DB
{
    internal class TLanguages : ITable
    {
        public string NomTable => "languages";
        public string ChampId => "id";
        public string ChampName => "name";
    }
}
