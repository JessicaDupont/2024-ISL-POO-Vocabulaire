using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_View.Lang
{
    public interface ILang
    {
        string HomeWindow { get; }
        string AddLanguageGroupBox { get; }
        string AddLanguageButton { get; }
        string AddSerieGroupBox { get; }
        string AddSerieButton { get; }
        string AddWordsGroupBox { get; }
        string AddWordsButton { get; }
        string FiltresGroupBox { get; }
        string Language1Label { get; }
        string Language2Label { get; }
        string SerieLabel { get; }
        string GrammaticalGroupLabel { get; }
        string StatsLabel { get; }
        string NoTestedCheckBox { get; }
        string FailsCheckBox { get; }
        string TestsGroupBox { get; }
        string NumbreOfWordsForTestLabel { get; }
        string TestButton { get; }
        string StatsGroupBox { get; }
        string NumberOfWordsSelectedLabel(int number);
        string WordsListLabel { get; }
        string WordsTraductionListLabel { get; }
        string SeriesListLabel { get; }
    }
}
