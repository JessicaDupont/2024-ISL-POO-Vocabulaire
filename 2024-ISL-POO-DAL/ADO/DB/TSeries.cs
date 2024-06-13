using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.ADO.DB
{
    public class TSeries : ITable
    {
        public string NomTable => "series";
        public string ChampId => "id";
        public string ChampName => "name";
    }
}
