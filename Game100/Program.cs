using Game100Classes;
using System;
using System.Net.Sockets;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Game game1 = new Game();
            Player playergame;
            Console.WriteLine("Выберете с кем вы хотите играть: \n 1 - если с компьютером \n 2 - если с игроком");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваше имя игрок 1");
            Player player1 = new Player(Console.ReadLine());
            Player player2;
            if (choice == 2)
            {
                Console.WriteLine("Введите ваше имя игрок 2");
                player2 = new Player(Console.ReadLine());
            }
            else
            {
                player2 = new Player("PC");
            }
            if (game1.MoveOrder() == true)
            {
                playergame = player1;
            }
            else
            {
                playergame = player2;
            }
            while (game1.CountReturn() != 100)
            {
                if(choice == 2 || playergame == player1)
                {
                    Console.WriteLine($"Игрок {playergame.NameReturn()}, выберете любое число от 1 до 10");
                    string value = Console.ReadLine();
                    if (game1.ValidationValue(value) != true)
                    {
                        Console.WriteLine("Неверный формат ,выполните перезапуск");
                        return;
                    }
                    playergame.ResultingValue(game1.ValueConvert(value));                   
                }
                if (choice == 1 && playergame == player2)
                {
                    Console.WriteLine("Ход компьютера");
                    playergame.AdvancedValue(player1.ResultingValueReturn());
                    playergame.ResultingValue(game1.ChekReturn(),game1.CountReturn());
                }
                game1.CountUpdate(playergame.ResultingValueReturn());
                Console.WriteLine($"Счет  {player1.NameReturn()}: {player1.ResultingValueReturn()}  \t Общий счет: {game1.CountReturn()} \t Счет  {player2.NameReturn()}: {player2.ResultingValueReturn()}");
                if (game1.CountWins(game1.CountReturn()) == true)
                {
                    Console.WriteLine($"Победил {playergame.NameReturn()}");
                    return;
                }
                game1.ChekApp();
                if (playergame == player1)
                {
                    playergame = player2;
                }
                else
                {
                    playergame = player1;
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Неверный формат ,выполните перезапуск");
        }
    }
}