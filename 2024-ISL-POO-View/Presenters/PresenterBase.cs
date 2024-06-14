using _2024_ISL_POO_DAL.Services;
using _2024_ISL_POO_DAL.Services.Bases;
using _2024_ISL_POO_View.Lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_View.Presenters
{
    public abstract class PresenterBase
    {
        protected readonly ILang _lang;
        protected ILanguageService _languageS;
        protected IWordsService _wordsS;
        protected IGrammaticalGroupService _grammaticalGroupS;
        protected PresenterBase()
        {
            _lang = new EN();
            //services
            this._languageS = new LanguagesService();
            this._wordsS = new WordsService();
            this._grammaticalGroupS = new GrammaticalGroupService();
        }
    }
}
