using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_text
{
    internal class MainMenu
    {

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
            }
        }


        public void MainScene_Hobit()
        {
            Images Images = new Images();
            MainMenu _MainMenu = new MainMenu();

            ConsoleKeyInfo MainMenuChoice = Images.MainImage(_MainMenu.Name, _MainMenu.MainMenu_text, _MainMenu._MainChoice_01, _MainMenu._MainChoice_02, _MainMenu._MainChoice_03);
        }

        public void StatusMenu()
        {
            Images images = new Images();

            images.MyStatus();
        }

    }
}
