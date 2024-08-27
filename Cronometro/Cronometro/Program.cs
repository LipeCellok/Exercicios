internal class Program
{
    private static void Main(string[] args)
    {
        //Menu();
        Start(6);
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundos");
        Console.WriteLine("M = Minutos");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto Tempo deseja Contar");

    }
    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Finalizado");
        Thread.Sleep(2500);
    }
}