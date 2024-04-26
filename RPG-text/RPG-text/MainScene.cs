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

            Dialogue dialogue = new Dialogue();

            // 빌보와의 대화
            dialogue.Chapter_001();

            // 소모품점, 무기고, 검은 숲
            dialogue.MainScene_Hobit();



        }
    }
}
