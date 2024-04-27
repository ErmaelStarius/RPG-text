using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_text;

namespace RPG_text
{
    public class IntroScene
    {
        Images images = new Images();
        LoadingScene loadingScene = new LoadingScene();

        public void IntroMethod()
        {
            // 시작이미지
            images.IntroImage();


            // 입력값
            ConsoleKeyInfo startkey = Console.ReadKey(true);

            do
            {
                // 조건
                if (startkey.Key == ConsoleKey.Z)
                {

                    loadingScene.Loading();
                    break;

                }
                else if (startkey.Key == ConsoleKey.X)
                {
                    Console.Clear();
                    images.GameEnd();
                    break;
                }
                else
                {
                    Console.Clear();
                    images.IntroError();

                    ConsoleKeyInfo restartkey = Console.ReadKey(true);

                    if (restartkey.Key == ConsoleKey.Z)
                    {
                        Console.Clear();
                        IntroMethod();

                        startkey = Console.ReadKey(true);
                    }
                }
            } while (true);

        }
    }
}
