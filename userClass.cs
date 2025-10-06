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
<<<<<<< HEAD
        Console.WriteLine("---Weapon--- \n" + MainHand.Wname + "\n---Damage: " + MainHand.DMG + "---");
=======
        Console.WriteLine("Weapon: " + MainHand.Wname + " Damage: " + MainHand.DMG);
>>>>>>> b925fedee3e25246ae2a1ba77c5035f3af59d73b
    }
}
