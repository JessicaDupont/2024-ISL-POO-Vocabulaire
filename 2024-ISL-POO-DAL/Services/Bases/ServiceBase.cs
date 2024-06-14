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
        protected ILanguageRepository _languageRepository;
        protected IWordRepository _wordRepository;
        protected IGrammaticalGroupRepository _grammaticalGroupRepository;
        protected ServiceBase()
        {
            _languageRepository = new LanguageRepository();
            _wordRepository = new WordRepository();
            _grammaticalGroupRepository = new GrammaticalGroupRepository();
        }
    }
}
