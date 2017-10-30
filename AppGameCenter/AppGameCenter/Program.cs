using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {

        //Test.DoTest();

        #region Player
        Player p0 = new Player("Kra", "Kra@gc.es", Countries.SPA);
        Player p1 = new Player("Ark", "Ark@gc.es", Countries.SPA);
        Player p2 = new Player("Zar", "Zar@gc.es", Countries.ITA);
        Player p3 = new Player("Raz", "Raz@gc.es", Countries.FRA);
        Player p4 = new Player("Zed", "Zed@gc.es", Countries.UK);
        Player p5 = new Player("Dez", "Dez@gc.es", Countries.JAP);
        Player p6 = new Player("Lix", "Lix@gc.es", Countries.USA);
        Player p7 = new Player("Xil", "Xil@gc.es", Countries.CAN);
        Player p8 = new Player("Gun", "Gun@gc.es", Countries.AUS);
        Player p9 = new Player("Nug", "Nug@gc.es", Countries.GER);
        #endregion

        //Console.WriteLine(p0+"\n");

        #region Scores
        Score s0 = new Score(p0.Nickname, 999);
        Score s1 = new Score(p1.Nickname, 999);
        Score s2 = new Score(p2.Nickname, 999);
        Score s3 = new Score(p3.Nickname, 999);
        Score s4 = new Score(p4.Nickname, 999);
        Score s5 = new Score(p5.Nickname, 999);
        Score s6 = new Score(p6.Nickname, 777);
        Score s7 = new Score(p7.Nickname, 777);
        Score s8 = new Score(p8.Nickname, 777);
        Score s9 = new Score(p9.Nickname, 777);
        Score s10 = new Score(p0.Nickname, 777);
        Score s11 = new Score(p6.Nickname, 888);
        Score s12 = new Score(p7.Nickname, 888);
        Score s13 = new Score(p8.Nickname, 888);
        Score s14 = new Score(p9.Nickname, 888);
        Score s15 = new Score(p0.Nickname, 888);


        List<Score> kills = new List<Score>();
        kills.Add(s0);
        kills.Add(s1);
        kills.Add(s2);
        kills.Add(s3);
        kills.Add(s4);
        kills.Add(s5);

        List<Score> deaths = new List<Score>();
        deaths.Add(s6);
        deaths.Add(s7);
        deaths.Add(s8);
        deaths.Add(s9);
        deaths.Add(s10);


        List<Score> jumps = new List<Score>();
        jumps.Add(s6);
        jumps.Add(s7);
        jumps.Add(s8);
        jumps.Add(s9);
        jumps.Add(s10);

        //foreach (Score puntos in deaths.Scores) {

        //}
        //return muertes;

        #endregion

        //deaths.ForEach(i =>Console.Write("{0}\n", i));

        #region Ranking
        Ranking r1 = new Ranking("Kills", scores: kills);
        Ranking r2 = new Ranking("Deaths", scores: deaths);
        Ranking r3 = new Ranking("Jumps", scores: jumps);
        #endregion

        //Console.WriteLine(r1);
        //Console.WriteLine(r2);

        #region platforms
        List<Platforms> platforms = new List<Platforms>();
        platforms.Add(Platforms.PC);
        platforms.Add(Platforms.PS4);
        platforms.Add(Platforms.XBOXONE);
        #endregion

        #region diccionario


        Dictionary<Platforms, Ranking> platrank1 = new Dictionary<Platforms, Ranking>();
        platrank1.Add(Platforms.PC, r1);
        platrank1.Add(Platforms.PS4, r2);
        platrank1.Add(Platforms.XBOXONE, r3);
        //Console.WriteLine(r1);

        #endregion


        #region Game
        Game g1 = new Game(2006, "Grand Theft Auto", Genres.sandbox, platforms, platrank: platrank1);
        Game g2 = new Game(2010, "Final Fantasy", Genres.rpg, platforms, platrank: platrank1);
        Game g3 = new Game(2010, "Call Of Duty", Genres.action, platforms, platrank: platrank1);
        Game g4 = new Game(2010, "The Witcher", Genres.rpg, platforms, platrank: platrank1);

        #endregion


        List<Game> games = new List<Game>();
        games.Add(g1);
        games.Add(g2);



        //Console.WriteLine(g1);

        GameServices.Games.Add(g1);
        GameServices.Games.Add(g2);
        GameServices.Games.Add(g3);
        GameServices.Games.Add(g4);

        //Console.WriteLine(GameServices.OldestGame());
        //Console.WriteLine(GameServices.GetGameByName("Call Of Duty"));
        //Console.WriteLine("Hay "+GameServices.GetCountGameByGenre("RPG")+" juegos de este género");
        //Console.WriteLine("Hay juegos que contienen 'Call' en el nombre." + GameServices.GameNameContains());


        while (true)
        {
            Console.Write("Introduce un comando: ");
            string frase = Console.ReadLine();

            // Pasar a minusculas la frase
            frase = frase.ToLower();

            // Trocear para averiguar el comando y el valor
            string[] splitted = frase.Split(' ');
            string comando = splitted[0];
            string valor = "";
            string valor2 = "";
            if (splitted.Length > 1)
            {
                valor = splitted[1];
            }
            if (splitted.Length > 2)
            {
                valor2 = splitted[2];
            }
            // Averiguar con un switch el comando introducido
            switch (comando)
            {
                case "import":
                    Console.WriteLine("Importar");
                    //GameServices.Importar();
                    break;
                case "export":
                    Console.WriteLine("Importar");
                    //GameServices.Importar();
                    break;
                case "oldest":
                    Console.WriteLine(GameServices.OldestGame());
                    break;
                case "scorecount":
                    Console.WriteLine("scoreCount");
                    break;
                case "gamescountbygenre":

                    Console.WriteLine("Hay " + GameServices.GetCountGameByGenre(valor) + " juegos de este género");
                    break;
                case "gamesbyplayer":
                    Console.WriteLine("gamesByPlayer");
                    break;
                default:
                    break;


            }
        }




        System.Threading.Thread.Sleep(999999);
    }
}
