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
        public GrammaticalGroups Group  { get; set; }
        public ILanguage Language { get; set; }
        public Word(int id, string name, GrammaticalGroups group, ILanguage language)
        {
            Id = id;
            Name = name;
            Group = group;
            Language = language;
        }
        public List<ISerie> Series() { throw new NotImplementedException(); }
    }
}
