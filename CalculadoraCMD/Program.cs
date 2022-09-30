namespace CalculadoraCMD
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Multiplicacao, Divisao, Potencia, Sair }
        static void Main(string[] args)
        {
            bool fecharCalculadora = false;
            while (!fecharCalculadora)
            {
                Console.WriteLine("Calculadora CMD");

                Console.WriteLine("Digite o primeiro numero: ");
                double primeiroNumero = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                double segundoNumero = double.Parse(Console.ReadLine());

                Console.WriteLine("Escolha o operador: \n");
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Potencia\n6 - Sair");
                int opcaoUsuario = int.Parse(Console.ReadLine());
                Menu operadorSelecionado = (Menu)opcaoUsuario;

                switch (operadorSelecionado)
                {
                    case Menu.Soma:
                        Console.WriteLine("A soma é: " + soma(primeiroNumero, segundoNumero));
                        break;
                    case Menu.Subtracao:
                        Console.WriteLine("A subtração é: " + subtracao(primeiroNumero, segundoNumero));
                        break;
                    case Menu.Divisao:
                        Console.WriteLine("A divisão é: " + divisao(primeiroNumero, segundoNumero));
                        break;
                    case Menu.Multiplicacao:
                        Console.WriteLine("A multiplicação é: " + multiplicacao(primeiroNumero, segundoNumero));
                        break;
                    case Menu.Potencia:
                        Console.WriteLine("A potência é: " + potencia(primeiroNumero, segundoNumero));
                        break;
                    case Menu.Sair:
                        fecharCalculadora = true;
                        break;
                }
           
            }
            
        }
        static double soma(double n1, double n2)
        {
            return n1 + n2;
        }

        static double subtracao(double n1, double n2)
        {
            return n1 - n2;
        }

        static double divisao(double n1, double n2)
        {
            return n1 / n2;
        }

        static double multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }

        static double potencia(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }
    }
}