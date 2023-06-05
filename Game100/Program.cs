using Game100Classes;
using System;
using System.ComponentModel.Design;
using System.Net.Sockets;

class Program
{
    public static bool Gamebots(int gamebots)
    {
        if (gamebots > 1 || gamebots < 0)
            throw new Exception("Неверный формат");
        if (gamebots == 0)
            return true;
        return false;
    }
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Выберете с кем вы хотите играть: \n 0 - если с компьютером \n 1 - если с игроком");
            bool gamebots = Gamebots(int.Parse(Console.ReadLine()));
            Game game1 = new Game(gamebots);
            if(game1.GetGameBots())
            {
                Console.WriteLine("Введите ваше имя игрок 1");
                game1.CreatePlayer(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Введите ваше имя игрок 1");
                string name1 = Console.ReadLine();
                Console.WriteLine("Введите ваше имя игрок 2");
                game1.CreatePlayer(name1,Console.ReadLine());
            }
            game1.MoveOrder();
            while (game1.CountWins() == false)
            {
                if(game1.GetMovePlayer1())
                {

                    Console.WriteLine($"Ход игрока {game1.player1.GetName()}");
                    game1.player1.SetStep(game1);
                }
                else
                {
                    Console.WriteLine($"Ход игрока {game1.player2.GetName()}");
                    game1.player2.SetStep(game1);
                }
                Console.WriteLine($"Счет  {game1.player1.GetName()}: {game1.player1.GetStep()}  \t Общий счет: {game1.GetCount()} \t Счет  {game1.player2.GetName()}: {game1.player2.GetStep()}");
                if (game1.CountWins())
                {
                    if (game1.GetMovePlayer1())
                        Console.WriteLine($"Победил {game1.player2.GetName()}");
                    else
                        Console.WriteLine($"Победил {game1.player1.GetName()}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}