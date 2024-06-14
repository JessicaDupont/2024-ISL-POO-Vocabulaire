using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_DAL.Repositories.Interfaces;
using _2024_ISL_POO_DAL.Services.Bases;
using _2024_ISL_POO_Domain.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Services
{
    public class WordsService : ServiceBase, IWordsService
    {
        private static List<Filter> filters;

        public WordsService() : base()
        {
            filters = new List<Filter>();
        }

        public IEnumerable<Filter> Filters => filters;
        public IEnumerable<IWord> Words 
        { 
            get => WordRepository.Search(filters);
            set 
            {
                //TODO add words
            } 
        }

        public void AddFilter(Filter filter)
        {
            if (filters.Contains(filter))
            {
                filters.Remove(filter);
            }
            filters.Add(filter);
        }
    }
}
