using System;
using System.Collections.Generic;
using System.Text;

namespace Napilnik
{
    class Weapon
    {    
        private readonly int _damage;
        private readonly int _bulletsPerShot;
        private int _bullets;

        public Weapon(int damage, int bulletsPerShot, int bullets)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            if (bulletsPerShot <= 0)
                    throw new ArgumentOutOfRangeException(nameof(bulletsPerShot));

            if (bullets < 0)
                throw new ArgumentOutOfRangeException(nameof(bullets));

            _damage = damage;
            _bulletsPerShot = bulletsPerShot;
            _bullets = bullets;
        }

        public bool CanFire() => _bullets - _bulletsPerShot >= 0;

        public void Fire(Player player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (CanFire() == false)
                throw new ArgumentOutOfRangeException();

            _bullets -= _bulletsPerShot;

            player.TakeDamage(_damage);
        }
    }
}
