using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.Weapons
{
    internal class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Вы замахиваетесь топором! Медленный, но мощный удар.");
        }
    }
}
