using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_text
{
    internal class Dialogue_Player
    {
        public string player_text_01 = "\"만나서 반갑다.\"";
        public string player_text_02 = "\"딱히 이야기하기 싫다.\"";
        public string player_text_03 = "\"...\"";

        public string dialogue_001_A(ConsoleKeyInfo dialogueKey)
        {
            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    {
                        //Bilbo_text = "\"좋아! 그럼 자네의 이름은 무엇인가?\"";
                    }
                    break;

                case ConsoleKey.X:
                    {
                        //Bilbo_text = "\"이런! 유감이군? 그럼 자네의 이름은 무엇인가?\"";
                    }
                    break;
            }

            return "0";
        }
    }
}
