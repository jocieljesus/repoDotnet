
using System.Text;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {   
         
           var id = Guid.NewGuid();
           id.ToString();
           var senha = id.ToString().Substring(0, 8);

           var price = 10.4;
           var produto = "xocolate";
           var texto = "O preco do produto é " + price;
           var texto2 = string.Format("O preco do {0} é {1}  ", produto, price);
           var texto3 = $"O preco do {produto} é  {price}  ";
           var texto4 = @"Adiciona o arrobara
           para conseguir continuar 
           escrevendo em outra linha  ";
           var product = produto.Replace("xo", "cho");

           var texto5 = texto4.Trim();

           var comparando = texto2.CompareTo(texto3);

           var textogrande = new StringBuilder();

            textogrande.Append(produto);
            textogrande.Append(texto2);
            textogrande.Append(texto3);
            textogrande.Append(texto4);
            textogrande.Append(texto5);


            Console.WriteLine(textogrande);


            Console.WriteLine(product);
        
        }

    }

    struct Product 
    {
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public int Id;
        public string Name;
        public double Price;
        
        public double PriceInDolar( double dolar)
        {
            return Price * dolar;
        }
    }

    struct Cliente
    {
        public string Nome;
        public EEstadoCivil estadoCivil;
        
    }

    enum EEstadoCivil
    {
        BRL = 748,
        EUR = 328,
        USD  = 034,
        GPB = 048

    }
} 