using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_text
{
    public class MainScene
    {

        public void Dialogue_Manager()
        {
            MainMenu mainMenu = new MainMenu();
            LoadingScene loadingScene = new LoadingScene();
            Dialogue dialogue = new Dialogue();
            

            // 빌보와의 대화
            dialogue.Chapter_001();

            // 로딩화면
            loadingScene.Loading();


            // 소모품점, 무기고, 검은 숲
            mainMenu.MainScene_Hobit();


            // 내 스테이터스
            mainMenu.StatusMenu();

            Console.ReadKey();
        }
    }
}
