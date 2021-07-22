using System;
using System.Collections.Generic;
using System.Text;

namespace Napilnik
{
    class Bot
    {
        private readonly Weapon _weapon;

        public Bot(Weapon weapon)
        {
            if (weapon == null)
                throw new ArgumentNullException(nameof(weapon));

            _weapon = weapon;
        }

        public void OnSeePlayer(Player player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (_weapon.CanFire())
                _weapon.Fire(player);
        }
    }
}
