using _2024_ISL_POO_DAL.Services.Bases;
using _2024_ISL_POO_Domain.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Services
{
    public class LanguagesService : ServiceBase, ILanguageService
    {
        public LanguagesService() : base()
        {
            
        }
        public IEnumerable<ILanguage> Languages 
        {
            get => _languageRepository.Read();
            set
            {
                throw new NotImplementedException(); //TODO add language
            } 
        }
    }
}
