using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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


        //Não é necessário colocar isso abaixo, porém ele é a classe que vai configurar algumas propriedades do entity
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Essa configuração faz o entity não criar uma tabela pluralizada.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }



    }
}
