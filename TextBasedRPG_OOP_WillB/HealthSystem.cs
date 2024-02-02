﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG_OOP_WillB
{
    struct HealthVals
    {
    }
    internal class HealthSys
    {
        public int enemyhp;
        public int enemy2hp;
        public int playerhp;
        public int health;
        public int Attack;
        EnemyVals enemy = new EnemyVals();
        Enemy2Vals enemy2 = new Enemy2Vals();
        public HealthSys()
        {
            
        }
        public void SetHealth()
        {
            enemyhp = health;
            playerhp = health;
            enemy2hp = health;
        }
        public int GetHealth(int health)
        {
            this.health = health;
            SetHealth();
            return health;
        }
        public int GetAttack(int attack)
        {
            this.Attack = attack;
            return attack;

        }
        public void Heal(int hp)
        {
            health += hp;
        }
        public void TakeDamage(int damage)
        { 
            playerhp -= damage;
            enemyhp -= damage;
            enemy2hp -= damage;
            if(playerhp <= 0)
            {
                playerhp = 0;
            }
            if(enemyhp <= 0)
            {
                enemyhp = 0;
                enemy.EnemyActive = false;
            }
            if(enemy2hp <= 0)
            {
                enemy2hp = 0;
                enemy2.Enemy2Active = false;
            }
        }
    }
}
