using _2024_ISL_POO_DAL.ADO.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Repositories.Bases
{
    public enum Filters { 
        language1,
        language2,
        serie,
        grammaticalGroup,
        noTested,
        fails
    }
    public class Filter
    {
        public Filter() { }
        public Filter(Filters champ, object valeur)
        {
            Champ = champ;
            Valeur = valeur;
        }
        public Filters Champ { get; set; }
        public object Valeur { get; set; }
        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Filter))
            {
                Filter f = (Filter)obj;
                return Champ.Equals(f.Champ) && Valeur.Equals(f.Valeur);
            }
            return base.Equals(obj);
        }
    }
}
