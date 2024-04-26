using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_text
{
    internal class Dialogue
    {


        public void Chapter_001()
        {
            Images Images = new Images();
            
            Dialogue_Player _Player = new Dialogue_Player();
            Dialogue_Bilbo  _Bilbo = new Dialogue_Bilbo();
            
            
            ConsoleKeyInfo dialogue_001 = Images.MainImage(_Bilbo.Name, _Bilbo.Bilbo_text, _Player.player_text_01, _Player.player_text_02, _Player.player_text_03);

            _Bilbo.dialogue_001_Q(dialogue_001);
            _Player.dialogue_001_A(dialogue_001);
            
            ConsoleKeyInfo dialogue_002 = Images.MainImage(_Bilbo.Name, _Bilbo.Bilbo_text, _Player.player_text_01, _Player.player_text_02, _Player.player_text_03);

            _Bilbo.dialogue_002_Q(dialogue_002);
            _Player.dialogue_002_A(dialogue_002);

            ConsoleKeyInfo dialogue_003 = Images.MainImage(_Bilbo.Name, _Bilbo.Bilbo_text, _Player.player_text_01, _Player.player_text_02, _Player.player_text_03);

            _Bilbo.dialogue_003_Q(dialogue_003);
            _Player.dialogue_003_A(dialogue_003);            
            
            ConsoleKeyInfo dialogue_004 = Images.MainImage(_Bilbo.Name, _Bilbo.Bilbo_text, _Player.player_text_01, _Player.player_text_02, _Player.player_text_03);

            _Bilbo.dialogue_004_Q(dialogue_004);
            _Player.dialogue_004_A(dialogue_004);            
            
            ConsoleKeyInfo dialogue_005 = Images.MainImage(_Bilbo.Name, _Bilbo.Bilbo_text, _Player.player_text_01, _Player.player_text_02, _Player.player_text_03);

            _Bilbo.dialogue_005_Q(dialogue_005);
            _Player.dialogue_005_A(dialogue_005);

            ConsoleKeyInfo dialogue_006 = Images.MainImage(_Bilbo.Name, _Bilbo.Bilbo_text, _Player.player_text_01, _Player.player_text_02, _Player.player_text_03);
            
            _Player.dialogue_006_A(dialogue_006);
        }


        public void MainScene_Hobit()
        {
            Images Images = new Images();

            Dialogue_Player _Player = new Dialogue_Player();
            Dialogue_MainMenu _MainMenu = new Dialogue_MainMenu();

            
            Console.Clear();
            Images.GameLoading();

            ConsoleKeyInfo dialogue_007 = Images.MainImage(_MainMenu.Name, _MainMenu.MainMenu_text, _Player.player_text_01, _Player.player_text_02, _Player.player_text_03);
        }
    }
}
