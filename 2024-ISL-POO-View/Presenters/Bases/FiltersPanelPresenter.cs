using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_Domain.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_View.Presenters.Layout
{
    public class FiltersPanelPresenter : PresenterBase
    {
        public string FiltersTitle => _lang.FiltresGroupBox;
        public string Language2Title => _lang.Language2Label;
        public IEnumerable<ILanguage> LanguageList 
        {
            get => _languageS.Languages;
            set 
            { 
                //TODO add language
            }
        }
        public string SerieTitle => _lang.SerieLabel;
        public string GrammaticalGroupTitle => _lang.GrammaticalGroupLabel;
        public IEnumerable<string> GrammaticalGroupList => _grammaticalGroupS.Groups;
        public string TestedTitle => _lang.StatsLabel;

        internal void AddFilter(Filter filter)
        {
            _wordsS.AddFilter(filter);
        }
    }
}
