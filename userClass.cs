namespace App;

class User
{
    public string Username;
    public int HP; //health point
    public Weapon MainHand;


    public User(string username, int hp, Weapon mainhad)
    {
        Username = username;
        HP = hp;
        MainHand = mainhad;
    }

    public void show(Weapon mainhad)
    {
        Console.WriteLine("---Weapon--- \n" + MainHand.Wname + "\n---Damage: " + MainHand.DMG + "---");
    }
}
