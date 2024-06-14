using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_View.Lang
{
    public class EN : ILang
    {
        public string HomeWindow => "Home";

        public string AddLanguageGroupBox => "Add language";

        public string AddLanguageButton => "Add language";

        public string AddSerieGroupBox => "Add serie";

        public string AddSerieButton => "Add serie";

        public string AddWordsGroupBox => "Add words";

        public string AddWordsButton => "Add words";

        public string FiltresGroupBox => "Filters";

        public string Language1Label => "Main language";

        public string Language2Label => "Second language";

        public string SerieLabel => "Serie";

        public string GrammaticalGroupLabel => "Grammatical group";

        public string StatsLabel => "Stats";

        public string NoTestedCheckBox => "No tested";

        public string FailsCheckBox => ">= 50% fails";

        public string TestsGroupBox => "Test";

        public string NumbreOfWordsForTestLabel => "Number of words";

        public string TestButton => "Run test";

        public string StatsGroupBox => "Stats";

        public string NumberOfWordsSelectedLabel(int number) 
        {
            return number > 1 ? number + " words" : number + "word";
        }

        public string WordsListLabel => "Word";

        public string WordsTraductionListLabel => "Traduction";

        public string SeriesListLabel => "Series";
    }
}
