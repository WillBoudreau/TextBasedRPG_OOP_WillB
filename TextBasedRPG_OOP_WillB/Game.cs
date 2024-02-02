﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG_OOP_WillB
{
    internal class Game
    {
        Displaymap map = new Displaymap();
        Player player = new Player();
        Enemy enemy = new Enemy();
        PlayerVals playerVals = new PlayerVals();
        EnemyVals enemyVals = new EnemyVals();
        public Game() 
        {

        }
        public void GameStart()
        {
            Console.WriteLine("Welcome to my Text Based RPG\nPress any key to begin");
            Console.ReadKey();
            Console.Clear();

            while (player.healthSys.playerhp > 0)
            {
                map.MapArray();
                ShowHUD();
                Console.WriteLine(player.x + " " + player.y);
                Console.WriteLine(enemy.x + " " + enemy.y);
                player.DisplayPlayer();
                enemy.DisplayEnemy();
                player.PlayerPOSMove();
                enemy.EnemyPOSMove();
                player.AttackEnemy(enemy);
                enemy.AttackPlayer(player);
            }
            Console.Clear();
            Console.WriteLine("Game Over...Press any key to quit");
            Console.ReadKey();
        }
        public void StartUp()
        {
            player.healthSys.GetHealth(5);
            enemy.healthSys.GetHealth(5);
            player.healthSys.GetAttack(1);
            enemy.healthSys.GetAttack(1);
        }
        public void ShowHUD()
        {
            Console.WriteLine("\nPlayer Health: " + player.healthSys.playerhp + "| Player Attack: " + player.healthSys.Attack);
            Console.WriteLine("Enemy Health: " + enemy.healthSys.enemyhp + "| Enemy Attack: " + enemy.healthSys.Attack);
        }
    }
}