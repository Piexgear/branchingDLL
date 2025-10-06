using App;

List<User> users = new List<User>();
List<Weapon> inventory = new List<Weapon>();


inventory.Add(new Weapon("Hamer", 10));
users.Add(new User("David", 100, inventory[0]));

inventory.Add(new Weapon("lasso", 15));
users.Add(new User("Lina", 100, inventory[1]));



foreach (User user in users)
{
    foreach (Weapon weapon in inventory)
    {
        user.show(weapon);
        break;
    }
}

