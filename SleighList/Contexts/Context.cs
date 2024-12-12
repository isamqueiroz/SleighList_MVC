using SleighList.Models;
using Microsoft.EntityFrameworkCore;

namespace SleighList.Contexts
{
    // Classe que terá as informações do banco de dados
    public class Context : DbContext
    {
        // Criar um método construtor
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        // OnConfiguring -> Possui a configuracao da conexao com
        //o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // colocar as informacoes do banco
            // As configuracoes existem?
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("NOTE30-S28\\SQLEXPRESS; Initial Catalog = SleighList_mvc; User Id=sa; Password=123; TrustServerCertificate = true");

            }
        }


        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Item> Item { get; set; }


    }
}