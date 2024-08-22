internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("Bem Vindo a Nossa Calculadora Interativa");
        Console.WriteLine("========================================");
        Console.WriteLine("Escolha a opção Desejada:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("0 - Sair");

        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {

            case 0: System.Environment.Exit(0); break;
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            default: Menu(); break;
        }
    }
    static void Soma()
    {
        Console.WriteLine("Digite o Primeiro Numero: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Segundo Numero: ");
        float v2 = float.Parse(Console.ReadLine());
        
        float resultado = v1 + v2;

        Console.WriteLine($"O Resultado da Soma é: {resultado}");        
    }

    static void Subtracao()
    {
        Console.WriteLine("Bem Vindo ao Menu de Subtração");
        Console.WriteLine("");
        Console.WriteLine("Digite o Primeiro Numero: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo Numero: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 - v2;

        Console.WriteLine($"O resultado da Subtração é: {resultado}");
    }
    
    static void Divisao()
    {
        Console.WriteLine("Bem Vindo ao Menu de Divisão");
        Console.WriteLine("");
        Console.WriteLine("Digite o primeiro Numero: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Segundo Numero: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 / v2;

        Console.WriteLine($"O resultado da divisão é: {resultado}");
    }
    
    static void Multiplicacao()
    {
        Console.WriteLine("Bem Vindo ao Menu de Multiplicação:");
        Console.WriteLine("");
        Console.WriteLine("Digite o primeiro Numero: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo Numero: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 * v2;

        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    }
}
