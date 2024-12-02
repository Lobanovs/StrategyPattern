using StrategyPattern.Models;
using StrategyPattern.Weapons;
using System;

namespace StrategyPattern
{
    internal class Game
    {
        public void Start()
        {
            Console.WriteLine("Добро пожаловать в игру!");

            // Начальное оружие
            var sword = new Sword();
            var player = new Player(sword);

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Атаковать");
                Console.WriteLine("2. Изменить оружие");
                Console.WriteLine("3. Выйти");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        player.Attack();
                        break;

                    case "2":
                        Console.WriteLine("Выберите новое оружие:");
                        Console.WriteLine("1. Меч");
                        Console.WriteLine("2. Лук");
                        Console.WriteLine("3. Топор");

                        var weaponChoice = Console.ReadLine();
                        switch (weaponChoice)
                        {
                            case "1":
                                player.SetWeapon(new Sword());
                                break;
                            case "2":
                                player.SetWeapon(new Bow());
                                break;
                            case "3":
                                player.SetWeapon(new Axe());
                                break;
                            default:
                                Console.WriteLine("Неверный выбор оружия.");
                                break;
                        }
                        break;

                    case "3":
                        Console.WriteLine("Выход из игры...");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
    }
}
