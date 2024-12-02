using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.Models
{
    internal class Player
    {
        private IWeapon _weapon;

        public Player(IWeapon initialWeapon)
        {
            _weapon = initialWeapon;
        }

        public void SetWeapon(IWeapon newWeapon)
        {
            _weapon = newWeapon;
            Console.WriteLine("Оружие изменено!");
        }

        public void Attack()
        {
            _weapon.UseWeapon();
        }
    }
}
