using Game100Classes;
using System;
using System.ComponentModel.Design;
using System.Net.Sockets;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Game game1 = new Game();
            Console.WriteLine("Выберете с кем вы хотите играть: \n 0 - если с компьютером \n 1 - если с игроком");
            game1.GameBots(Console.ReadLine());
            game1.CreatePlayer();
            Console.WriteLine("Введите ваше имя игрок 1");
            game1.player1.NameAdd(Console.ReadLine());
            if(game1.GameBotsReturn() == true)
            {
                Console.WriteLine($"Имя игрока 2 = {game1._player.NameReturn()}") ;
            }
            else
            {
                Console.WriteLine("Введите ваше имя игрок 2");
                game1._player.NameAdd(Console.ReadLine());
            }
            game1.PlayersNameValid(game1.player1);
            game1.MoveOrder();
            while (game1.CountWins() == false)
            {
                if(game1.MovePlayer1Return() == true)
                {
                    Console.WriteLine($"Игрок {game1.player1.NameReturn()}, выберете любое число от 1 до 10");
                    string str = Console.ReadLine();                    
                    game1.ValidationValue(Convert.ToInt32(str));
                    game1.player1.AdvancedValue(Convert.ToInt32(str));
                    game1.player1.ResultingValue(game1.CountReturn());
                    game1.CountUpdate(game1.player1.ResultingValueReturn());
                    game1.MovePlayer1Update(false);
                }
                else
                {

                    if (game1.GameBotsReturn() == true)
                    {
                        game1._player.ResultingValue(game1.CountReturn());
                        Console.WriteLine("Компьютор выбрал число:" + game1._player.ResultingValueReturn());
                    }
                    else
                    {                       
                        Console.WriteLine($"Игрок {game1._player.NameReturn()}, выберете любое число от 1 до 10");
                        string str = Console.ReadLine();
                        game1.player1.AdvancedValue(Convert.ToInt32(str));
                        game1.ValidationValue(Convert.ToInt32(str));
                        game1.player1.ResultingValue(game1.CountReturn());

                    }
                    game1.CountUpdate(game1._player.ResultingValueReturn());
                    game1.MovePlayer1Update(true);
                }
                Console.WriteLine($"Счет  {game1.player1.NameReturn()}: {game1.player1.ResultingValueReturn()}  \t Общий счет: {game1.CountReturn()} \t Счет  {game1._player.NameReturn()}: {game1._player.ResultingValueReturn()}");
                if (game1.CountWins() == true)
                {
                    if (game1.MovePlayer1Return() == false)
                    {
                        Console.WriteLine($"Победил {game1.player1.NameReturn()}");
                    }
                    else
                    {
                        Console.WriteLine($"Победил {game1._player.NameReturn()}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}