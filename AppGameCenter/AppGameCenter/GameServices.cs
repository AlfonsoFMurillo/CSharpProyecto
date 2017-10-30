using System;
using System.Collections.Generic;

public static class GameServices
    {

    private static List<Player> players=new List<Player>();

    public static List<Player> Players
    {
        get { return players; }
    }

    private static List<Game> games=new List<Game>();
    

    public static List<Game> Games
    {
        get { return games; }
    }


    //Añadir Juego desde fuera de GS
    //public static void AddGame(Game g)
    //{
    //    Games.Add(g);
    //}

    public static void Exportar()
    { }

    public static void Importar()
    { }

    public static Game OldestGame()
    {
        Game oldestGame = null;
        int releaseDate = int.MaxValue;
        foreach (Game game in Games)
        {
            int rd = game.ReleaseDate;
            if (releaseDate > rd)
            {
                oldestGame = game;
                releaseDate = rd;
            }
        }
        return oldestGame;
    }

    public static bool GameNameContains(string name="Call")
    {
        bool res = false;
        foreach (Game game in Games)
        {
            if (game.Name.Contains(name))
            {
                res = true;
                break;
            }
        }
        return res;
    }


    public static int GetCountGameByGenre(string name)
    {
        int res = 0;
        Genres gname = (Genres)Enum.Parse(typeof(Genres), name);

        foreach (Game game in Games)
        {
            if (game.Genre == gname)
            {
                res++;
            }
        }
        return res;
    }

    //public static Game GetGameCountMoreScores(string name)
    //{
    //    Game res = null;
    //    foreach (Game game in Games)
    //    {
    //        foreach (Ranking rank in game.Platrank.Values )
    //        {
                
    //        }

    //    }
    //    return res;
    //}


    //public static Game GetGameByPlayer(string player)
    //{

    //}

    public static Game GetGameByName(string name)
    {
        Game res = null;
        foreach (Game game in Games)
        {
            if (game.Name == name)
            {
                res = game;
                break;
            }
        }
        return res;
    }

}
