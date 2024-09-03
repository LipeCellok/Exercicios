internal class Program
{
    private static void Main(string[] args)
    {
        Menu();

    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundos");
        Console.WriteLine("M = Minutos");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto Tempo deseja Contar");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
<<<<<<< HEAD
        int time = int.Parse(data.Substring(0, data.Length -1));
=======
        int time = int.Parse(data.Substring(0, data.Length - 1));
>>>>>>> 66037ce4a1942ae97d6d0e81a863cd1103749955
        int multiplier = 1;

        if (type == 'm')
            multiplier = 60;

        if (time == 0)
            System.Environment.Exit(0);

        PreStart(time * multiplier);


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
        Menu();
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go...");
        Thread.Sleep(2500);

        Start(time);
    }
}