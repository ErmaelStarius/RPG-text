using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_text
{
    internal class Dialogue_MainMenu
    {

        Images images = new Images();

        public string Name = "메뉴";

        public string MainMenu_text = "\"메뉴를 선택하시오.\"";

        public string _MainChoice_01 = "\"소모품 상점으로 간다.\"";
        public string _MainChoice_02 = "\"무기고로 간다.\"";
        public string _MainChoice_03 = "\"검은숲으로 간다.\"";

        public void MenuChoice(ConsoleKeyInfo dialogueKey)
        {
            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    {
                        
                    }
                    break;

                case ConsoleKey.X:
                    {
                        
                    }
                    break;

                case ConsoleKey.C:
                    {

                    }
                    break;
                case ConsoleKey.A:
                    {
                        
                    }
                    break;
            }
        }

    }
}
