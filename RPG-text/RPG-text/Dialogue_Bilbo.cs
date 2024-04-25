using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RPG_text
{
    public class Dialogue_Bilbo
    {

        public string Name = "골목쟁이 빌보";

        public string Bilbo_text = "\"하하 만나서 반갑군! 내 이름은 골목쟁이 빌보. 호빗골의 터줏대감이지!! \"";

        
        public void dialogue_001_Q(ConsoleKeyInfo dialogueKey)
        {

            

            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    Bilbo_text = "\"좋아! 그럼 자네의 이름은 무엇인가?\"";
                    break;

                case ConsoleKey.X:
                    Bilbo_text = "\"이런! 유감이군? 그럼 자네의 이름은 무엇인가?\"";
                    break;
            }
        }

    }
}
