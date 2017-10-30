public class Player
{
    #region Miembros
    private string nickname;

    public string Nickname
    {
        get { return nickname; }
    }

    private string email;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    private Countries country;

    public Countries Country
    {
        get { return country; }
        set { country = value; }
    }
    #endregion

    #region Constructores

    public Player(string nickname, string email, Countries country)
    {
        this.nickname = nickname;
        this.email = email;
        this.country = country;
    }

    #endregion


    #region Equals
    //Si Nickname es igual al Nickname
    public override bool Equals(object obj)
    {
        if (obj is Player)
        {
            Player aux = (Player)obj;
            return this.Nickname == aux.Nickname;
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
        return string.Format("{0} - {1} - {2}", Nickname, Email, Country);
    }

    #endregion

}

