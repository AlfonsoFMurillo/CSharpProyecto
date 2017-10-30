using System.Collections.Generic;

public class Ranking
{

    #region Miembros
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private List<Score> scores;

    public List<Score> Scores
    {
        get { return scores; }
        set { scores = value; }
    }
    #endregion

    #region Constructores

    public Ranking(string name, List<Score> scores)
    {
        this.name = name;
        this.scores = scores;
    }

    #endregion

    #region ToString

    public override string ToString()
    {

        //Orden de lista numerada
        int rankN = 0;
        string s = string.Format("Ranking: {0}\n", this.Name);

        foreach (Score scores in scores)
        {
            rankN++;
            string ordenrank = rankN.ToString();

            s += string.Format("\t" + ordenrank + ". " + "{0}\n", scores);
        }
        return s;

    }

    #endregion


}
