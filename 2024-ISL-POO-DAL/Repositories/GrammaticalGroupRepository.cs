using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Repositories
{
    public class GrammaticalGroupRepository : IGrammaticalGroupRepository
    {
        public IEnumerable<string> Read()
        {
            IList<string> result = new List<string>();
            result.Add(GrammaticalGroups.Adjective.ToString());
            result.Add(GrammaticalGroups.Adverb.ToString());
            result.Add(GrammaticalGroups.Auxiliary.ToString());
            result.Add(GrammaticalGroups.Article.ToString());
            result.Add(GrammaticalGroups.Conjunction.ToString());
            result.Add(GrammaticalGroups.Interjection.ToString());
            result.Add(GrammaticalGroups.Name.ToString());
            result.Add(GrammaticalGroups.Number.ToString());
            result.Add(GrammaticalGroups.Preposition.ToString());
            result.Add(GrammaticalGroups.Pronoun.ToString());
            result.Add(GrammaticalGroups.Symbol.ToString());
            result.Add(GrammaticalGroups.Verb.ToString());
            return result;
        }

        //IEnumerable<GrammaticalGroups> IGrammaticalGroupRepository.Read()
        //{
        //    yield return GrammaticalGroups.Adjective;
        //    yield return GrammaticalGroups.Adverb;
        //    yield return GrammaticalGroups.Auxiliary;
        //    yield return GrammaticalGroups.Article;
        //    yield return GrammaticalGroups.Conjunction;
        //    yield return GrammaticalGroups.Interjection;
        //    yield return GrammaticalGroups.Name;
        //    yield return GrammaticalGroups.Number;
        //    yield return GrammaticalGroups.Preposition;
        //    yield return GrammaticalGroups.Pronoun;
        //    yield return GrammaticalGroups.Symbol;
        //    yield return GrammaticalGroups.Verb;
        //}
    }
}
