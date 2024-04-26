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
        public string player_text_03 = "\"... \"";

        public void dialogue_001_A(ConsoleKeyInfo dialogueKey)
        {
            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    {
                        player_text_01 = "\" 내 이름은 프로도. 만나서 반가워!\"";
                        player_text_02 = "\" 귀찮게 구는군... \"";
                        player_text_03 = "\" 그보다 여긴 어디지?\"";
                    }
                    break;

                case ConsoleKey.X:
                    {
                        player_text_01 = "\" 프로도. 그게 내 이름이야.\"";
                        player_text_02 = "\" 시끄러워. \"";
                        player_text_03 = "\" 그보다 여긴 어디지?\"";
                    }
                    break;

                case ConsoleKey.C:
                        player_text_01 = "\" 만나서 반가워! 내 이름은 프로도 베긴스 라고 해.\"";
                        player_text_02 = "\" 딱히 말해주고 싶지 않은걸? \"";
                        player_text_03 = "\" 그보다 여긴 어디지?\"";
                    break;
            }
        }

        public void dialogue_002_A(ConsoleKeyInfo dialogueKey)
        {
            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    {
                        player_text_01 = "\" 호빗들의 마을이구나! 그런데 혹시 반지원정대를 들어본 적이 있니?\"";
                        player_text_02 = "\" 그보다 반지원정대에 대하여 알고 있나? \"";
                        player_text_03 = "\" 네 이름도 별 다를 바 없는데?\"";
                    }
                    break;

                case ConsoleKey.X:
                    {
                        player_text_01 = "\" 반지원정대에 참여하러 왔다.\"";
                        player_text_02 = "\" 무례하군. 반지원정대를 알고 있나?\"";
                        player_text_03 = "\" 촌구석이 따로 없군!\"";
                    }
                    break;

                case ConsoleKey.C:
                    player_text_01 = "\" 고향이라니! 정말이지 환상적인 곳이야!\"";
                    player_text_02 = "\" 호빗에 대하여서도 궁금하지만 지금은 반지원정대에 대하여 알아봐야 해.\"";
                    player_text_03 = "\" 좋아! 이 근처에서 반지원정대를 모집 한다던데?\"";
                    break;
            }
        }

        public void dialogue_003_A(ConsoleKeyInfo dialogueKey)
        {
            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    {
                        player_text_01 = "\" 반지 원정대에 대하여 알려주게\"";
                        player_text_02 = "\" 반지원정대를 찾아가려면 어떻게 해야하지?\"";
                        player_text_03 = "\" 반지원정대에 가입하고 싶어!\"";
                    }
                    break;

                case ConsoleKey.X:
                    {
                        player_text_01 = "\" 반지 원정대에 대하여 알려주게\"";
                        player_text_02 = "\" 반지원정대를 찾아가려면 어떻게 해야하지?\"";
                        player_text_03 = "\" 반지원정대에 가입하고 싶어!\"";
                    }
                    break;

                case ConsoleKey.C:
                    player_text_01 = "\" 반지 원정대에 대하여 알려주게\"";
                    player_text_02 = "\" 반지원정대를 찾아가려면 어떻게 해야하지?\"";
                    player_text_03 = "\" 반지원정대에 가입하고 싶어!\"";
                    break;
            }
        }


        public void dialogue_004_A(ConsoleKeyInfo dialogueKey)
        {
            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    {
                        player_text_01 = "\" 고맙군!\"";
                        player_text_02 = "\" 검은 숲이라.. 그전에 준비가 필요한 것같군!\"";
                        player_text_03 = "\" 이 근처에 상점이 있나?\"";
                    }
                    break;

                case ConsoleKey.X:
                    {
                        player_text_01 = "\" 고맙군!\"";
                        player_text_02 = "\" 검은 숲이라.. 그전에 준비가 필요한 것같군!\"";
                        player_text_03 = "\" 이 근처에 상점이 있나?\"";
                    }
                    break;

                case ConsoleKey.C:
                    player_text_01 = "\" 고맙군!\"";
                    player_text_02 = "\" 검은 숲이라.. 그전에 준비가 필요한 것같군!\"";
                    player_text_03 = "\" 이 근처에 상점이 있나?\"";
                    break;
            }
        }


        public void dialogue_005_A(ConsoleKeyInfo dialogueKey)
        {
            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    {
                        player_text_01 = "\" 알겠네.\"";
                        player_text_02 = "\" 그것 참 좋은 생각이군?\"";
                        player_text_03 = "\" 알려줘서 고맙네\"";
                    }
                    break;

                case ConsoleKey.X:
                    {
                        player_text_01 = "\" 알겠네.\"";
                        player_text_02 = "\" 그것 참 좋은 생각이군?\"";
                        player_text_03 = "\" 알려줘서 고맙네\"";
                    }
                    break;

                case ConsoleKey.C:
                    player_text_01 = "\" 알겠네.\"";
                    player_text_02 = "\" 그것 참 좋은 생각이군?\"";
                    player_text_03 = "\" 알려줘서 고맙네\"";
                    break;
            }
        }


        public void dialogue_006_A(ConsoleKeyInfo dialogueKey)
        {
            switch (dialogueKey.Key)
            {
                case ConsoleKey.Z:
                    {
                        player_text_01 = "\" 소모품 상점으로 간다.\"";
                        player_text_02 = "\" 무기고로 간다.\"";
                        player_text_03 = "\" 검은숲으로 간다.\"";
                    }
                    break;

                case ConsoleKey.X:
                    {
                        player_text_01 = "\" 소모품 상점으로 간다.\"";
                        player_text_02 = "\" 무기고로 간다.\"";
                        player_text_03 = "\" 검은숲으로 간다.\"";
                    }
                    break;

                case ConsoleKey.C:
                    player_text_01 = "\" 소모품 상점으로 간다.\"";
                    player_text_02 = "\" 무기고로 간다.\"";
                    player_text_03 = "\" 검은숲으로 간다.\"";
                    break;
            }
        }
    }
}
