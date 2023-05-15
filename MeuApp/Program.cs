
namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {   
           Cliente cliente = new Cliente;

           cliente.Nome = "Jociel";
           
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