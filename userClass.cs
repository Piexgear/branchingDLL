namespace App;

class User
{
    public string Username;
    public int HP; //health point
    public Weapon MainHand;


    public User(string username, int hp, Weapon mainhad)
    public User(string Username, int hp, Weapon mainhand)
    {
        Username = username;
        Username = username;
        HP = hp;
        MainHand = mainhad;
    }

    public void show(Weapon mainhad)
    {
        Console.WriteLine("Weapon: " + mainhad);
    }
}
