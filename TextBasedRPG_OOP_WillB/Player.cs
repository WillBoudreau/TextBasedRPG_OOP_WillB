﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG_OOP_WillB
{

    internal class Player : Entity
    {
        public bool Playerturn = true;
        public Player()
        {
            x = 3;
            y = 3;
            healthSys.health = 3;
            damage = 3;
        }
        public static char Input()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.KeyChar == 'w')
            {
                return 'w';
            }
            else if (key.KeyChar == 'a')
            {
                return 'a';
            }
            else if (key.KeyChar == 's')
            {
                return 's';
            }
            else if (key.KeyChar == 'd')
            {
                return 'd';
            }
            else
            {
                return 'e';
            }
        }
        public void PlayerPOSMove(Enemy enemy)
        {
            if (Playerturn == true)
            {
                switch (Input())
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
            CombatMan.Combat(this, enemy);
        }
        public void POS(int x, int y)
        {
            this.x += x;
            this.y += y;
            switch (map.IsTileValid(this.x, this.y))
            {
                case '.':
                    break;
                case '#':
                    this.x -= x;
                    this.y -= y;
                    break;
                case '+':
                    TakeDamage(1);
                    break;
            }
        }
        public void TakeDamage(int damage)
        {
            healthSys.health -= damage;
            if (healthSys.health <= 0)
            {
                healthSys.health = 0;
            }
        }
         public void DisplayPlayer()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write('P');
            Console.ResetColor();
        }
    }
}