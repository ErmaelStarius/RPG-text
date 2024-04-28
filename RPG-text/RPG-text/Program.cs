namespace RPG_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            MyStatus myStatus = new MyStatus();

            IntroScene introScene = new IntroScene();
            MainScene mainScene = new MainScene();
            

            // 게임 인트로
            introScene.IntroMethod();

            
            // 대화 매니저
            mainScene.Dialogue_Manager();




        }
    }
}
