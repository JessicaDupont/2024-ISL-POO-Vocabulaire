using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Services.Bases
{
    public interface IGrammaticalGroupService
    {
        IEnumerable<string> Groups { get; }
    }
}
