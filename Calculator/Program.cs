namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string res;
            do{
                Menu();
                Console.WriteLine("Quer voltar a calculadora? s/n");
                res = Console.ReadLine();
            } while ( res.ToLower() == "s");
            
        }

        static void Menu()
        {
            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção: ");
            short opcao = short.Parse(Console.ReadLine());
            
            Console.Clear();

            switch(opcao)
            {   
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    Menu();
                    break;
            }
        }
        static void Soma()
        {
            Console.WriteLine("Informe um numero: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro numero: ");
            double v2 = double.Parse(Console.ReadLine());

            double soma = v1 + v2;
            Console.WriteLine($"O resultado da soma é {soma}");
        }

        static void Subtracao()
        {
            Console.WriteLine("Informe um numero: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro numero: ");
            double v2 = double.Parse(Console.ReadLine());

            double subtracao = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {subtracao}");
        }

        static void  Multiplicacao()
        {
            Console.WriteLine("Informe um numero: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro numero: ");
            double v2 = double.Parse(Console.ReadLine());

            double multiplicacao = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {multiplicacao}");
        }

        static void Divisao()
        {
            Console.WriteLine("Informe um numero: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro numero: ");
            double v2 = double.Parse(Console.ReadLine());

            if(v2 == 0 ){
                Console.WriteLine("ATENÇÃO: Não é possível realizar divisão por 0");
            } else {
                double divisao = v1 / v2;
                Console.WriteLine($"O resultado da divisõa é {divisao}");
            }
            
        }
    }
}