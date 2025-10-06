namespace App;

class User
{
    public string Username;
    public int HP; //health point
    public Weapon MainHand;


    public User(string username, int hp, Weapon mainHand)
    {
        Username = username;
        HP = hp;
        MainHand = mainHand;
    }

    public void show(Weapon mainhand)
    {
        Console.WriteLine("Weapon: " + MainHand.Wname + " Damage: " + MainHand.DMG);
    }
}
