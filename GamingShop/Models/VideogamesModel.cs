namespace GamingShop.Models
{
    // Essa é a classe VideogamesModel, que conterá as informações sobre os videogames e será usada como base para a criação da Tabela VideogamesBase
    public class VideogamesModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
