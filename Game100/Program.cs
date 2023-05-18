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
            Player player1 = new Player();
            Console.WriteLine("Выберете с кем вы хотите играть: \n 1 - если с компьютером \n 2 - если с игроком");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваше имя игрок 1");

            player1.NameUpdate(Console.ReadLine());



            switch (choice)
            {
                case 1:
                    Computer computer1 = new Computer();
                    while (game1.CountReturn() != 100)
                    {

                        Console.WriteLine("Выберете любое число от 1 до 10");
                        string value = Console.ReadLine();
                        if (player1.Validation_value(value) == true)
                        {
                            player1.MoveUpdate(value);
                            game1.CountUpdate(player1.MoveReturn());
                            if (game1.CountWins(game1.CountReturn()) == true)
                            {
                                Console.WriteLine($"Вы победили,{player1.NameReturn()}");
                                return;
                            }
                            computer1.MoveUpdate(computer1.SearchMove(player1.MoveReturn(), game1.ChekReturn(), game1.CountReturn()));
                            game1.CountUpdate(computer1.MoveReturn());
                            game1.ChekApp();
                            Console.WriteLine($"Ваше число: " + player1.MoveReturn() + '\t' + $"Общий счет: {game1.CountReturn()}" + '\t' + $"Ход соперника {computer1.MoveReturn()}");
                            if (game1.CountWins(game1.CountReturn()) == true)
                            {
                                Console.WriteLine($"Вы проиграли,{player1.NameReturn()}");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат ,выполните перезапуск");
                        }


                    }
                    break;

                case 2:
                    Player player2 = new Player();
                    Console.WriteLine("Введите ваше имя игрок 2");
                   
                    player2.NameUpdate(Console.ReadLine());
                    while (game1.CountReturn() != 100)
                    {
                        Console.WriteLine("Выберете любое число от 1 до 10");
                        string str = Console.ReadLine();
                        if (player1.Validation_value(str) == true)
                        {
                            player1.MoveUpdate(str);
                            game1.CountUpdate(player1.MoveReturn());
                            if (game1.CountWins(game1.CountReturn()) == true)
                            {
                                Console.WriteLine($"Вы победили,{player1.NameReturn()}");


                                break;
                            }
                        }
                    }
                    break;
            }
        }

        catch (Exception)
        {
            Console.WriteLine("Неверный формат ,выполните перезапуск");
        }
    }
}
