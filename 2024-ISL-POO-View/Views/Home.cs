using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_DAL.Repositories.Interfaces;
using _2024_ISL_POO_Domain.IModels;
using _2024_ISL_POO_View.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_ISL_POO_View
{
    public partial class Home : Form
    {
        private readonly ILanguageRepository _languageR;
        private readonly IGrammaticalGroupRepository _grammaticalR;
        private readonly IWordRepository _wordR;
        private readonly ILang _lang;
        private List<Filter> _filters;
        private readonly List<string> _filtresChamps = new List<string>();

        public Home(
            ILanguageRepository languageRepository,
            IGrammaticalGroupRepository grammaticalRepository,
            IWordRepository wordRepository
            )
        {
            _lang = new EN();
            //repositories
            this._languageR = languageRepository;
            this._grammaticalR = grammaticalRepository;
            this._wordR = wordRepository;
            this._filters = new List<Filter>();
            //components
            InitializeComponent();
            //panel FILTRES
            this.groupBoxFilters.Text = _lang.FiltresGroupBox;
            //lg 1
            this.labelLanguage1.Text = _lang.Language1Label;
            this.comboBoxLanguage1.DisplayMember = "Name";
            this.comboBoxLanguage1.ValueMember = "Id";
            this.comboBoxLanguage1.DataSource = _languageR.Read();
            this.comboBoxLanguage1.SelectedIndex = 0;
            _filters.Add(new Filter(Filters.language1, this.comboBoxLanguage1.SelectedValue));
            //lg 2
            this.labelLanguage2.Text = _lang.Language2Label;
            this.comboBoxLanguage2.DisplayMember = "Name";
            this.comboBoxLanguage2.ValueMember = "Id";
            this.comboBoxLanguage2.DataSource = _languageR.Read();
            this.comboBoxLanguage2.SelectedIndex = 1;
            _filters.Add(new Filter(Filters.language2, this.comboBoxLanguage2.SelectedValue));
            //serie
            this.labelSelectSerie.Text = _lang.SerieLabel;
            this.comboBoxSerie.Text = "- default"; //TODO
            //_filters.Add(new Filter(Filters.serie, this.comboBoxSerie.SelectedValue));
            //grammatical group
            this.labelSelectGrammaticalGroup.Text = _lang.GrammaticalGroupLabel;
            this.comboBoxSelectGrammaticalGroup.DataSource = _grammaticalR.Read();
            this.comboBoxSelectGrammaticalGroup.SelectedIndex = -1;
            //_filters.Add(new Filter(Filters.grammaticalGroup, this.comboBoxSelectGrammaticalGroup.SelectedValue));
            //tested
            this.labelSelectStats.Text = _lang.StatsLabel;
            this.checkBoxSelectStats0Tests.Checked = true;
            //_filters.Add(new Filter(Filters.noTested, this.checkBoxSelectStats0Tests.Checked));
            this.checkBoxSelectStats50pcFail.Checked = true;
            //_filters.Add(new Filter(Filters.fails, this.checkBoxSelectStats50pcFail.Checked));
            //panel ADD
            this.groupBoxAddLanguage.Hide(); //TODO
            this.groupBoxAddLanguage.Text = _lang.AddLanguageGroupBox;
            this.buttonAddLanguage.Text = _lang.AddLanguageButton;
            this.groupBoxAddSerie.Hide(); //TODO
            this.groupBoxAddSerie.Text = _lang.AddSerieGroupBox;
            this.buttonAddSerie.Text = _lang.AddSerieButton;
            this.groupBoxAddWords.Text = _lang.AddWordsGroupBox;
            this.labelLanguage1.Text = this.comboBoxLanguage1.Text;
            this.labelLanguage2.Text = this.comboBoxLanguage2.Text;
            this.labelGrammaticalGroup.Text = _lang.GrammaticalGroupLabel;
            this.comboBoxGrammaticalGroupAddWord.DataSource = _grammaticalR.Read();
            this.buttonAddWord.Text = _lang.AddWordsButton;
            //panel TESTS
            this.groupBoxTests.Text = _lang.TestsGroupBox;
            this.labelTestNbWords.Text = _lang.NumbreOfWordsForTestLabel;
            this.numericUpDownTestNbWords.Value = 10;
            this.buttonTest.Text = _lang.TestButton;
            //panel STATS
            this.groupBoxStats.Text = _lang.StatsGroupBox;
            //panel LIST
            IEnumerable<IWord> wordsList = _wordR.Search(_filters);
            this.groupBoxWords.Text = _lang.NumberOfWordsSelectedLabel(wordsList.Count());
            this.listViewWords.Columns.Clear();
            this.listViewWords.Columns.Add(_lang.WordsListLabel, 200);
            this.listViewWords.Columns.Add(_lang.WordsTraductionListLabel, 200);
            this.listViewWords.Columns.Add(_lang.GrammaticalGroupLabel, 150);
            this.listViewWords.Columns.Add(_lang.SeriesListLabel, 190);
            List<ListViewItem> wordsItems = new List<ListViewItem>();
            foreach (IWord word in wordsList)
            {
                ListViewItem newWord = new ListViewItem(word.Name);
                string temp = "";
                foreach (IWord trad in word.Traduction()) 
                {
                    temp += trad.Name + ", ";
                }
                newWord.SubItems.Add(temp);
                newWord.SubItems.Add(word.Group.Name);
                temp = "";
                foreach (ISerie serie in word.Series())
                {
                    temp += serie.Name + ", ";
                }
                newWord.SubItems.Add(temp);
                wordsItems.Add(newWord);
            }
            this.listViewWords.Items.AddRange(wordsItems.ToArray());
        }

        //panel FILTRES
        private void comboBoxLanguage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxLanguage1.Text = comboBoxLanguage1.Text;
            this.labelLanguage1.Text = this.comboBoxLanguage1.Text;
            //TODO appliquer filtre sur ensemble des résultats
        }

        private void comboBoxLanguage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxLanguage2.Text = comboBoxLanguage2.Text;
            this.labelLanguage2.Text = this.comboBoxLanguage2.Text;
            //TODO appliquer filtre sur ensemble des résultats
        }

        private void comboBoxSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO appliquer filtre sur ensemble des résultats
        }

        private void comboBoxSelectGrammaticalGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO appliquer filtre sur ensemble des résultats
        }

        private void checkBoxSelectStats0Tests_CheckedChanged(object sender, EventArgs e)
        {
            //TODO appliquer filtre sur ensemble des résultats
        }

        private void checkBoxSelectStats50pcFail_CheckedChanged(object sender, EventArgs e)
        {
            //TODO appliquer filtre sur ensemble des résultats
        }

        //panel TESTS
        private void buttonTest_Click(object sender, EventArgs e)
        {
            //TODO
        }

        //panel ADD
        private void buttonAddLanguage_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void buttonAddSerie_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void buttonAddWord_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
