using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Repositories.Bases
{
    public class Filtre
    {
        public Filtre() { }
        public Filtre(string champ, object valeur)
        {
            Champ = champ;
            Valeur = valeur;
        }
        public string Champ { get; set; }
        public object Valeur { get; set; }
        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Filtre))
            {
                Filtre f = (Filtre)obj;
                return Champ.Equals(f.Champ) && Valeur.Equals(f.Valeur);
            }
            return base.Equals(obj);
        }
    }
}
