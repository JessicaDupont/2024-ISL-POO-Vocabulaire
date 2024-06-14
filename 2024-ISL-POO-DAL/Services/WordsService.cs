using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_DAL.Repositories.Interfaces;
using _2024_ISL_POO_DAL.Services.Bases;
using _2024_ISL_POO_Domain.IModels;
using _2024_ISL_POO_Domain.Models;
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

        public IEnumerable<Filter> MyFilters => filters;
        public IEnumerable<IWord> Words 
        {
            get => _wordRepository.Search(filters).ToList();
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

        public IWord AddWord(int lg1, string w1, string gg)
        {
            //TODO doublon word
            IWord result = new Word(w1, gg, lg1);
            result = _wordRepository.Create(result);
            return result;
        }

        public void AssociatedWords(IWord one, IWord two)
        {
            //TODO associated words
            throw new NotImplementedException();
        }
    }
}
