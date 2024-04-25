using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_text
{

    enum PlayerJob
    {
        Swordman = 1,
        Archer = 2,
        Magician = 3,
        Newbie = 0,
    }


    public class Player
    {
        public int level;
        public string job;
        public int money;

        public int hp;
        public int mp;

        public int attackDamage_index;
        public int deffence_index;

        public string ShowPlayerLevel(int Level)
        {
            if (Level > 0)
            {
                if(Level.ToString().Length == 1)
                {
                    return $"{Level}" + "     ";
                }
                else if(Level.ToString().Length == 2)
                {
                    return$"{Level}" + "    ";
                }
                else if (Level.ToString().Length == 3)
                {
                    return $"{Level}" + "   ";
                }
                else
                {
                    return $"999" + "   ";
                }
            }

            return "1";
        }


    }
}
