namespace PadariaDoceAroma.Models
{
    public class Item
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        public double Valor { get; set; }

        public Boolean Vegano { get; set; }

        public TipoCategoria Categoria { get; set; }

        public String  Descricao { get; set; }
    }

/*    public enum TipoCategoria
    {
        Salgado, Doce, Bebida
    }*/
}
