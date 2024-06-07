namespace _2024_ISL_POO_View
{
    partial class Home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSelect = new System.Windows.Forms.Panel();
            this.labelSelectSerie = new System.Windows.Forms.Label();
            this.comboBoxSerie = new System.Windows.Forms.ComboBox();
            this.groupBoxSelectLanguages = new System.Windows.Forms.GroupBox();
            this.labelSelectLanguage2 = new System.Windows.Forms.Label();
            this.labelSelectLanguage1 = new System.Windows.Forms.Label();
            this.comboBoxLanguage1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLanguage2 = new System.Windows.Forms.ComboBox();
            this.buttonAddLanguage = new System.Windows.Forms.Button();
            this.textBoxAddLanguage = new System.Windows.Forms.TextBox();
            this.textBoxAddSerie = new System.Windows.Forms.TextBox();
            this.buttonAddSerie = new System.Windows.Forms.Button();
            this.labelLanguage1 = new System.Windows.Forms.Label();
            this.labelLanguage2 = new System.Windows.Forms.Label();
            this.textBoxAddWordLanguage1 = new System.Windows.Forms.TextBox();
            this.textBoxAddWordLanguage2 = new System.Windows.Forms.TextBox();
            this.buttonAddWord = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.groupBoxAddSerie = new System.Windows.Forms.GroupBox();
            this.groupBoxAddWords = new System.Windows.Forms.GroupBox();
            this.groupBoxAddLanguage = new System.Windows.Forms.GroupBox();
            this.comboBoxGrammaticalGroupAddWord = new System.Windows.Forms.ComboBox();
            this.labelSelectGrammaticalGroup = new System.Windows.Forms.Label();
            this.comboBoxSelectGrammaticalGroup = new System.Windows.Forms.ComboBox();
            this.groupBoxTests = new System.Windows.Forms.GroupBox();
            this.labelTestNbWords = new System.Windows.Forms.Label();
            this.numericUpDownTestNbWords = new System.Windows.Forms.NumericUpDown();
            this.buttonTest = new System.Windows.Forms.Button();
            this.panelTests = new System.Windows.Forms.Panel();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.labelSelectStats = new System.Windows.Forms.Label();
            this.checkBoxSelectStats0Tests = new System.Windows.Forms.CheckBox();
            this.checkBoxSelectStats50pcFail = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxWords = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrammaticalGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Series = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MatcheList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelSelect.SuspendLayout();
            this.groupBoxSelectLanguages.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.groupBoxAddSerie.SuspendLayout();
            this.groupBoxAddWords.SuspendLayout();
            this.groupBoxAddLanguage.SuspendLayout();
            this.groupBoxTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestNbWords)).BeginInit();
            this.panelTests.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSelect
            // 
            this.panelSelect.Controls.Add(this.groupBoxSelectLanguages);
            this.panelSelect.Location = new System.Drawing.Point(150, 3);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(765, 90);
            this.panelSelect.TabIndex = 0;
            // 
            // labelSelectSerie
            // 
            this.labelSelectSerie.AutoSize = true;
            this.labelSelectSerie.Location = new System.Drawing.Point(280, 25);
            this.labelSelectSerie.Name = "labelSelectSerie";
            this.labelSelectSerie.Size = new System.Drawing.Size(39, 16);
            this.labelSelectSerie.TabIndex = 7;
            this.labelSelectSerie.Text = "Serie";
            // 
            // comboBoxSerie
            // 
            this.comboBoxSerie.FormattingEnabled = true;
            this.comboBoxSerie.Location = new System.Drawing.Point(280, 50);
            this.comboBoxSerie.Name = "comboBoxSerie";
            this.comboBoxSerie.Size = new System.Drawing.Size(125, 24);
            this.comboBoxSerie.TabIndex = 6;
            // 
            // groupBoxSelectLanguages
            // 
            this.groupBoxSelectLanguages.Controls.Add(this.checkBoxSelectStats50pcFail);
            this.groupBoxSelectLanguages.Controls.Add(this.checkBoxSelectStats0Tests);
            this.groupBoxSelectLanguages.Controls.Add(this.labelSelectStats);
            this.groupBoxSelectLanguages.Controls.Add(this.labelSelectGrammaticalGroup);
            this.groupBoxSelectLanguages.Controls.Add(this.comboBoxSelectGrammaticalGroup);
            this.groupBoxSelectLanguages.Controls.Add(this.labelSelectSerie);
            this.groupBoxSelectLanguages.Controls.Add(this.comboBoxSerie);
            this.groupBoxSelectLanguages.Controls.Add(this.labelSelectLanguage2);
            this.groupBoxSelectLanguages.Controls.Add(this.labelSelectLanguage1);
            this.groupBoxSelectLanguages.Controls.Add(this.comboBoxLanguage1);
            this.groupBoxSelectLanguages.Controls.Add(this.comboBoxLanguage2);
            this.groupBoxSelectLanguages.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelectLanguages.Name = "groupBoxSelectLanguages";
            this.groupBoxSelectLanguages.Size = new System.Drawing.Size(755, 80);
            this.groupBoxSelectLanguages.TabIndex = 16;
            this.groupBoxSelectLanguages.TabStop = false;
            this.groupBoxSelectLanguages.Text = "Filtres";
            // 
            // labelSelectLanguage2
            // 
            this.labelSelectLanguage2.AutoSize = true;
            this.labelSelectLanguage2.Location = new System.Drawing.Point(145, 25);
            this.labelSelectLanguage2.Name = "labelSelectLanguage2";
            this.labelSelectLanguage2.Size = new System.Drawing.Size(78, 16);
            this.labelSelectLanguage2.TabIndex = 1;
            this.labelSelectLanguage2.Text = "Language 2";
            // 
            // labelSelectLanguage1
            // 
            this.labelSelectLanguage1.AutoSize = true;
            this.labelSelectLanguage1.Location = new System.Drawing.Point(10, 25);
            this.labelSelectLanguage1.Name = "labelSelectLanguage1";
            this.labelSelectLanguage1.Size = new System.Drawing.Size(78, 16);
            this.labelSelectLanguage1.TabIndex = 0;
            this.labelSelectLanguage1.Text = "Language 1";
            // 
            // comboBoxLanguage1
            // 
            this.comboBoxLanguage1.FormattingEnabled = true;
            this.comboBoxLanguage1.Location = new System.Drawing.Point(10, 50);
            this.comboBoxLanguage1.Name = "comboBoxLanguage1";
            this.comboBoxLanguage1.Size = new System.Drawing.Size(125, 24);
            this.comboBoxLanguage1.TabIndex = 3;
            // 
            // comboBoxLanguage2
            // 
            this.comboBoxLanguage2.FormattingEnabled = true;
            this.comboBoxLanguage2.Location = new System.Drawing.Point(145, 50);
            this.comboBoxLanguage2.Name = "comboBoxLanguage2";
            this.comboBoxLanguage2.Size = new System.Drawing.Size(125, 24);
            this.comboBoxLanguage2.TabIndex = 2;
            // 
            // buttonAddLanguage
            // 
            this.buttonAddLanguage.Location = new System.Drawing.Point(6, 50);
            this.buttonAddLanguage.Name = "buttonAddLanguage";
            this.buttonAddLanguage.Size = new System.Drawing.Size(130, 23);
            this.buttonAddLanguage.TabIndex = 5;
            this.buttonAddLanguage.Text = "Add language";
            this.buttonAddLanguage.UseVisualStyleBackColor = true;
            // 
            // textBoxAddLanguage
            // 
            this.textBoxAddLanguage.Location = new System.Drawing.Point(6, 25);
            this.textBoxAddLanguage.Name = "textBoxAddLanguage";
            this.textBoxAddLanguage.Size = new System.Drawing.Size(130, 22);
            this.textBoxAddLanguage.TabIndex = 4;
            // 
            // textBoxAddSerie
            // 
            this.textBoxAddSerie.Location = new System.Drawing.Point(6, 25);
            this.textBoxAddSerie.Name = "textBoxAddSerie";
            this.textBoxAddSerie.Size = new System.Drawing.Size(130, 22);
            this.textBoxAddSerie.TabIndex = 8;
            // 
            // buttonAddSerie
            // 
            this.buttonAddSerie.Location = new System.Drawing.Point(6, 50);
            this.buttonAddSerie.Name = "buttonAddSerie";
            this.buttonAddSerie.Size = new System.Drawing.Size(130, 23);
            this.buttonAddSerie.TabIndex = 9;
            this.buttonAddSerie.Text = "Add serie";
            this.buttonAddSerie.UseVisualStyleBackColor = true;
            // 
            // labelLanguage1
            // 
            this.labelLanguage1.AutoSize = true;
            this.labelLanguage1.Location = new System.Drawing.Point(6, 25);
            this.labelLanguage1.Name = "labelLanguage1";
            this.labelLanguage1.Size = new System.Drawing.Size(85, 16);
            this.labelLanguage1.TabIndex = 10;
            this.labelLanguage1.Text = "=Language 1";
            // 
            // labelLanguage2
            // 
            this.labelLanguage2.AutoSize = true;
            this.labelLanguage2.Location = new System.Drawing.Point(6, 75);
            this.labelLanguage2.Name = "labelLanguage2";
            this.labelLanguage2.Size = new System.Drawing.Size(85, 16);
            this.labelLanguage2.TabIndex = 11;
            this.labelLanguage2.Text = "=Language 2";
            // 
            // textBoxAddWordLanguage1
            // 
            this.textBoxAddWordLanguage1.Location = new System.Drawing.Point(6, 50);
            this.textBoxAddWordLanguage1.Name = "textBoxAddWordLanguage1";
            this.textBoxAddWordLanguage1.Size = new System.Drawing.Size(130, 22);
            this.textBoxAddWordLanguage1.TabIndex = 12;
            // 
            // textBoxAddWordLanguage2
            // 
            this.textBoxAddWordLanguage2.Location = new System.Drawing.Point(6, 100);
            this.textBoxAddWordLanguage2.Name = "textBoxAddWordLanguage2";
            this.textBoxAddWordLanguage2.Size = new System.Drawing.Size(130, 22);
            this.textBoxAddWordLanguage2.TabIndex = 13;
            // 
            // buttonAddWord
            // 
            this.buttonAddWord.Location = new System.Drawing.Point(6, 150);
            this.buttonAddWord.Name = "buttonAddWord";
            this.buttonAddWord.Size = new System.Drawing.Size(130, 23);
            this.buttonAddWord.TabIndex = 14;
            this.buttonAddWord.Text = "Add word";
            this.buttonAddWord.UseVisualStyleBackColor = true;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.groupBoxAddSerie);
            this.panelAdd.Controls.Add(this.groupBoxAddWords);
            this.panelAdd.Controls.Add(this.groupBoxAddLanguage);
            this.panelAdd.Location = new System.Drawing.Point(3, 3);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(150, 400);
            this.panelAdd.TabIndex = 15;
            // 
            // groupBoxAddSerie
            // 
            this.groupBoxAddSerie.Controls.Add(this.textBoxAddSerie);
            this.groupBoxAddSerie.Controls.Add(this.buttonAddSerie);
            this.groupBoxAddSerie.Location = new System.Drawing.Point(3, 90);
            this.groupBoxAddSerie.Name = "groupBoxAddSerie";
            this.groupBoxAddSerie.Size = new System.Drawing.Size(140, 80);
            this.groupBoxAddSerie.TabIndex = 6;
            this.groupBoxAddSerie.TabStop = false;
            this.groupBoxAddSerie.Text = "Add serie";
            // 
            // groupBoxAddWords
            // 
            this.groupBoxAddWords.Controls.Add(this.comboBoxGrammaticalGroupAddWord);
            this.groupBoxAddWords.Controls.Add(this.labelLanguage2);
            this.groupBoxAddWords.Controls.Add(this.labelLanguage1);
            this.groupBoxAddWords.Controls.Add(this.buttonAddWord);
            this.groupBoxAddWords.Controls.Add(this.textBoxAddWordLanguage1);
            this.groupBoxAddWords.Controls.Add(this.textBoxAddWordLanguage2);
            this.groupBoxAddWords.Location = new System.Drawing.Point(3, 180);
            this.groupBoxAddWords.Name = "groupBoxAddWords";
            this.groupBoxAddWords.Size = new System.Drawing.Size(140, 180);
            this.groupBoxAddWords.TabIndex = 16;
            this.groupBoxAddWords.TabStop = false;
            this.groupBoxAddWords.Text = "Add words";
            // 
            // groupBoxAddLanguage
            // 
            this.groupBoxAddLanguage.Controls.Add(this.textBoxAddLanguage);
            this.groupBoxAddLanguage.Controls.Add(this.buttonAddLanguage);
            this.groupBoxAddLanguage.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAddLanguage.Name = "groupBoxAddLanguage";
            this.groupBoxAddLanguage.Size = new System.Drawing.Size(140, 80);
            this.groupBoxAddLanguage.TabIndex = 15;
            this.groupBoxAddLanguage.TabStop = false;
            this.groupBoxAddLanguage.Text = "Add language";
            // 
            // comboBoxGrammaticalGroupAddWord
            // 
            this.comboBoxGrammaticalGroupAddWord.FormattingEnabled = true;
            this.comboBoxGrammaticalGroupAddWord.Location = new System.Drawing.Point(6, 125);
            this.comboBoxGrammaticalGroupAddWord.Name = "comboBoxGrammaticalGroupAddWord";
            this.comboBoxGrammaticalGroupAddWord.Size = new System.Drawing.Size(130, 24);
            this.comboBoxGrammaticalGroupAddWord.TabIndex = 15;
            // 
            // labelSelectGrammaticalGroup
            // 
            this.labelSelectGrammaticalGroup.AutoSize = true;
            this.labelSelectGrammaticalGroup.Location = new System.Drawing.Point(415, 25);
            this.labelSelectGrammaticalGroup.Name = "labelSelectGrammaticalGroup";
            this.labelSelectGrammaticalGroup.Size = new System.Drawing.Size(121, 16);
            this.labelSelectGrammaticalGroup.TabIndex = 7;
            this.labelSelectGrammaticalGroup.Text = "Grammatical group";
            // 
            // comboBoxSelectGrammaticalGroup
            // 
            this.comboBoxSelectGrammaticalGroup.FormattingEnabled = true;
            this.comboBoxSelectGrammaticalGroup.Location = new System.Drawing.Point(415, 50);
            this.comboBoxSelectGrammaticalGroup.Name = "comboBoxSelectGrammaticalGroup";
            this.comboBoxSelectGrammaticalGroup.Size = new System.Drawing.Size(125, 24);
            this.comboBoxSelectGrammaticalGroup.TabIndex = 6;
            // 
            // groupBoxTests
            // 
            this.groupBoxTests.Controls.Add(this.buttonTest);
            this.groupBoxTests.Controls.Add(this.numericUpDownTestNbWords);
            this.groupBoxTests.Controls.Add(this.labelTestNbWords);
            this.groupBoxTests.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTests.Name = "groupBoxTests";
            this.groupBoxTests.Size = new System.Drawing.Size(140, 110);
            this.groupBoxTests.TabIndex = 19;
            this.groupBoxTests.TabStop = false;
            this.groupBoxTests.Text = "Tests";
            // 
            // labelTestNbWords
            // 
            this.labelTestNbWords.AutoSize = true;
            this.labelTestNbWords.Location = new System.Drawing.Point(6, 25);
            this.labelTestNbWords.Name = "labelTestNbWords";
            this.labelTestNbWords.Size = new System.Drawing.Size(115, 16);
            this.labelTestNbWords.TabIndex = 0;
            this.labelTestNbWords.Text = "Numbers of words";
            // 
            // numericUpDownTestNbWords
            // 
            this.numericUpDownTestNbWords.Location = new System.Drawing.Point(6, 50);
            this.numericUpDownTestNbWords.Name = "numericUpDownTestNbWords";
            this.numericUpDownTestNbWords.Size = new System.Drawing.Size(130, 22);
            this.numericUpDownTestNbWords.TabIndex = 1;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(6, 75);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(130, 25);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            // 
            // panelTests
            // 
            this.panelTests.Controls.Add(this.groupBoxStats);
            this.panelTests.Controls.Add(this.groupBoxTests);
            this.panelTests.Location = new System.Drawing.Point(914, 3);
            this.panelTests.Name = "panelTests";
            this.panelTests.Size = new System.Drawing.Size(150, 400);
            this.panelTests.TabIndex = 20;
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Location = new System.Drawing.Point(3, 120);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(140, 150);
            this.groupBoxStats.TabIndex = 20;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Stats";
            // 
            // labelSelectStats
            // 
            this.labelSelectStats.AutoSize = true;
            this.labelSelectStats.Location = new System.Drawing.Point(550, 25);
            this.labelSelectStats.Name = "labelSelectStats";
            this.labelSelectStats.Size = new System.Drawing.Size(37, 16);
            this.labelSelectStats.TabIndex = 8;
            this.labelSelectStats.Text = "Stats";
            // 
            // checkBoxSelectStats0Tests
            // 
            this.checkBoxSelectStats0Tests.AutoSize = true;
            this.checkBoxSelectStats0Tests.Location = new System.Drawing.Point(550, 50);
            this.checkBoxSelectStats0Tests.Name = "checkBoxSelectStats0Tests";
            this.checkBoxSelectStats0Tests.Size = new System.Drawing.Size(87, 20);
            this.checkBoxSelectStats0Tests.TabIndex = 9;
            this.checkBoxSelectStats0Tests.Text = "No tested";
            this.checkBoxSelectStats0Tests.UseVisualStyleBackColor = true;
            // 
            // checkBoxSelectStats50pcFail
            // 
            this.checkBoxSelectStats50pcFail.AutoSize = true;
            this.checkBoxSelectStats50pcFail.Location = new System.Drawing.Point(640, 50);
            this.checkBoxSelectStats50pcFail.Name = "checkBoxSelectStats50pcFail";
            this.checkBoxSelectStats50pcFail.Size = new System.Drawing.Size(104, 20);
            this.checkBoxSelectStats50pcFail.TabIndex = 10;
            this.checkBoxSelectStats50pcFail.Text = ">= 50% Fails";
            this.checkBoxSelectStats50pcFail.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxWords);
            this.panel1.Location = new System.Drawing.Point(152, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 311);
            this.panel1.TabIndex = 21;
            // 
            // groupBoxWords
            // 
            this.groupBoxWords.Controls.Add(this.listView1);
            this.groupBoxWords.Location = new System.Drawing.Point(3, 3);
            this.groupBoxWords.Name = "groupBoxWords";
            this.groupBoxWords.Size = new System.Drawing.Size(753, 305);
            this.groupBoxWords.TabIndex = 0;
            this.groupBoxWords.TabStop = false;
            this.groupBoxWords.Text = "=NbWords words";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Word,
            this.GrammaticalGroup,
            this.Series,
            this.MatcheList});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(740, 275);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Word
            // 
            this.Word.Text = "Word";
            // 
            // GrammaticalGroup
            // 
            this.GrammaticalGroup.Text = "Grammatical group";
            // 
            // Series
            // 
            this.Series.Text = "Series";
            // 
            // MatcheList
            // 
            this.MatcheList.Text = "Matches";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTests);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelSelect);
            this.Name = "Home";
            this.Text = "Home";
            this.panelSelect.ResumeLayout(false);
            this.groupBoxSelectLanguages.ResumeLayout(false);
            this.groupBoxSelectLanguages.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.groupBoxAddSerie.ResumeLayout(false);
            this.groupBoxAddSerie.PerformLayout();
            this.groupBoxAddWords.ResumeLayout(false);
            this.groupBoxAddWords.PerformLayout();
            this.groupBoxAddLanguage.ResumeLayout(false);
            this.groupBoxAddLanguage.PerformLayout();
            this.groupBoxTests.ResumeLayout(false);
            this.groupBoxTests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestNbWords)).EndInit();
            this.panelTests.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxWords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Button buttonAddLanguage;
        private System.Windows.Forms.TextBox textBoxAddLanguage;
        private System.Windows.Forms.ComboBox comboBoxLanguage1;
        private System.Windows.Forms.ComboBox comboBoxLanguage2;
        private System.Windows.Forms.Label labelSelectLanguage2;
        private System.Windows.Forms.Label labelSelectLanguage1;
        private System.Windows.Forms.Label labelSelectSerie;
        private System.Windows.Forms.ComboBox comboBoxSerie;
        private System.Windows.Forms.TextBox textBoxAddSerie;
        private System.Windows.Forms.Button buttonAddSerie;
        private System.Windows.Forms.Button buttonAddWord;
        private System.Windows.Forms.TextBox textBoxAddWordLanguage2;
        private System.Windows.Forms.TextBox textBoxAddWordLanguage1;
        private System.Windows.Forms.Label labelLanguage2;
        private System.Windows.Forms.Label labelLanguage1;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.GroupBox groupBoxAddSerie;
        private System.Windows.Forms.GroupBox groupBoxAddWords;
        private System.Windows.Forms.GroupBox groupBoxAddLanguage;
        private System.Windows.Forms.GroupBox groupBoxSelectLanguages;
        private System.Windows.Forms.Label labelSelectGrammaticalGroup;
        private System.Windows.Forms.ComboBox comboBoxSelectGrammaticalGroup;
        private System.Windows.Forms.ComboBox comboBoxGrammaticalGroupAddWord;
        private System.Windows.Forms.GroupBox groupBoxTests;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.NumericUpDown numericUpDownTestNbWords;
        private System.Windows.Forms.Label labelTestNbWords;
        private System.Windows.Forms.Panel panelTests;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label labelSelectStats;
        private System.Windows.Forms.CheckBox checkBoxSelectStats0Tests;
        private System.Windows.Forms.CheckBox checkBoxSelectStats50pcFail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxWords;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Word;
        private System.Windows.Forms.ColumnHeader GrammaticalGroup;
        private System.Windows.Forms.ColumnHeader Series;
        private System.Windows.Forms.ColumnHeader MatcheList;
    }
}

