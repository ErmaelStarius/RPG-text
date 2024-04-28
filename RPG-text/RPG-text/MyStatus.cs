using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_text
{
    public class MyStatus
    {
        public int StatusPoint;

        public int STR;
        public int CON;
        public int DEX;
        public int INT;
        public int WIS;
        public int LUK;

        public string Current_StatusPoint;

        public string Current_STR;
        public string Current_CON;
        public string Current_DEX;
        public string Current_INT;
        public string Current_WIS;
        public string Current_LUK;
        
        public MyStatus()
        {
            StatusPoint = 0;

            STR = 10;
            CON = 10;
            DEX = 10;
            INT = 10;
            WIS = 10;
            LUK = 10;

            Current_StatusPoint = $"{StatusPoint}";

            Current_STR = $"{STR}";
            Current_CON = $"{CON}";
            Current_DEX = $"{DEX}";
            Current_INT = $"{INT}";
            Current_WIS = $"{WIS}";
            Current_LUK = $"{LUK}";
        }

        public string ShowSTR (int _str)
        {
            Current_STR = $"{_str}";

            int _Space = 12 - Current_STR.Length;

            switch (_Space)
            {
                case 0:
                    Current_STR = $"{_str}" + "";
                    break;
                case 1:
                    Current_STR = $"{_str}" + " ";
                    break;
                case 2:
                    Current_STR = $"{_str}" + "  ";
                    break;
                case 3:
                    Current_STR = $"{_str}" + "   ";
                    break;
            }
            return Current_STR ;
        }



        public string ShowCON(int _con)
        {
            Current_CON = $"{_con}";

            int _Space = 12 - Current_CON.Length;

            switch (_Space)
            {
                case 0:
                    Current_CON = $"{_con}" + "";
                    break;
                case 1:
                    Current_CON = $"{_con}" + " ";
                    break;
                case 2:
                    Current_CON = $"{_con}" + "  ";
                    break;
                case 3:
                    Current_CON = $"{_con}" + "   ";
                    break;
            }
            return Current_CON;
        }



        public string ShowDEX(int _dex)
        {
            Current_DEX = $"{_dex}";

            int _Space = 12 - Current_DEX.Length;

            switch (_Space)
            {
                case 0:
                    Current_DEX = $"{_dex}" + "";
                    break;
                case 1:
                    Current_DEX = $"{_dex}" + " ";
                    break;
                case 2:
                    Current_DEX = $"{_dex}" + "  ";
                    break;
                case 3:
                    Current_DEX = $"{_dex}" + "   ";
                    break;
            }
            return Current_DEX;
        }



        public string ShowINT(int _int)
        {
            Current_INT = $"{_int}";

            int _Space = 12 - Current_INT.Length;

            switch (_Space)
            {
                case 0:
                    Current_INT = $"{_int}" + "";
                    break;
                case 1:
                    Current_INT = $"{_int}" + " ";
                    break;
                case 2:
                    Current_INT = $"{_int}" + "  ";
                    break;
                case 3:
                    Current_INT = $"{_int}" + "   ";
                    break;
            }
            return Current_INT;
        }



        public string ShowWIS(int _wis)
        {
            Current_WIS = $"{_wis}";

            int _Space = 12 - Current_WIS.Length;

            switch (_Space)
            {
                case 0:
                    Current_WIS = $"{_wis}" + "";
                    break;
                case 1:
                    Current_WIS = $"{_wis}" + " ";
                    break;
                case 2:
                    Current_WIS = $"{_wis}" + "  ";
                    break;
                case 3:
                    Current_WIS = $"{_wis}" + "   ";
                    break;
            }
            return Current_WIS;
        }



        public string ShowLUK(int _luk)
        {
            Current_LUK = $"{_luk}";

            int _Space = 12 - Current_LUK.Length;

            switch (_Space)
            {
                case 0:
                    Current_LUK = $"{_luk}" + "";
                    break;
                case 1:
                    Current_LUK = $"{_luk}" + " ";
                    break;
                case 2:
                    Current_LUK = $"{_luk}" + "  ";
                    break;
                case 3:
                    Current_LUK = $"{_luk}" + "   ";
                    break;
            }
            return Current_LUK;
        }



        public string ShowStatusPoint(int _statusPoint)
        {
            Current_StatusPoint = $"{_statusPoint}";

            int _Space = 12 - Current_StatusPoint.Length;

            switch (_Space)
            {
                case 0:
                    Current_StatusPoint = $"{_statusPoint}" + "";
                    break;
                case 1:
                    Current_StatusPoint = $"{_statusPoint}" + " ";
                    break;
                case 2:
                    Current_StatusPoint = $"{_statusPoint}" + "  ";
                    break;
                case 3:
                    Current_StatusPoint = $"{_statusPoint}" + "   ";
                    break;
            }
            return Current_StatusPoint;
        }
    }
}
