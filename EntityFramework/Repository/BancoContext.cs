using System;
using System.Collections.Generic;
using System.Data.Entity; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Repository
{

    /// <summary>
    /// 
    /// Classe de contexto de banco de dados
    /// Necessário instalar o Entity Framework via Nuget
    /// 
    /// </summary>
    class BancoContext: DbContext
    {
        //É necessário passar a connection string para o construtor da classe DbContext.
        // A connection string pode estar no arquivo app.config ou no arquivo web.config
        public BancoContext(): base("banco")
        {

        }

        public DbSet<Models.Tabela> Tabela { get; set; }
    }
}
