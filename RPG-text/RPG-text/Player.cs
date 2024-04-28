using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_text
{

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
        public PlayerJob _Job;
        public int _Money;

        public int _Hp;
        public int _Mp;
        public float _Exp;

        public int _MaxHp;
        public int _MaxMp;
        public int _MaxExp;

        public int _AttackDamage;
        public int _DeffenceDamage;

        public int _MagicAttackDamage;
        public int _MagicDeffenceDamage;

        public float _EvasionRate;
        public float _CriticalRate;
        public float _DetectItemRate;

        public string Current_Hp;
        public string Current_Mp;
        public string Current_Exp;

        public string Current_Level;
        public string Current_Job;
        public string Current_Money;

        public string Current_AttackDamage;
        public string Current_DeffenceDamage;

        public string Current_MagicAttackDamage;
        public string Current_MagicDeffenceDamage;

        public string Current_EvasionRate;
        public string Current_CriticalRate;
        public string Current_DetectItemRate;

        public Player()
        {
            _Level = 1;
            _Job = PlayerJob.Newbie;
            _Money = 1000;

            _Hp = 150;
            _Mp = 100;
            _Exp = 0;

            _MaxHp = 150;
            _MaxMp = 100;
            _MaxExp = 100;

            _AttackDamage = 90;
            _DeffenceDamage = 75;

            _MagicAttackDamage = 85;
            _MagicDeffenceDamage = 60;

            _EvasionRate = 5;
            _CriticalRate = 5;
            _DetectItemRate = 5;

            
            Current_Hp = $"{_Hp}/{_MaxHp}";
            Current_Mp = $"{_Mp}/{_MaxMp}";
            Current_Exp = $"{_Exp}/{_MaxExp}";

            Current_Job = "초보자";
            Current_Level = $"{_Level}";
            Current_Money = $"{_Money}";

            Current_AttackDamage = $"{_AttackDamage}";
            Current_DeffenceDamage = $"{_DeffenceDamage}";

            Current_MagicAttackDamage = $"{_MagicAttackDamage}";
            Current_MagicDeffenceDamage = $"{_MagicDeffenceDamage}";

            Current_EvasionRate = $"{_EvasionRate}";
            Current_CriticalRate = $"{_CriticalRate}";
            Current_DetectItemRate = $"{_DetectItemRate}";

        }



        public string ShowMyHp(int _hp, int max_hp)
        {

            Current_Hp = $"{_hp}/{max_hp}";

            int _Space = 12 - Current_Hp.Length;

            switch (_Space)
            {
                case 0:
                    Current_Hp = $"{_hp}/{max_hp}" + "";
                    break;
                case 1:
                    Current_Hp = $"{_hp}/{max_hp}" + " ";
                    break; 
                case 2:
                    Current_Hp = $"{_hp}/{max_hp}" + "  ";
                    break;
                case 3:
                    Current_Hp = $"{_hp}/{max_hp}" + "   ";
                    break;
                case 4:
                    Current_Hp = $"{_hp}/{max_hp}" + "    ";
                    break;
                case 5:
                    Current_Hp = $"{_hp}/{max_hp}" + "     ";
                    break;
                case 6:
                    Current_Hp = $"{_hp}/{max_hp}" + "      ";
                    break;
                case 7:
                    Current_Hp = $"{_hp}/{max_hp}" + "       ";
                    break;
                case 8:
                    Current_Hp = $"{_hp}/{max_hp}" + "        ";
                    break;

            }
            return Current_Hp;
        }



        public string ShowMyMp(int _mp, int max_mp)
        {

            Current_Mp = $"{_mp}/{max_mp}";

            int _Space = 12 - Current_Mp.Length;

            switch (_Space)
            {
                case 0:
                    Current_Mp = $"{_mp}/{max_mp}" + "";
                    break;
                case 1:
                    Current_Mp = $"{_mp}/{max_mp}" + " ";
                    break;
                case 2:
                    Current_Mp = $"{_mp}/{max_mp}" + "  ";
                    break;
                case 3:
                    Current_Mp = $"{_mp}/{max_mp}" + "   ";
                    break;
                case 4:
                    Current_Mp = $"{_mp}/{max_mp}" + "    ";
                    break;
                case 5:
                    Current_Mp = $"{_mp}/{max_mp}" + "     ";
                    break;
                case 6:
                    Current_Mp = $"{_mp}/{max_mp}" + "      ";
                    break;
                case 7:
                    Current_Mp = $"{_mp}/{max_mp}" + "       ";
                    break;
                case 8:
                    Current_Mp = $"{_mp}/{max_mp}" + "        ";
                    break;
            }

            return Current_Mp;
        }



        public string ShowMyEXP(float _exp, int max_exp)
        {
            Current_Exp = $"{_exp}/{max_exp}";

            int _Space = 12 - Current_Exp.Length;

            switch (_Space)
            {
                case 0:
                    Current_Exp = $"{_exp}/{max_exp}" + "";
                    break;
                case 1:
                    Current_Exp = $"{_exp}/{max_exp}" + " ";
                    break;
                case 2:
                    Current_Exp = $"{_exp}/{max_exp}" + "  ";
                    break;
                case 3:
                    Current_Exp = $"{_exp}/{max_exp}" + "   ";
                    break;
                case 4:
                    Current_Exp = $"{_exp}/{max_exp}" + "    ";
                    break;
                case 5:
                    Current_Exp = $"{_exp}/{max_exp}" + "     ";
                    break;
                case 6:
                    Current_Exp = $"{_exp}/{max_exp}" + "      ";
                    break;
                case 7:
                    Current_Exp = $"{_exp}/{max_exp}" + "       ";
                    break;
                case 8:
                    Current_Exp = $"{_exp}/{max_exp}" + "        ";
                    break;
            }
            return Current_Exp;
        }
    


        public string ShowMyJob(PlayerJob job)
        {
            switch (job)
            {
                case PlayerJob.Swordman:
                    Current_Job = $"검사" + "      ";
                    break;
                case PlayerJob.Archer:
                    Current_Job = $"궁수" + "      ";
                    break;
                case PlayerJob.Magician:
                    Current_Job = $"마법사" + "    ";
                    break;
                case PlayerJob.Newbie:
                    Current_Job = $"초보자" + "    ";
                    break;
            }
            return Current_Job;
        }



        public string ShowMyLevel(int _level)
        {
            Current_Level = $"{_level}";

            int _Space = 11 - Current_Level.Length;

            switch (_Space)
            {
                case 0:
                    Current_Level = $"{_level}" + "";
                    break;
                case 1:
                    Current_Level = $"{_level}" + " ";
                    break;
                case 2:
                    Current_Level = $"{_level}" + "  ";
                    break;
                case 3:
                    Current_Level = $"{_level}" + "   ";
                    break;
                case 4:
                    Current_Level = $"{_level}" + "    ";
                    break;
                case 5:
                    Current_Level = $"{_level}" + "     ";
                    break;
                case 6:
                    Current_Level = $"{_level}" + "      ";
                    break;
                case 7:
                    Current_Level = $"{_level}" + "       ";
                    break;
                case 8:
                    Current_Level = $"{_level}" + "        ";
                    break;
                case 9:
                    Current_Level = $"{_level}" + "         ";
                    break;
                case 10:
                    Current_Level = $"{_level}" + "          ";
                    break;
                case 11:
                    Current_Level = $"{_level}" + "           ";
                    break;

            }
            return Current_Level;
        }



        public string ShowMyMoney(int _money)
        {
            Current_Money = $"{_money}";

            int _Space = 10 - Current_Money.Length;

            switch (_Space)
            {
                case 0:
                    Current_Money = $"{_money}" + "";
                    break;
                case 1:
                    Current_Money = $"{_money}" + " ";
                    break;
                case 2:
                    Current_Money = $"{_money}" + "  ";
                    break;
                case 3:
                    Current_Money = $"{_money}" + "   ";
                    break;
                case 4:
                    Current_Money = $"{_money}" + "    ";
                    break;
                case 5:
                    Current_Money = $"{_money}" + "     ";
                    break;
                case 6:
                    Current_Money = $"{_money}" + "      ";
                    break;
                case 7:
                    Current_Money = $"{_money}" + "       ";
                    break;
                case 8:
                    Current_Money = $"{_money}" + "        ";
                    break;
                case 9:
                    Current_Money = $"{_money}" + "         ";
                    break;
            }
            return Current_Money;
        }



        public string ShowMyAttackDamage(int _attackDamage)
        {
            Current_AttackDamage = $"{_attackDamage}";

            int _Space = 9 - Current_AttackDamage.Length;

            switch (_Space)
            {
                case 0:
                    Current_AttackDamage = $"{_attackDamage}" + "";
                    break;
                case 1:
                    Current_AttackDamage = $"{_attackDamage}" + " ";
                    break;
                case 2:
                    Current_AttackDamage = $"{_attackDamage}" + "  ";
                    break;
                case 3:
                    Current_AttackDamage = $"{_attackDamage}" + "   ";
                    break;
                case 4:
                    Current_AttackDamage = $"{_attackDamage}" + "    ";
                    break;
                case 5:
                    Current_AttackDamage = $"{_attackDamage}" + "     ";
                    break;
                case 6:
                    Current_AttackDamage = $"{_attackDamage}" + "      ";
                    break;
                case 7:
                    Current_AttackDamage = $"{_attackDamage}" + "       ";
                    break;
                case 8:
                    Current_AttackDamage = $"{_attackDamage}" + "        ";
                    break;
                case 9:
                    Current_AttackDamage = $"{_attackDamage}" + "         ";
                    break;
            }
            return Current_AttackDamage;
        }



        public string ShowMyDeffenceDamage(int _deffenceDamage)
        {
            Current_DeffenceDamage = $"{_deffenceDamage}";

            int _Space = 9 - Current_DeffenceDamage.Length;

            switch (_Space)
            {
                case 0:
                    Current_DeffenceDamage = $"{_deffenceDamage}" + "";
                    break;
                case 1:
                    Current_DeffenceDamage = $"{_deffenceDamage}" + " ";
                    break;
                case 2:
                    Current_DeffenceDamage = $"{_deffenceDamage}" + "  ";
                    break;
                case 3:
                    Current_DeffenceDamage = $"{_deffenceDamage}" + "   ";
                    break;
                case 4:
                    Current_DeffenceDamage = $"{_deffenceDamage}" + "    ";
                    break;
                case 5:
                    Current_DeffenceDamage = $"{_deffenceDamage}" + "     ";
                    break;
                case 6:
                    Current_DeffenceDamage = $"{_deffenceDamage}" + "      ";
                    break;
                case 7:
                    Current_DeffenceDamage = $"{_deffenceDamage}" + "       ";
                    break;
                case 8:
                    Current_DeffenceDamage = $"{_deffenceDamage}" + "        ";
                    break;
                case 9:
                    Current_DeffenceDamage = $"{_deffenceDamage}" + "         ";
                    break;
            }
            return Current_DeffenceDamage;
        }



        public string ShowMyEvasionRate(float _evasionRate)
        {
            Current_EvasionRate = $"{_evasionRate}";

            int _Space = 9 - Current_EvasionRate.Length;

            switch (_Space)
            {
                case 0:
                    Current_EvasionRate = $"{_evasionRate}" + "";
                    break;
                case 1:
                    Current_EvasionRate = $"{_evasionRate}" + " ";
                    break;
                case 2:
                    Current_EvasionRate = $"{_evasionRate}" + "  ";
                    break;
                case 3:
                    Current_EvasionRate = $"{_evasionRate}" + "   ";
                    break;
                case 4:
                    Current_EvasionRate = $"{_evasionRate}" + "    ";
                    break;
                case 5:
                    Current_EvasionRate = $"{_evasionRate}" + "     ";
                    break;
                case 6:
                    Current_EvasionRate = $"{_evasionRate}" + "      ";
                    break;
                case 7:
                    Current_EvasionRate = $"{_evasionRate}" + "       ";
                    break;
                case 8:
                    Current_EvasionRate = $"{_evasionRate}" + "        ";
                    break;
                case 9:
                    Current_EvasionRate = $"{_evasionRate}" + "         ";
                    break;
            }
            return Current_EvasionRate;
        }



        public string ShowMyCriticalRate(float _criticalRate)
        {
            Current_CriticalRate = $"{_criticalRate}";

            int _Space = 9 - Current_CriticalRate.Length;

            switch (_Space)
            {
                case 0:
                    Current_CriticalRate = $"{_criticalRate}" + "";
                    break;
                case 1:
                    Current_CriticalRate = $"{_criticalRate}" + " ";
                    break;
                case 2:
                    Current_CriticalRate = $"{_criticalRate}" + "  ";
                    break;
                case 3:
                    Current_CriticalRate = $"{_criticalRate}" + "   ";
                    break;
                case 4:
                    Current_CriticalRate = $"{_criticalRate}" + "    ";
                    break;
                case 5:
                    Current_CriticalRate = $"{_criticalRate}" + "     ";
                    break;
                case 6:
                    Current_CriticalRate = $"{_criticalRate}" + "      ";
                    break;
                case 7:
                    Current_CriticalRate = $"{_criticalRate}" + "       ";
                    break;
                case 8:
                    Current_CriticalRate = $"{_criticalRate}" + "        ";
                    break;
                case 9:
                    Current_CriticalRate = $"{_criticalRate}" + "         ";
                    break;
            }
            return Current_CriticalRate;
        }



        public string ShowMyDetectItemRate(float _detectItemRate)
        {
            Current_DetectItemRate = $"{_detectItemRate}";

            int _Space = 9 - Current_DetectItemRate.Length;

            switch (_Space)
            {
                case 0:
                    Current_DetectItemRate = $"{_detectItemRate}" + "";
                    break;
                case 1:
                    Current_DetectItemRate = $"{_detectItemRate}" + " ";
                    break;
                case 2:
                    Current_DetectItemRate = $"{_detectItemRate}" + "  ";
                    break;
                case 3:
                    Current_DetectItemRate = $"{_detectItemRate}" + "   ";
                    break;
                case 4:
                    Current_DetectItemRate = $"{_detectItemRate}" + "    ";
                    break;
                case 5:
                    Current_DetectItemRate = $"{_detectItemRate}" + "     ";
                    break;
                case 6:
                    Current_DetectItemRate = $"{_detectItemRate}" + "      ";
                    break;
                case 7:
                    Current_DetectItemRate = $"{_detectItemRate}" + "       ";
                    break;
                case 8:
                    Current_DetectItemRate = $"{_detectItemRate}" + "        ";
                    break;
                case 9:
                    Current_DetectItemRate = $"{_detectItemRate}" + "         ";
                    break;
            }
            return Current_DetectItemRate;
        }



    }
}
