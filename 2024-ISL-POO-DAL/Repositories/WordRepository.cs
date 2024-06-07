using _2024_ISL_POO_DAL.Repositories.Bases;
using _2024_ISL_POO_DAL.Repositories.Interfaces;
using _2024_ISL_POO_Domain.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Repositories
{
    public class WordRepository : IWordRepository
    {
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

        public IEnumerable<IWord> Search(Filtre filtre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IWord> Search(IEnumerable<Filtre> filtres)
        {
            throw new NotImplementedException();
        }

        public IWord Update(int id, IWord model)
        {
            throw new NotImplementedException();
        }
    }
}
