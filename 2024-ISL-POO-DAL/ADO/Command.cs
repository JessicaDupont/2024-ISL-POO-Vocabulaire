using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.ADO
{
    public class Command
    {
        public string CommandText { get; }

        public Dictionary<string, object> Parameters { get; }

        public bool IsStoreProcedure { get; }

        public Command()
        {
            IsStoreProcedure = false;
            Parameters = new Dictionary<string, object>();
        }

        public Command(string commandText, bool isStoreProcedure)
        {
            CommandText = commandText;
            IsStoreProcedure = isStoreProcedure;
            Parameters = new Dictionary<string, object>();
        }

        public void AddParameter(string parameterName, object value)
        {
            Parameters.Add(parameterName, value);
        }
    }
}
