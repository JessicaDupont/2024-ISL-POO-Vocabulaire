﻿using _2024_ISL_POO_DAL.ADO;
using _2024_ISL_POO_DAL.Mapping;
using _2024_ISL_POO_DAL.Mapping.Bases;
using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_DAL.Repositories.Interfaces;
using _2024_ISL_POO_Domain.IModels;
using _2024_ISL_POO_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Repositories
{
    public class WordRepository : RepositoryBase, IWordRepository
    {
        private readonly WordMapping _mapWord;
        public WordRepository() : base()
        {
            _mapWord = new WordMapping();
        }
        public IWord Create(IWord model)
        {
            throw new NotImplementedException();
        }

        public IWord Delete(IWord model)
        {
            throw new NotImplementedException();
        }

        public IWord Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IWord Read(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IWord> Read()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IWord> Search(Filter filtre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IWord> Search(IEnumerable<Filter> filters)
        {
            List<IWord> words = new List<IWord>();
            Command cmd = _mapWord.Mapping(null, CRUD.List);
            words.AddRange(connect.ExecuteReader(cmd, reader => _mapWord.Mapping(reader)));
            IEnumerable<IWord> result = words;
            foreach (Filter f in filters)
            {
                switch (f.Champ) 
                {
                    case Filters.language1:
                        result = result.Where(r => r.Language.Id == (int)f.Valeur);
                        break;
                    case Filters.language2:
                        result = result.Where(r => r.Traduction.Exists(t => t.Language.Id == (int)f.Valeur));
                        break;
                    case Filters.serie:
                        //TODO serie
                        break;
                    case Filters.grammaticalGroup:
                        if (!GrammaticalGroups.ALL.ToString().Equals(f.Valeur))
                        {
                            result = result.Where(r => r.Group.Compare((string)f.Valeur));
                        }
                        break;
                    case Filters.noTested:
                        //TODO stats
                        break;
                    case Filters.fails:
                        //TODO stats
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            return result;
        }

        public IWord Update(int id, IWord model)
        {
            throw new NotImplementedException();
        }
    }
}
