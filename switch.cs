using System;


internal class Program


{
    private static void Main(string[] args)
    {
        char a = Convert.ToChar(Console.ReadLine());

        switch (a)
        {
            case 'a':
                Console.WriteLine("You write a");
                break;
            default:
                Console.WriteLine("I dont know this");
                break;

        }

    }
}