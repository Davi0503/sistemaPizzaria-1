namespace sistemaPizzaria.Class
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao{ get; set; }
	    public double Preco { get; set; }
	    public string Categoria { get; set;}
        public double DataCriacao { get; set; }
    }
}