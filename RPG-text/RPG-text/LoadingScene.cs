using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_text
{
    internal class LoadingScene
    {

        public void Loading()
        {
            Images images = new Images();


            Console.Clear();
            images.GameLoading();
            
            ConsoleKeyInfo anykey = Console.ReadKey();
            if(anykey != null)
            {
                Console.Clear();
            }

        }

    }
}
