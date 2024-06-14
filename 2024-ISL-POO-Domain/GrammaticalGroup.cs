using System;

namespace _2024_ISL_POO_Domain.Models
{
    public enum GrammaticalGroups
    {
        Adjective,
        Adverb,
        Article,
        Auxiliary,
        Conjunction,
        Interjection,
        Name,
        Number,
        Preposition,
        Pronoun,
        Symbol,
        Verb
    }
    public class GrammaticalGroup 
    {
        public GrammaticalGroup(string value)
        {
            GrammaticalGroups temp;
            Enum.TryParse(value, out temp);
            Gg = temp;
        }
        public GrammaticalGroups Gg { get; }
        public string Name => Enum.GetName(typeof(GrammaticalGroups), Gg);
        public int Number => ((int)Gg);
    }
}