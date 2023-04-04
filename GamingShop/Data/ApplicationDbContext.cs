using GamingShop.Models;
using Microsoft.EntityFrameworkCore;

namespace GamingShop.Data
{
    // O entity framework serve para ajudar na interação com as entidades do banco de dados (criação, alteração etc)
    // Esse arquivo foi criado para ajudar na conexão com o banco de dados através de uma instanciação que será usada no program.cs
    public class ApplicationDbContext : DbContext
    {
        // Criando um construtor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
               
        }

        // Criando a tabela Videogames do tipo VideogamesModel, ou seja, com os campos sendo as propriedades da classe
        public DbSet<VideogamesModel> Videogames { get; set; }
    }
}
