﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG_OOP_WillB
{
    internal class GameManager
    {
        public GameManager() 
        {

            
        }
        public void GameInitialization()
        {
        }
        public void GameLoop()
        {
            Map map = new Map();
            Player player = new Player();
            Enemy enemy1 = new Enemy(5, 5, EnemType.Grunt);
            Enemy enemy2 = new Enemy(15, 15, EnemType.Chaser);
            Enemy enemy3 = new Enemy(14, 14, EnemType.Runner);
            List<Enemy> enemies = new List<Enemy> { enemy1, enemy2, enemy3 };
            HUD hud = new HUD(player, enemies);
            Player.hud = hud;
            map.MapArray();
            map.ShowMap();
            while (player.healthSys.health > 0)
            {
                Console.ResetColor();
                Console.WriteLine("\n");
                hud.DisplayHUD();
                Console.WriteLine("----------");
                player.DisplayPlayer();


                foreach (var enemy in enemies)
                {
                    enemy.DisplayEnemy();
                    enemy.EnemyMove(player);
                }
                player.PlayerPOSMove(enemies);
                Console.ResetColor();
            }
            Console.Clear();
            Console.WriteLine("Game Over");
            Console.ReadKey();
        }
    }
}
