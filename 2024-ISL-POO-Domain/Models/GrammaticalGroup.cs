using System;

namespace _2024_ISL_POO_Domain.Models
{
    public enum GrammaticalGroups
    {
        ALL,
        adjective,
        adverb,
        article,
        auxiliary,
        conjunction,
        interjection,
        name,
        number,
        preposition,
        pronoun,
        symbol,
        verb
    }
    public class GrammaticalGroup 
    {
        public GrammaticalGroup(string value)
        {
            GrammaticalGroups temp;
            temp = (GrammaticalGroups)Enum.Parse(typeof(GrammaticalGroups), value);
            Gg = temp;
        }
        public GrammaticalGroups Gg { get; }
        public string Name => Enum.GetName(typeof(GrammaticalGroups), Gg);
        public int Number => ((int)Gg);
        public bool Compare(string value) 
        {
            GrammaticalGroups temp;
            temp = (GrammaticalGroups)Enum.Parse(typeof(GrammaticalGroups), value);
            return Gg.Equals(temp);
        }
    }
}