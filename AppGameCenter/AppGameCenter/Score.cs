public class Score
{
    private string nickname;

    public string Nickname
    {
        get { return nickname; }
        set { nickname = value; }
    }

    private int points;

    public int Points
    {
        get { return points; }
    }



    #region Constructores

    public Score(string nickname, int points)
    {
        this.nickname = nickname;
        this.points = points;
    }

    #endregion



    #region ToString

    public override string ToString()
    {

        return string.Format("{0} - {1}", Nickname, Points);
    }

    #endregion

}
