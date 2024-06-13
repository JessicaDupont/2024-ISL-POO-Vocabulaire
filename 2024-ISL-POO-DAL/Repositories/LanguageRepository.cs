using _2024_ISL_POO_DAL.ADO;
using _2024_ISL_POO_DAL.ADO.DB;
using _2024_ISL_POO_DAL.Mapping;
using _2024_ISL_POO_DAL.Mapping.Bases;
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
        private readonly LanguageMapping _mapLanguage;
        public LanguageRepository() : base()
        {
            _mapLanguage = new LanguageMapping();
        }
        public ILanguage Read(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<ILanguage> Read()
        {
            List<ILanguage> result = new List<ILanguage>();
            Command cmd = _mapLanguage.Mapping(null, CRUD.List);
            result.AddRange(connect.ExecuteReader(cmd, reader => _mapLanguage.Mapping(reader)));
            return result;
        }

    }
}
