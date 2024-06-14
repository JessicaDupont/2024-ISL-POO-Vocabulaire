using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_DAL.Repositories.Interfaces;
using _2024_ISL_POO_DAL.Services;
using _2024_ISL_POO_DAL.Services.Bases;
using _2024_ISL_POO_Domain.IModels;
using _2024_ISL_POO_View.Lang;
using _2024_ISL_POO_View.Presenters.Bases;
using _2024_ISL_POO_View.Presenters.Home;
using _2024_ISL_POO_View.Presenters.Layout;
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
        private FiltersPanelPresenter _presenterFilters;
        private AddsPanelPresenter _presenterAdds;
        private TestsPanelPresenter _presenterTests;
        private StatsPanelPresenter _presenterStats;
        private HomePresenter _homePresenter;

        public Home()
        {
            this._presenterFilters = new FiltersPanelPresenter();
            this._presenterAdds = new AddsPanelPresenter();
            this._presenterTests = new TestsPanelPresenter();
            this._presenterStats = new StatsPanelPresenter();
            this._homePresenter = new HomePresenter();
            //components
            InitializeComponent();
            //panel FILTRES
            this.groupBoxFilters.Text = _presenterFilters.FiltersTitle;
            //lg 1
            this.labelLanguage1.Text = _presenterFilters.Language2Title;
            this.comboBoxLanguage1.DisplayMember = "Name";
            this.comboBoxLanguage1.ValueMember = "Id";
            this.comboBoxLanguage1.DataSource = _presenterFilters.LanguageList;
            this.comboBoxLanguage1.SelectedIndex = 0;
            _presenterFilters.AddFilter(new Filter(Filters.language1, this.comboBoxLanguage1.SelectedValue));
            //lg 2
            this.labelLanguage2.Text = _presenterFilters.Language2Title;
            this.comboBoxLanguage2.DisplayMember = "Name";
            this.comboBoxLanguage2.ValueMember = "Id";
            this.comboBoxLanguage2.DataSource = _presenterFilters.LanguageList;
            this.comboBoxLanguage2.SelectedIndex = 1;
            _presenterFilters.AddFilter(new Filter(Filters.language2, this.comboBoxLanguage2.SelectedValue));
            //serie
            this.labelSelectSerie.Text = _presenterFilters.SerieTitle;
            //TODO serie
            //_wordsS.Filters..Add(new Filter(Filters.serie, this.comboBoxSerie.SelectedValue));
            //grammatical group
            this.labelSelectGrammaticalGroup.Text = _presenterFilters.GrammaticalGroupTitle;
            this.comboBoxSelectGrammaticalGroup.DataSource = _presenterFilters.GrammaticalGroupList;
            //tested
            this.labelSelectStats.Text = _presenterFilters.TestedTitle;
            this.checkBoxSelectStats0Tests.Checked = true;
            //_wordsS.Filters..Add(new Filter(Filters.noTested, this.checkBoxSelectStats0Tests.Checked));
            this.checkBoxSelectStats50pcFail.Checked = true;
            //_wordsS.Filters..Add(new Filter(Filters.fails, this.checkBoxSelectStats50pcFail.Checked));
            //panel ADD
            this.groupBoxAddLanguage.Hide(); //TODO add language
            this.groupBoxAddLanguage.Text = _presenterAdds.LanguageTitle;
            this.buttonAddLanguage.Text = _presenterAdds.LanguageButton;
            this.groupBoxAddSerie.Hide(); //TODO add serie
            this.groupBoxAddSerie.Text = _presenterAdds.SerieTitle;
            this.buttonAddSerie.Text = _presenterAdds.SerieButton;
            this.groupBoxAddWords.Text = _presenterAdds.WordsTitle;
            this.labelLanguage1.Text = this.comboBoxLanguage1.Text;
            this.labelLanguage2.Text = this.comboBoxLanguage2.Text;
            this.labelGrammaticalGroup.Text = _presenterAdds.GrammaticalGroupTitle;
            this.comboBoxGrammaticalGroupAddWord.DataSource = _presenterAdds.GrammaticalGroupList;
            this.buttonAddWord.Text = _presenterAdds.WordsButton;
            //panel TESTS
            this.groupBoxTests.Text = _presenterTests.TestsTitle;
            this.labelTestNbWords.Text = _presenterTests.NbWordsTitle;
            this.numericUpDownTestNbWords.Value = 10;
            this.buttonTest.Text = _presenterTests.RunButton;
            //panel STATS
            this.groupBoxStats.Text = _presenterStats.StatsTitle;
            //panel LIST
            this.groupBoxWords.Text = _homePresenter.NbWords;
            this.listViewWords.Columns.Clear();
            this.listViewWords.Columns.Add(_homePresenter.WordsTitle, 200);
            this.listViewWords.Columns.Add(_homePresenter.TraductionTitle, 200);
            this.listViewWords.Columns.Add(_homePresenter.GrammaticalGroupTitle, 150);
            //TODO series
            //this.listViewWords.Columns.Add(_homePresenter.SeriesLabel, 150);
            this.listViewWords.Items.AddRange(_homePresenter.ListViewWords);
        }

        //panel FILTRES
        private void comboBoxLanguage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxLanguage1.Text = comboBoxLanguage1.Text;
            this.labelLanguage1.Text = this.comboBoxLanguage1.Text;
            _presenterFilters.AddFilter(new Filter(Filters.language1, this.comboBoxLanguage1.SelectedValue));
            this.listViewWords.Items.Clear();
            this.listViewWords.Items.AddRange(_homePresenter.ListViewWords);
        }

        private void comboBoxLanguage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxLanguage2.Text = comboBoxLanguage2.Text;
            this.labelLanguage2.Text = this.comboBoxLanguage2.Text;
            _presenterFilters.AddFilter(new Filter(Filters.language2, this.comboBoxLanguage2.SelectedValue));
            this.listViewWords.Items.Clear();
            this.listViewWords.Items.AddRange(_homePresenter.ListViewWords);
        }

        private void comboBoxSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO serie
        }

        private void comboBoxSelectGrammaticalGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxSelectGrammaticalGroup.Text = comboBoxSelectGrammaticalGroup.Text;
            _presenterFilters.AddFilter(new Filter(Filters.grammaticalGroup, this.comboBoxSelectGrammaticalGroup.Text));
            this.listViewWords.Items.Clear();
            this.listViewWords.Items.AddRange(_homePresenter.ListViewWords);
        }

        private void checkBoxSelectStats0Tests_CheckedChanged(object sender, EventArgs e)
        {
            //TODO stats
        }

        private void checkBoxSelectStats50pcFail_CheckedChanged(object sender, EventArgs e)
        {
            //TODO stats
        }

        //panel TESTS
        private void buttonTest_Click(object sender, EventArgs e)
        {
            //TODO test
        }

        //panel ADD
        private void buttonAddLanguage_Click(object sender, EventArgs e)
        {
            //TODO add language
        }

        private void buttonAddSerie_Click(object sender, EventArgs e)
        {
            //TODO add serie
        }

        private void buttonAddWord_Click(object sender, EventArgs e)
        {
            //TODO add word

            //reset
            this.comboBoxGrammaticalGroupAddWord.SelectedIndex = -1;
            this.textBoxAddWordLanguage1.Clear();
            this.textBoxAddWordLanguage2.Clear();
        }
    }
}
