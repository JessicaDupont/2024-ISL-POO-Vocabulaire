using _2024_ISL_POO_DAL.Repositories;
using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Services.Bases
{
    public abstract class ServiceBase
    {
        protected ILanguageRepository LanguageRepository;
        protected IWordRepository WordRepository;
        protected IGrammaticalGroupRepository GrammaticalGroupRepository;
        protected ServiceBase()
        {
            LanguageRepository = new LanguageRepository();
            WordRepository = new WordRepository();
            GrammaticalGroupRepository = new GrammaticalGroupRepository();
        }
    }
}
