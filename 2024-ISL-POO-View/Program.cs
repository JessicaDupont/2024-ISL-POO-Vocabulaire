using _2024_ISL_POO_DAL.Repositories;
using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_ISL_POO_View
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ILanguageRepository languageRepository = new LanguageRepository();
            IGrammaticalGroupRepository grammaticalRepository = new GrammaticalGroupRepository();
            IWordRepository wordRepository = new WordRepository();

        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(languageRepository, grammaticalRepository, wordRepository));
        }
    }
}
