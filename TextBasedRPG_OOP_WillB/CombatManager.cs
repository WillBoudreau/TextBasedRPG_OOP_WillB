﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG_OOP_WillB
{
    internal class CombatManager
    {
        public CombatManager() 
        {

        }
        public void Combat(Player player,Enemy enemy)
        {
            if(player.Playerturn == true)
            {

                if(player.x == enemy.x && player.y == enemy.y)
                {
                    player.Attacked = true;
                    enemy.TakeDamage(player.damage);
                }
            }
        }
    }
}