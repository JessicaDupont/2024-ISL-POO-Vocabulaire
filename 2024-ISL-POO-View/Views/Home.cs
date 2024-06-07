using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_DAL.Repositories.Interfaces;
using _2024_ISL_POO_Domain.IModels;
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
        private readonly IWordRepository _wordRepository;
        private Filtre _filtres;

        public Home(
            ILanguageRepository languageRepository,
            IGrammaticalGroupRepository grammaticalRepository,
            IWordRepository wordRepository
            )
        {
            //repositories
            this._languageR = languageRepository;
            this._grammaticalR = grammaticalRepository;
            this._wordRepository = wordRepository;
            this._filtres = new Filtre();

            //components
            InitializeComponent();
            //panel FILTRES
            //lg 1
            this.comboBoxLanguage1.DisplayMember = "Name";
            this.comboBoxLanguage1.ValueMember = "Id";
            this.comboBoxLanguage1.DataSource = _languageR.Read();
            this.comboBoxLanguage1.SelectedIndex = 0;
            //lg 2
            this.comboBoxLanguage2.DisplayMember = "Name";
            this.comboBoxLanguage2.ValueMember = "Id";
            this.comboBoxLanguage2.DataSource = _languageR.Read();
            this.comboBoxLanguage2.SelectedIndex = 1;
            //serie
            this.comboBoxSerie.Text = "- default"; //TODO
            //grammatical group
            this.comboBoxSelectGrammaticalGroup.DataSource = _grammaticalR.Read();
            this.comboBoxSelectGrammaticalGroup.SelectedIndex = -1;
            //tested
            this.checkBoxSelectStats0Tests.Checked = true;
            this.checkBoxSelectStats50pcFail.Checked = true;
            //panel ADD
            this.groupBoxAddLanguage.Hide(); //TODO
            this.groupBoxAddSerie.Hide(); //TODO
            this.labelLanguage1.Text = this.comboBoxLanguage1.Text;
            this.labelLanguage2.Text = this.comboBoxLanguage2.Text;
            this.comboBoxGrammaticalGroupAddWord.DataSource = _grammaticalR.Read();
            //panel TESTS
            this.numericUpDownTestNbWords.Value = 10;
            //panel STATS
            //panel LIST
            this.labelTestNbWords.Text = "0 word";//TODO
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
