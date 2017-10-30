using System;
using System.Collections.Generic;

public class Game
{


    #region Miembros
    private string name;

    public string Name
    {
        get { return name; }
    }

    private Genres genre;

    public Genres Genre
    {
        get { return genre; }
    }

    private List<Platforms> platforms;

    public Platforms Platforms
    {
        get { return Platforms; }
    }

    private int releaseDate;

    public int ReleaseDate
    {
        get { return releaseDate; }
    }
    #endregion



    //Rankings Diccionario

    private Dictionary<Platforms,Ranking> platrank;

    public Dictionary<Platforms,Ranking> Platrank
    {
        get { return platrank; }
    }

    //Dictionary<Platforms, Ranking> platrank = new Dictionary<Platforms, Ranking>();

    #region Constructores
    public Game(int releaseDate,string name, Genres genre, List<Platforms> platforms, Dictionary<Platforms,Ranking>platrank)
    {
        this.name = name;
        this.genre = genre;
        this.platforms = platforms;
        this.releaseDate = releaseDate;
        this.platrank = platrank;
        
    }
    #endregion


    #region Equals
    //Si Name es igual al Name
    public override bool Equals(object obj)
    {
        if (obj is Game)
        {
            Game aux = (Game)obj;
            return this.Name == aux.Name;
        }
        else
        {
            return false;
        }
    }
    #endregion

    #region ToString

    public override string ToString()
    {

        #region prueba de enumerar en orden para "Ranking"
        //int cont = 0; 

        //foreach (Platforms platform in platforms)
        //{
        //    cont++;
        //    string orden = cont.ToString();
        //    s += string.Format("\n" + orden + ". {0}", platform);
        //}
        //s += string.Format(" - {0} ---", this.Genre);

        //return s;
        #endregion
        string s = string.Format("--- {0}({1}) - ", this.Name, this.ReleaseDate);

        //Contador para no poner coma a la primera plataforma
        int controldeseparador = 0;

        foreach (Platforms platform in platforms)
        {

            //No poner coma a la primera plataforma
            if (controldeseparador == 0)
            {
                s += string.Format("{0}", platform);
                controldeseparador++;
            }
            else {
                s += string.Format(",{0}", platform);
            }
            
        }
        s += string.Format(" - {0} ---\n", this.Genre);

        return s;
    }

    #endregion

}
