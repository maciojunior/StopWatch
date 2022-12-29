using System;
using System.Threading;

namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
            //Play();

        }

        static void Start()
        {
            Console.WriteLine("Abrindo Cronometro...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Digite iniciar Para começar o programa:");
            String Input = Console.ReadLine();
            
            while (Input != "iniciar")
            {
                Console.WriteLine("Este comando é inválido, tente novamente!\n");
                Input = Console.ReadLine();
                
            }
            if (Input == "iniciar")
            {
                int currentTime = 5;
                int time = 0;
                Console.WriteLine("O Cronometro foi inciado");
                while (currentTime != time)
                {
                    Console.Clear();
                    currentTime--;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(300);
                }
            }
            Console.WriteLine("Tempo esgotado!");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Digite: timereset para reiniciar o programa");
            String Exit = Console.ReadLine();

            while (Input != "timereset")
            {
                Console.WriteLine("Comando inválido, tente novamente ou digite exit parar sair.");
                Input = Console.ReadLine();
                if (Input == "exit")
                {
                    Console.WriteLine("O seu programa está sendo finalizado!");
                    System.Environment.Exit(0);
                }
            }
            if (Input == "timereset")
            {
                Start();
            }
        }
    }
}