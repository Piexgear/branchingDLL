namespace App;

class User
{
    public string Username;
    public int HP; //health point
    public Weapon MainHand;


    public User(string Username, int hp, Weapon mainhand)
    {
        Username = username;
        HP = hp;
        MainHand = mainhand;
    }

    public void show(Weapon mainhad)
    {
        Console.WriteLine("Weapon: " + mainhad);
    }
}
