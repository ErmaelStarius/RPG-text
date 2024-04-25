using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_text
{
    internal class Dialogue
    {

        Images Images = new Images();

        public void Chapter_001()
        {

            Dialogue_Player _Player = new Dialogue_Player();
            Dialogue_Bilbo  _Bilbo = new Dialogue_Bilbo();

            
            ConsoleKeyInfo dialogue_001 = Console.ReadKey(true);

            _Bilbo.dialogue_001_Q(dialogue_001);
            Console.Clear();
            Images.MainImage();
            
        }
    }
}
