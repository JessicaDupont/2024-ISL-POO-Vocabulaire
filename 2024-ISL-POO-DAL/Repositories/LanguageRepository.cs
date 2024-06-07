using _2024_ISL_POO_DAL.ADO;
using _2024_ISL_POO_DAL.Mapping;
using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_Domain.IModels;
using _2024_ISL_POO_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Repositories
{
    public class LanguageRepository : RepositoryBase, ILanguageRepository
    {
        private readonly LanguageMapping mapLanguage;
        public LanguageRepository() : base()
        {
            
        }
        public ILanguage Read(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<ILanguage> Read()
        {
            IList<ILanguage> result = new List<ILanguage>();
            result.Add(new Language(1, "Français"));
            result.Add(new Language(2, "English"));
            //TODO connect2DB
            //Command cmd = new Command("select * from language", false);
            //result.AddRange(connect.ExecuteReader(cmd, reader => mapLanguage.Mapping(reader)));
            return result;
        }

    }
}
