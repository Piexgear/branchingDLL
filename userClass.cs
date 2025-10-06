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

    public static User Attacking(User Player1, User Player2, User weapon)
    {
        int Damage = weapon.MainHand.DMG;
        Player2.HP -= Damage;
        return Player2;
    }
}
