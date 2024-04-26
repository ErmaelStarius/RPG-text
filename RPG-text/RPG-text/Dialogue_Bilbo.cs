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

                case ConsoleKey.C:
                    Bilbo_text = "\"뭐, 좋아! 대답하기 어렵다면 내 이해해 주지! 자네 이름이 무엇인가?\"";
                    break;
            }
        }

        public void dialogue_002_Q(ConsoleKeyInfo dialogueKey)
        {
            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    Bilbo_text = "\"특이한 이름이군? 뭐, 좋아. 여기는 가운데 땅의 호빗들이 사는 마을이라네.\"";
                    break;

                case ConsoleKey.X:
                    Bilbo_text = "\"차갑게 구는군? 아무튼 반갑네. 여기는 호빗골, 호빗들이 사는 마을이지.\"";
                    break;

                case ConsoleKey.C:
                    Bilbo_text = "\"오! 정말 좋은 질문이야. 여기는 호빗골이라네. 나의 오랜 고향이기도 하지.\"";
                    break;
            }
        }

        public void dialogue_003_Q(ConsoleKeyInfo dialogueKey)
        {
            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    Bilbo_text = "\"반지 원정대? 당연히 알고있지!\"";
                    break;

                case ConsoleKey.X:
                    Bilbo_text = "\"반지 원정대라면 사우론의 절대반지를 파괴하기위하려는 원정대가 아닌가?\"";
                    break;

                case ConsoleKey.C:
                    Bilbo_text = "\n반지원정대를 말하는 게로군? 좋아 내가 알려주도록 하지!!\"";
                    break;
            }
        }

        public void dialogue_004_Q(ConsoleKeyInfo dialogueKey)
        {
            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    Bilbo_text = "\"호빗골 너머의 검은 숲을 지나면 반지원정대를 모집하는 사람들이 있을걸세!\"";
                    break;

                case ConsoleKey.X:
                    Bilbo_text = "\"호빗골 너머의 검은 숲을 지나면 반지원정대를 모집하는 사람들이 있을걸세!\"";
                    break;

                case ConsoleKey.C:
                    Bilbo_text = "\n호빗골 너머의 검은 숲을 지나면 반지원정대를 모집하는 사람들이 있을걸세!\"";
                    break;
            }
        }


        public void dialogue_005_Q(ConsoleKeyInfo dialogueKey)
        {
            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    Bilbo_text = "\"그 전에 마을의 상점에서 준비를 해두는 것이 좋을거야!\"";
                    break;

                case ConsoleKey.X:
                    Bilbo_text = "\"준비가 필요하다면 마을의 상점에 들러보도록 하게!\"";
                    break;

                case ConsoleKey.C:
                    Bilbo_text = "\"마을의 상점은 저기 오른쪽 골목으로 들어가면 있을걸세!\"";
                    break;
            }
        }


    }
}
