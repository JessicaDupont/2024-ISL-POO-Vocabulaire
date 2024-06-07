using System.Collections.Generic;
using System;
using _2024_ISL_POO_Domain.IModels;

namespace _2024_ISL_POO_Domain.Models
{
    public class Serie : ISerie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Serie(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public List<ILanguage> Languages() { throw new NotImplementedException(); }
        public List<IWord> Words() { throw new NotImplementedException(); }
    }
}