﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG_OOP_WillB
{
    struct EnemyVals
    {
        public int StartX;
        public int StartY;
        public bool Enemyturn;
        public bool EnemyActive;
    }
    internal class Enemy:Entity
    {
        EnemyVals enemyVals = new EnemyVals();
        public Enemy()
        {
            x = 15;
            y = 15;
            enemyVals.Enemyturn = true;
            enemyVals.EnemyActive = true;
        }
        public static char EnemyInput()
        {
            Random rnd = new Random();
           int Move =  rnd.Next(1,4);
            if (Move == 1)
            {
                return 'w';
            }
            else if (Move == 2)
            {
                return 'a';
            }
            else if (Move == 3)
            {
                return 's';
            }
            else if (Move == 4)
            {
                return 'd';
            }
            else
            {
                return 'e';
            }
        }
        public void EnemyPOSMove()
        {
            {
                switch (EnemyInput())
                {
                    case 'w':
                        POS(0, -1);
                        break;
                    case 'a':
                        POS(-1, 0);
                        break;
                    case 's':
                        POS(0, 1);
                        break;
                    case 'd':
                        POS(1, 0);
                        break;
                }

            }
        }
        public void DisplayEnemy()
        {
            if(enemyVals.EnemyActive == true)
            {
                Console.SetCursorPosition(this.x, this.y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write('E');
                Console.ResetColor();
            }
            else
            {
                
            }
        }
        public void AttackPlayer(Player player)
        {
            if(Math.Abs(this.x - player.x) == 1 && Math.Abs(this.y - player.y) == 1)
            {
                player.healthSys.TakeDamage(1);
                return;
            }
        }
    }
}
