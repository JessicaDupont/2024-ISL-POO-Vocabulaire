using _2024_ISL_POO_Domain.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_Domain.Models
{
    public class Word : IWord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GrammaticalGroup Group  { get; set; }
        public ILanguage Language { get; set; }
        public bool DataCompleted { get; set; }

        public Word(int id, string name, string group, ILanguage language)
        {
            Id = id;
            Name = name;
            Group = new GrammaticalGroup(group);
            Language = language;
            DataCompleted = true;
        }
        public List<ISerie> Series() {
            List<ISerie> result = new List<ISerie>();
            //TODO series
            return result;
        }

        public List<IWord> Traduction()
        {
            List<IWord> result = new List<IWord>();
            //TODO
            return result;
        }
    }
}
