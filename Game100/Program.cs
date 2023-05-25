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
            Computer computer1 = new Computer();
            Player player2 = new Player();
            Console.WriteLine("Выберете с кем вы хотите играть: \n 1 - если с компьютером \n 2 - если с игроком");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваше имя игрок 1");
            Player player1 = new Player(Console.ReadLine());            
            bool b = game1.MoveOrder();
            while (game1.CountWins() == false)
            {
                if(b == true)
                {
                    Console.WriteLine($"Игрок {player1.NameReturn()}, выберете любое число от 1 до 10");
                    string value = Console.ReadLine();
                    if (game1.ValidationValue(value) != true)
                    {
                        Console.WriteLine("Неверный формат ,выполните перезапуск");
                        return;
                    }
                    player1.ResultingValue(game1.ValueConvert(value));
                    game1.CountUpdate(player1.ResultingValueReturn());
                    b = false;
                    if(choice == 2)
                    {
                        Console.WriteLine($"Счет  {player1.NameReturn()}: {player1.ResultingValueReturn()}  \t Общий счет: {game1.CountReturn()} \t Счет  {player2.NameReturn()}: {player2.ResultingValueReturn()}");
                    }
                }
                else
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("Компьютор выбрал число:" + game1.MoveComputer(computer1, player1));
                        game1.CountUpdate(computer1.ResultingValueReturn());
                        Console.WriteLine($"Счет  {player1.NameReturn()}: {player1.ResultingValueReturn()}  \t Общий счет: {game1.CountReturn()} \t Счет PC: {computer1.ResultingValueReturn()}");
                        b = true;
                    }
                    else
                    {
                        if (game1.ChekReturn() == 0 || game1.CountReturn() == 1 )
                        {
                            Console.WriteLine("Введите ваше имя игрок 2");
                            if(game1.PlayerNameValid(player1.NameReturn(),Console.ReadLine()) == true)
                            {
                                player2.NameAdd(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Неверный формат ,выполните перезапуск");
                                return;
                            }
                        }
                        Console.WriteLine($"Игрок {player2.NameReturn()}, выберете любое число от 1 до 10");
                        string value = Console.ReadLine();
                        if (game1.ValidationValue(value) != true)
                        {
                            Console.WriteLine("Неверный формат ,выполните перезапуск");
                            return;
                        }
                        player2.ResultingValue(game1.ValueConvert(value));
                        game1.CountUpdate(player2.ResultingValueReturn());
                        Console.WriteLine($"Счет  {player1.NameReturn()}: {player1.ResultingValueReturn()}  \t Общий счет: {game1.CountReturn()} \t Счет  {player2.NameReturn()}: {player2.ResultingValueReturn()}");
                        b = true;
                    }
                }             
                if (game1.CountWins() == true)
                {
                    if (b == false)
                    {
                        Console.WriteLine($"Победил {player1.NameReturn()}");
                        return;
                    }
                    else
                    {
                        if (choice == 1)
                        {
                            Console.WriteLine($"Победил PC");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"Победил {player2.NameReturn()}");
                            return;
                        }
                    }
                }
                game1.ChekApp();
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Неверный формат ,выполните перезапуск");
        }
    }
}