using System.Collections.Generic;
using System;
using _2024_ISL_POO_Domain.IModels;

namespace _2024_ISL_POO_Domain.Models
{
    public class Language : ILanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool DataCompleted { get ; set; }

        public Language(int id)
        {
            Id = id; ;
            DataCompleted = false ;
        }
        public Language(string name)
        {
            Name = name;
            DataCompleted = false;
        }
        public Language(int id, string name)
        {
            Id = id; ;
            Name = name;
            DataCompleted = true;
        }
        public List<IWord> Words() { throw new NotImplementedException(); }
    }
}