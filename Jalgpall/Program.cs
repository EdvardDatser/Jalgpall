
namespace Jalgpall 
{
    class Program 
    {
        static void Main() 
        {

            //Player play = new Player("d");

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

            Stadium s = new Stadium(82, 27);

            //t2 = Game.AwayTeam(t1, t2, s);

            Game g = new Game(t1, t2, s);

            //Ball b = new Ball(X, Y, g);

            g.Start();
            while (true) 
            {
                Console.SetCursorPosition(82,27);
                //g.DrawB();
                s.Draw();
                p1.DrawP();
                p2.DrawP();
                p3.DrawP();
                p4.DrawP();
                p5.DrawP();
                p6.DrawP();
                //g.Move();
                //play.Move();
            }
        }
    }
}
