using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.Weapons
{
    internal class Bow : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Вы выпускаете стрелу из лука! Дальний точный выстрел.");
        }
    }
}
