
namespace Jalgpall 
{
    class Program 
    {
        public static void Main() 
        {
            Console.Clear();

            Console.SetWindowSize(95, 25);
            Stadium s = new Stadium(80, 25);
            Stadium.Draw();
            // Poka ne rabotaet


            //Sozdanie i zapolnenie komand//

            Team t1 = new Team("Esimene team");

            Player p1 = new Player("Mängija1");
            t1.AddPlayer(p1);
            Player p2 = new Player("Mängija2");
            t1.AddPlayer(p2);
            Player p3 = new Player("Mängija3");
            t1.AddPlayer(p3);

            Team t2 = new Team("Teine team");

            Player p4 = new Player("Mängija4");
            t2.AddPlayer(p4);
            Player p5 = new Player("Mängija5");
            t2.AddPlayer(p5);
            Player p6 = new Player("Mängija6");
            t2.AddPlayer(p6);
            //--------------------------------//

            //Start igri//

            Game g = new Game(t1, t2, s);
            g.Start();
            //--------------------------//
        }   
    }
}
