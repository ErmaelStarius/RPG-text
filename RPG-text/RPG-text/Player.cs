using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_text
{

    public struct Player_Index
    {
        public static int _Level;
        public static string _Job;
        public static int _Money;

        public static int _Hp;
        public static int _Mp;
        public static int _Exp;

        public static int _MaxHp;
        public static int _MaxMp;
        public static int _MaxExp;

        public static int _AttackDamage_index;
        public static int _Deffence_index;
    }


    public enum PlayerJob
    {
        Swordman = 1,
        Archer = 2,
        Magician = 3,
        Newbie = 0,
    }


    public class Player
    {
        public int _Level;
        public string _Job;
        public int _Money;

        public int _Hp;
        public int _Mp;
        public int _Exp;

        public int _MaxHp;
        public int _MaxMp;
        public int _MaxExp;

        public int _AttackDamage_index;
        public int _Deffence_index;

        public Player()
        {
            _Level = 1;
            _Job = "초보자";
            _Money = 1000;

            _Hp = 150;
            _Mp = 100;
            _Exp = 0;

            _MaxHp = 150;
            _MaxMp = 100;
            _MaxExp = 100;

            _AttackDamage_index = 90;
            _Deffence_index = 75;
        }

        public void BaseStatus()
        {
            Player_Index._Level = 1;
            Player_Index._Job = "검사";
            Player_Index._Money = 1000;

            Player_Index._Hp = 150;
            Player_Index._Mp = 100;
            Player_Index._Exp = 0;

            Player_Index._MaxHp = 150;
            Player_Index._MaxMp = 100;
            Player_Index._MaxExp = 100;

            Player_Index._AttackDamage_index = 90;
            Player_Index._Deffence_index = 75;
        }



    }
}
