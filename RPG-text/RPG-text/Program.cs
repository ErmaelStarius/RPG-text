namespace RPG_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            IntroScene introScene = new IntroScene();
            MainScene mainScene = new MainScene();


            introScene.IntroMethod();

            mainScene.Dialogue_Manager();

        }
    }
}
