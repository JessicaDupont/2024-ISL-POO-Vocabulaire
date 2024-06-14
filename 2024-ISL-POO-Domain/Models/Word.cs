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
        public static List<IWord> Words = new List<IWord>();
        public int Id { get; set; }
        public string Name { get; set; }
        public GrammaticalGroup Group { get; set; }
        public ILanguage Language { get; set; }
        public List<ISerie> Series { get; set; }
        public List<IWord> Traduction { get; set; }

        public Word(int id)
        {
            Id = id;
            SearchInStatic();
        }

        private void SearchInStatic()
        {
            if (Words.Exists(w => w.Id == Id))
            {
                IWord temp = Words.First(w => w.Id == Id);
                this.Name = temp.Name;
                this.Group = temp.Group;
                this.Language = temp.Language;
                this.Series = temp.Series;
                this.Traduction = temp.Traduction;
            }
        }

        public Word(int id, string name, string group, ILanguage language)
        {
            Id = id;
            Name = name;
            Group = new GrammaticalGroup(group);
            Language = language;
            Series = new List<ISerie>();
            Traduction = new List<IWord>();
            Words.Add(this);
        }

        public Word(string name, string grammaticalGroup, int languageId)
        {
            this.Name = name;
            this.Group = new GrammaticalGroup(grammaticalGroup);
            this.Language = new Language(languageId);
        }
    }
}
