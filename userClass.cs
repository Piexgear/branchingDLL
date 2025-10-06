namespace App;

class User
{
    public string Username;
    public int HP; //health point
    public Weapon MainHand;


    public User(string Username, int hp, Weapon mainhand)
    {
        Username = Username;
        HP = hp;
        MainHand = mainhand;
    }

}



