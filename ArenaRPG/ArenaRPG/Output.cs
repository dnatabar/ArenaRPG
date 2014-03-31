using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaRPG
{
    class Output
    {

        //getLongest(string[] array)
        //Summary: 
        //  Gets length of the longest element in an array.
        //
        //Parameters:
        //  array:
        //      non-empty array.
        //
        //Returns:
        //  The length of the longest element in an array.
        //  
        public int GetLongest(string[] array)
        {
            int iaTest = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > iaTest)
                {
                    //Console.WriteLine("Org iaTest = " + iaTest);
                    iaTest = array[i].Length;
                    //Console.WriteLine("New iaTest = " + iaTest);
                }
                else
                {
                }
            }
            return iaTest;
        }

        public void AlignText(string[] text, int align)
        {
            //int longest = GetLongest(array);
                Console.Write(text[0]+": ");
                for (int i2 = text[0].Length; i2 < align; i2++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(text[1]);

        }

        public void ListArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("({0})   -   {1}", i, array[i]);
            }
        }

        //public void ListArray(string[,] array)
        //{

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine(array.Length);
        //    }

        //}

        //public void ShowCharacterSheet(string _name, string _race, string _class, int toHit, int evade, int damage, int exp, int level, bool isPlayer, bool isEnemy)
        //{
        //}

        public void ListEnemies(string[,] array, int lines)
        {

      

        }
        public void ShowCharacterSheet(string _name, string _race, string _class, int toHit, int evade, int damage, int exp, int level, bool isPlayer, bool isEnemy, int wins, int losses, int draws)
        {
            
            
        }
    }
}
