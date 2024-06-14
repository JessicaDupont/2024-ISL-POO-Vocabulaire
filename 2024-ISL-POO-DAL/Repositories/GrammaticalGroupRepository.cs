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
            result.Add(GrammaticalGroups.adjective.ToString());
            result.Add(GrammaticalGroups.adverb.ToString());
            result.Add(GrammaticalGroups.auxiliary.ToString());
            result.Add(GrammaticalGroups.article.ToString());
            result.Add(GrammaticalGroups.conjunction.ToString());
            result.Add(GrammaticalGroups.interjection.ToString());
            result.Add(GrammaticalGroups.name.ToString());
            result.Add(GrammaticalGroups.number.ToString());
            result.Add(GrammaticalGroups.preposition.ToString());
            result.Add(GrammaticalGroups.pronoun.ToString());
            result.Add(GrammaticalGroups.symbol.ToString());
            result.Add(GrammaticalGroups.verb.ToString());
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
