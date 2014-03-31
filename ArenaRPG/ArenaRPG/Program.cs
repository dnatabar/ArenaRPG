using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ArenaRPG
{
    class Program
    {
        static void Main(string[] args)
        {

            Output testArray = new Output();
            Actor player = new Actor();


            System.IO.FileInfo enemyFile = new System.IO.FileInfo("Data\\enemies.txt"); 
            System.IO.StreamReader enemies = enemyFile.OpenText();
            string line;
            string[,] enemyInfo = new string[20,20]; // Array to store parsed text
            Actor[] Enemies = new Actor[10];
            int lineNum = 0;

            while ((line = enemies.ReadLine()) != null)
            {
                string[] items = line.Split('\t');
                string[] newItems;
                if (lineNum > 0)
                {
                    //Console.WriteLine(lineNum);
                    //newItems = items[lineNum].Split('\t');
                    Enemies[lineNum] = new Actor();
                    Enemies[lineNum].isEnemy = true;
                    Enemies[lineNum].iRace = Convert.ToInt32(items[1]);
                    Enemies[lineNum].iClass = Convert.ToInt32(items[2]);
                    Enemies[lineNum].iSex = Convert.ToInt32(items[3]);
                    Enemies[lineNum].iToHit = Convert.ToInt32(items[4]);
                    Enemies[lineNum].iEvade = Convert.ToInt32(items[5]);
                    Enemies[lineNum].iDamage = Convert.ToInt32(items[6]);
                    Enemies[lineNum].iHealth = Convert.ToInt32(items[7]);
                    Enemies[lineNum].iCurHealth = Enemies[lineNum].iHealth;
                    //Enemies[lineNum].iHitDie = Convert.ToInt32(items[1]);
                    Enemies[lineNum].Strength = Convert.ToInt32(items[8]);
                    Enemies[lineNum].Dexterity = Convert.ToInt32(items[10]);
                    Enemies[lineNum].Constitution = Convert.ToInt32(items[10]);
                    Enemies[lineNum].Intelligence = Convert.ToInt32(items[11]);
                    Enemies[lineNum].Charisma = Convert.ToInt32(items[12]);
                    Enemies[lineNum].Wisdom = Convert.ToInt32(items[13]);

                    //Console.ReadLine();
                    //Enemies[lineNum].ToString();
                }
                    //for (int i2 = 0; i2 < items.Length; i2++)
                    //{
                    //    enemyInfo[lineNum, i2] = items[i2];
                    //    //testArray.ListArray(newItems);
                    //    //Console.WriteLine("[{0},{1}] = {2}", lineNum, i2, enemyInfo[lineNum, i2]);
                    //    //Console.ReadLine();
                        
                    //}
                    lineNum++;
                    //Console.WriteLine("-");

                

                //foreach (string item in items)
                //{
                //    Console.WriteLine(item);
                //}
            }
            //testArray.ListEnemies(enemyInfo, lineNum);
            //Console.ReadLine();
            bool inMainMenu = true;
            while (inMainMenu)
            {
                int uinput = 0;
                Console.Clear();
                Console.WriteLine("Welcome to ArenaRPG!");
                Console.WriteLine("Do you wish to: ");
                Console.WriteLine("(1)   -   Make a new Character.\n(2)   -   Load a Character.");
                
                try
                {
                   uinput = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid Input!");
                    Thread.Sleep(500);                
                }

                switch (uinput)
                {
                    case 1:
                        player.createPlayer();
                        inMainMenu = false;
                        break;


                    default:
                        Console.WriteLine("Invalid Input.");
                        Thread.Sleep(500);
                        break;
                }
            }
            Actor goblin = new Actor(), kobold = new Actor();

            
            Console.WriteLine(player.Name);
            Console.WriteLine(goblin.Name);
 

            Console.WriteLine(player.Name);
            Console.WriteLine(player.Race);
            Console.WriteLine(player.Sex);
            Console.WriteLine(player.Class);

            Console.ReadLine();
            Console.Clear();

            string[] test = { "1", "22", "333", "4444", "55555", "88888888", "666666", "7777777" };

          //  Output testArray = new Output();
            int testInt = testArray.GetLongest(test);
            
            for (int i = 0; i < test.Length; i++)
            {

                Console.Write(test[i]);
                for (int i2 = test[i].Length; i2 < testInt; i2++)
                {
                    Console.Write(".");
                }
                
                
                Console.Write(": "+i);
                Console.WriteLine("");
            }
        
            string[] Strength =  {"Strength", player.Strength.ToString()};
            string[] Dexterity = { "Dexterity", player.Dexterity.ToString() };
            string[] Constitution = { "Constitution", player.Constitution.ToString() };
            string[] Intelligence = { "Intelligence", player.Intelligence.ToString() };
            string[] Charisma = { "Charisma", player.Charisma.ToString() };
            string[] Wisdom = { "Wisdom", player.Wisdom.ToString() };
            int testAtt = testArray.GetLongest(player.SAAttributes);
            testArray.AlignText(Strength, testAtt);
            testArray.AlignText(Dexterity, testAtt);
            testArray.AlignText(Constitution, testAtt);
            testArray.AlignText(Intelligence, testAtt);
            testArray.AlignText(Charisma, testAtt);
            testArray.AlignText(Wisdom, testAtt);

            int[,] _siEnemyInfo = { { 0, 2, 0, 0, 1 }, { 1, 2, 0, 0, 1 } };

            bool loop = true;
            int iInput = 0;
            while (loop)
            {
                Console.WriteLine("Type 1, 2 or 3 to fight!");

            try
            {
                iInput = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                //Console.WriteLine("Invalid Input.");
            }
            
                
                if (iInput > 0 && iInput < 4)
                {
                    //int e = 1;
                    Console.Clear();
                    Actor enemyToAttack = new Actor();
                    Encounter encounter = new Encounter();
                    //Console.WriteLine(enemyInfo[e,0]);
                    player = encounter.Fight(Enemies[iInput], player);
                    //encounter.Fight(player.iToHit, player.iEvade, player.iDamage, player.iHealth, Convert.ToInt32(enemyInfo[e, 1]), Convert.ToInt32(enemyInfo[e, 2]), Convert.ToInt32(enemyInfo[e, 3]), Convert.ToInt32(enemyInfo[e, 4]), Convert.ToInt32(enemyInfo[e, 5]), Convert.ToInt32(enemyInfo[e,6]), Convert.ToInt32(enemyInfo[e,7]));
                    //encounter.Fight(_siEnemyInfo[0, 0], _siEnemyInfo[0, 1], _siEnemyInfo[0, 2], _siEnemyInfo[0, 3], _siEnemyInfo[0, 4]);
                    iInput = 0;
                    Console.WriteLine("Total wins: {0}\nTotal Draws: {1}\nTotal Losses: {2}", player.iWins, player.iDraws, player.iLosses);
                    Thread.Sleep(500);
                }
                else if(iInput == 0)
                {
                    Console.WriteLine("Please type in a number");
                } else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            
            
            
            
            
            
            Console.ReadLine();
        }
    }
}
