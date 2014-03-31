using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaRPG
{
    class Actor
    {
        private string _name = "";      // Name
        private int _iRace = -1;        // Element of _saRaces[]
        private int _iClass = -1;       // Element of _saClasses[]
        private int _iSex = -1;         // Element of _saSex[]
        private int _iToHit = 0;        // ToHit modifier
        private int _iEvade = 0;        // Evasion modifier
        private int _iDamage = 0;       // Damage modifier
        private int _iExp = 0;          // Amount of exp
        private int _iLevel = 0;        // Level
        private int _iHealth = 10;      // Hit points
        private int _iCurHealth = -10000;        // Current hit points
        private int _iHitDie = 6;       // Which die to use to calculate hit points
        private int[,] _iAttributes = { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 } };
        private int[] _iAttributeModifiers = { 0, 0, 0, 0, 0, 0};
        private bool _isPlayer = false; // Is object a player
        private bool _isEnemy = false;  // Is object an enemy

        private int _iWins = 0;         // Amount of wins
        private int _iLosses = 0;       // Amount of losses
        private int _iDraws = 0;        // Amount of draws

        private string[] _saRaces = { "Human", "Elf", "T-Rex" };
        private string[] _saSex = { "Male", "Female", "None" };
        private string[] _saClasses = { "Fighter", "Mage", "Rogue", "Ranger" };
        private string[] _saAttributes = { "Strength", "Dexterity", "Constituion", "Intelligence", "Charisma", "Wisdom" };
        //Enemies (ToHit, Evade, Damage, EXP)

        private string[] _saEnemies = { "Goblin", "Kobold", "Troll" };
//        private string[] _

                        Output output = new Output();

        //Properties
       
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int iRace
        {
            get
            {
                return _iRace;
            }
            set
            {
                _iRace = value;
            }
        }
        public int iClass
        {
            get
            {
                return _iClass;
            }
            set
            {
                _iClass = value;
            }
        }
        public int iSex
        {
            get
            {
                return _iSex;
            }
            set
            {
                _iSex = value;
            }
        }
        public int iToHit
        {
            get
            {
                return _iToHit;
            }
            set
            {
                _iToHit = value;
            }
        }
        public int iEvade
        {
            get
            {
                return _iEvade;
            }
            set
            {
                _iEvade = value;
            }
        }
        public int iDamage
        {
            get
            {
                return _iDamage;
            }
            set
            {
                _iDamage = value;
            }
        }
        public int iHealth
        {
            get
            {
                return _iHealth;
            }
            set
            {
                _iHealth = value;
            }
        }
        public int iCurHealth
        {
            get
            {
                if (_iCurHealth == -10000)
                {
                    _iCurHealth = 10;
                    return _iCurHealth;
                }
                else
                {
                    return _iCurHealth;
                }
            }
            set
            {
                _iCurHealth = value;
            }
        }
        public int iHitDie
        {
            get
            {
                return _iHitDie;
            }
            set
            {
                _iHitDie = value;
            }
        }
        public int iWins
        {
            get
            {
                return _iWins;
            }
            set
            {
                _iWins = value;
            }
        }
        public int iLosses
        {
            get
            {
                return _iLosses;
            }
            set
            {
                _iLosses = value;
            }
        }
        public int iDraws
        {
            get
            {
                return _iDraws;
            }
            set
            {
                _iDraws = value;
            }
        }
        public bool isPlayer
        {
            get
            {
                return _isPlayer;
            }
            set
            {
                _isPlayer = value;
            }
        }
        public bool isEnemy
        {
            get
            {
                return _isEnemy;
            }
            set
            {
                _isEnemy = value;
            }
        }
        public string Race
        {
            get
            {
                if (_isEnemy)
                {
                    return _saEnemies[iRace];
                }
                else
                {
                    return _saRaces[_iRace];
                }
                
            }

            set
            {

            }

        }
        public string Sex
        {
            get 
            {
                return _saSex[_iSex];
            }

            set 
            {
            
            }
            
       }
        public string Class
        {
            get
            {
                return _saClasses[_iClass];
            }

            set
            {

            }

        }
        public int Strength
        {
            get
            {
                return _iAttributes[0, 0];
            }

            set
            { 
            
            }
        }
        public int Dexterity
        {
            get
            {
                return _iAttributes[1, 0];
            }

            set
            { 
            
            }
        }
        public int Constitution
        {
            get
            {
                return _iAttributes[2, 0];
            }

            set
            { 
            
            }
        }
        public int Intelligence
        {
            get
            {
                return _iAttributes[3, 0];
            }

            set
            { 
            
            }
        }
        public int Charisma
        {
            get
            {
                return _iAttributes[4, 0];
            }

            set
            { 
            
            }
        }
        public int Wisdom
        {
            get
            {
                return _iAttributes[5, 0];
            }

            set
            { 
            
            }
        }
        public string[] SAAttributes
                {
                    get
                    {
                        return _saAttributes;
                    }

                    set
                    {

                    }
                }

        //Constructors

        public Actor(bool isPlayer, string pName, int piRace, int piSex, int piClass)
        {


        }

        public Actor()
        {


        }

        //Methods

        public void ToString()
        {
            Console.Write("iRace: {0}\niClass: {1}\niSex: {2}\niToHit: {3}\niEvade: {4}\niDamage: {5}\niHealth: {6}",_iRace,_iClass,_iSex,_iToHit,_iEvade,_iDamage,_iHealth);
            //return "";
        }

        //public createPlayer(string pName, int piRace, int piSex, int piClass)
        public void createPlayer()
        {
            bool active = true; // Kepe looping
            isPlayer = true; // createPlayer is used for Players, so should always be TRUE
            while (active) // Loop till we are done
            {
                while (_name.Length < 2)
                {
                    Console.Clear();
                    Console.Write("Enter your name: ");
                    _name = Console.ReadLine();
                }

                while (_iRace < 0 || _iRace > 2)
                {
                    Console.Clear();
                    Console.WriteLine("Available Races:");
                    // Loop through array of Races
                    //for (int i = 0; i < _saRaces.Length; i++)
                    //{
                    //    Console.WriteLine("("+i+")   -   " + _saRaces[i]);
                    //}
                    output.ListArray(_saRaces);
                    try
                    {
                        _iRace = Convert.ToInt32(Console.ReadLine());
                    }
                    catch 
                    {
                        Console.WriteLine("Please use numbers only.");
                        Console.ReadLine();
                    }
                    
                }
                while (_iSex < 0 || _iSex > 2)
                {
                    Console.Clear();
                    Console.WriteLine("Choose your sex:");
                    // Loop through array of Sexes
                    output.ListArray(_saSex);
                    try
                    {
                        _iSex = Convert.ToInt32(Console.ReadLine());
                    }
                    catch 
                    {
                        Console.WriteLine("Please use numbers only.");
                        Console.ReadLine();
                    }
                } 
                while (_iClass < 0 || _iClass > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Available Classes:");
                    // Loop through array of Classes
                    output.ListArray(_saClasses);
                    try
                    {
                        _iClass = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please use numbers only.");
                        Console.ReadLine();
                    }
                }
            //    bool doAttributes = true;

            //    while (doAttributes)
            //    {
            //        Console.Clear();
            //        int longestAttribute = output.GetLongest(_saAttributes);
            //        Console.WriteLine("Current attributes:");
            //        // Loop through array of Classes
            //        for (int i = 0; i < _saAttributes.Length; i++)
            //        {
            //            Console.WriteLine(_saAttributes[i] + ": ");
            //        }
            //        for (int i = 0; i < _saAttributes.Length; i++)
            //        {
            //            //  Console.WriteLine(_saAttributes[i]+": "+_iAttributes[i,0]);
            //            if (_iAttributes[i, 0] < 1)
            //            {


            //                Console.WriteLine("Strength: " + Strength);

            //            }
            //}


            //        doAttributes = false;
            //    }
                active = false;
                _iToHit = 1;
                _iEvade = 1;
                _iDamage = 3;
                Console.ReadLine();
                

            }

        }
    }
}
