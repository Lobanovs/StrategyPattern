using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.Weapons
{
    internal class Sword : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Вы размахиваете мечом! Сильный удар.");
        }
    }
}
