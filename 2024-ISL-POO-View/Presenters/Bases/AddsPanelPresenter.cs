using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_View.Presenters.Layout
{
    public class AddsPanelPresenter : PresenterBase
    {
        public AddsPanelPresenter() : base()
        {
            
        }

        public string LanguageTitle => _lang.AddLanguageGroupBox;
        public string LanguageButton => _lang.AddLanguageButton;
        public string SerieTitle => _lang.AddSerieGroupBox;
        public string SerieButton => _lang.AddSerieButton;
        public string WordsTitle => _lang.AddWordsGroupBox;
        public string GrammaticalGroupTitle => _lang.GrammaticalGroupLabel;
        public IEnumerable<string> GrammaticalGroupList => _grammaticalGroupS.Groups;
        public string WordsButton => _lang.AddWordsButton;
    }
}
