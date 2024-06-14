using _2024_ISL_POO_DAL.ADO.DB;
using _2024_ISL_POO_Domain.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_ISL_POO_View.Presenters.Home
{
    internal class HomePresenter : PresenterBase
    {
        public HomePresenter() : base()
        {
            
        }
        public string NbWords => _lang.NumberOfWordsSelectedLabel(ListViewWords.Length);
        public string WordsTitle => _lang.WordsListLabel;
        public string TraductionTitle => _lang.WordsTraductionListLabel;
        public string GrammaticalGroupTitle => _lang.GrammaticalGroupLabel;
        public string SeriesLabel => _lang.SeriesListLabel;
        public ListViewItem[] ListViewWords
        {
            get 
            {
                IEnumerable<IWord> wordsList = _wordsS.Words;
                List<ListViewItem> wordsItems = new List<ListViewItem>();
                foreach (IWord word in wordsList)
                {
                    ListViewItem newWord = new ListViewItem(word.Name);
                    string temp = "";
                    foreach (IWord trad in word.Traduction)
                    {
                        temp += trad.Name + ", ";
                    }
                    newWord.SubItems.Add(temp);
                    newWord.SubItems.Add(word.Group.Name);
                    temp = "";
                    foreach (ISerie serie in word.Series)
                    {
                        temp += serie.Name + ", ";
                    }
                    newWord.SubItems.Add(temp);
                    wordsItems.Add(newWord);
                }
                return wordsItems.ToArray();
            }
        }
    }
}
