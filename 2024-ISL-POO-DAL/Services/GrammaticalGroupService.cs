using _2024_ISL_POO_DAL.Services.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Services
{
    public class GrammaticalGroupService : ServiceBase, IGrammaticalGroupService
    {
        public GrammaticalGroupService() : base()
        {
            
        }

        public IEnumerable<string> Groups => GrammaticalGroupRepository.Read();
    }
}
