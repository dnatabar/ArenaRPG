using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ArenaRPG
{
    class Encounter
    {

        Random rnd = new Random();
        public Actor Fight(Actor enemy, Actor player)
        {
            Actor _enemy = enemy;
            Actor _player = player;
            while (_enemy.iCurHealth > 0 && _player.iCurHealth > 0)
            {
            int pRoll = Roll(20, _player.iToHit - _enemy.iEvade);
            int eRoll = Roll(20, _enemy.iToHit - _player.iEvade);
            Console.Clear();
            Console.WriteLine("Fighting a "+_enemy.Race);
            Console.WriteLine("You roll: "+pRoll);
            Console.WriteLine(_enemy.Race+"\'s roll: "+eRoll);
            if (pRoll > eRoll)
            {
                int dmg = Math.Max(rnd.Next(1, 4) + _player.iDamage, 0);
                Console.WriteLine("\nYou hit {0} for {1} damage!",_enemy.Race, _player.iDamage);
                _enemy.iCurHealth += -dmg;
                Console.WriteLine("\n{0}'s HP: {1}\nYour HP: {2}", _enemy.Race, _enemy.iCurHealth, player.iCurHealth);
                Thread.Sleep(750);
            }
            else if (eRoll > pRoll)
            {
                int dmg = Math.Max(rnd.Next(1, 4) + _enemy.iDamage, 0);
                Console.WriteLine("\n{0} hit You for {1} damage!", _enemy.Race, _player.iDamage);
                _player.iCurHealth += -dmg;
                Console.WriteLine("\n{0}'s HP: {1}\nYour HP: {2}", _enemy.Race, _enemy.iCurHealth,player.iCurHealth);
                Thread.Sleep(750);
            }

            }
            if (_enemy.iCurHealth <= 0)
            {
                Console.WriteLine("\nYou win!\n");
                _player.iWins++;
                _player.iCurHealth = 10;
                _enemy.iCurHealth = _enemy.iHealth;
                return _player;
            }
            //else if ()
            //{
            //    Console.WriteLine("Its a Draw!");
            //    player.iDraws++;
            //    return player;
            //}
            else if (_player.iCurHealth <= 0)
            {
                Console.WriteLine("\nYou lose!\n");
                _player.iLosses++;
                _player.iCurHealth = 10;
                _enemy.iCurHealth = _enemy.iHealth;
                return _player;
            }
            else
            {
                return _player;
            }

        }
        public int Fight(int pToHit, int pEvade, int pDamage, int pHealth, int race, int iClass, int sex, int toHit, int evade, int damage, int health)
        
        {
            Console.WriteLine("Player:\n pToHit: {0}, pEvade: {1}, pDamage: {2}, pHealth: {3}", pToHit, pEvade, pDamage, pHealth);
            Console.ReadLine();
            Actor enemy = new Actor();
            
            enemy.isEnemy = true;
            enemy.iRace = race;
            enemy.iSex = sex;
            enemy.iClass = iClass;
            enemy.iToHit = toHit;
            enemy.iEvade = evade;
            enemy.iDamage = damage;
            enemy.iHealth = health;
            Console.WriteLine("race: {0} - iClass: {1} - sex: {2} - toHit: {3} - evade: {4} - damage: {5} - health: {6}", enemy.Race, enemy.Class, enemy.Sex, enemy.iToHit, enemy.iEvade, enemy.iDamage, enemy.iHealth);
            Console.ReadLine();
            int pRoll = Roll(20, pToHit-enemy.iEvade);
            int eRoll = Roll(20, enemy.iToHit - pEvade);

            Console.Clear();
            Console.WriteLine("Fighting a "+enemy.Race);
            Console.WriteLine("You roll: "+pRoll);
            Console.WriteLine(enemy.Race+"\'s roll: "+eRoll);

            if (pRoll > eRoll)
            {
                Console.WriteLine("You win!");
                return 0;
            }
            else if ( pRoll == eRoll)
            {
                Console.WriteLine("Its a Draw!");
                return 1;
            } else
            {
                Console.WriteLine("You lose!");
                return 2;
            }
        }

        public int Roll(int die, int modifier)
        {
            return rnd.Next(1, die+1) + modifier;

        }

    }
}
