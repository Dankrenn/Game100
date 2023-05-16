using Game100Classes;
using System;
using System.Net.Sockets;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Game game1 = new Game(0, 0, 0);
            Player player1 = new Player();
            Computer computer1 = new Computer();
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            player1.name = name;
            while (player1.count != 100)
            {
                Console.WriteLine("Выберете любое число от 1 до 10");
                string value = Console.ReadLine();
                player1.value = value;
                player1.n = player1.ValueConvert(value);
                if (player1.Validation_value(player1.n) == true)
                {
                    game1.CountN(player1.n, ref game1.count);
                    if (game1.CountWins(game1.count) == true)
                    {
                        Console.WriteLine($"Вы победили,{player1.name}");
                        return;
                    }
                    else
                    {
                        game1.schet++;
                    }
                    computer1.m = computer1.M(player1.n, game1.chek, game1.count);
                    game1.CountN(computer1.m, ref game1.count);
                    game1.chek++;
                    Console.WriteLine($"Ваше число: {player1.value}" + '\t' + $"Общий счет: {game1.count}" + '\t' + $"Ход соперника {computer1.m}");
                    if (game1.CountWins(game1.count) == true)
                    {
                        Console.WriteLine($"Вы проиграли,{player1.name}");
                        return;
                    }
                    else
                    {
                        game1.schet++;
                    }
                }

            }
        }
        catch (Exception)
        {
            Console.WriteLine("Неверный формат ,выполните перезапуск");
        }
    }
}