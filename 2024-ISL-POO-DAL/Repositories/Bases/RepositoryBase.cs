using _2024_ISL_POO_DAL.ADO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_DAL.Repositories.Bases
{
    public abstract class RepositoryBase
    {
        private string sourceDB =
            "Data Source=(localdb)\\ProjectModels;" +
            "Initial Catalog=2024-ISL-POO;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=False;" +
            "Trust Server Certificate=False;" +
            "Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False";

        protected readonly Connexion connect;//Classe créée précédemment dans le dossier ADO

        public RepositoryBase()
        {
            connect = new Connexion(SqlClientFactory.Instance, sourceDB);
        }
    }
}
