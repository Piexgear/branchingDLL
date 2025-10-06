using App;

List<User> users = new List<User>();
List<Weapon> inventory = new List<Weapon>();


inventory.Add(new Weapon("Hamer", 10));
inventory.Add(new Weapon("Bazuka", 20));
inventory.Add(new Weapon("Tank", 70));

users.Add(new User("David", 100, inventory[0]));
users.Add(new User("Max", 50, inventory[1]));
users.Add(new User("Lina", 100, inventory[2]));

inventory.Add(new Weapon("lasso", 15));
users.Add(new User("Lina", 100, inventory[1]));



foreach (User user in users)
{
    foreach (Weapon weapon in inventory)
    {
<<<<<<< HEAD
        user.show(weapon);
        break;
=======

        user.show(weapon);
        break;

>>>>>>> b925fedee3e25246ae2a1ba77c5035f3af59d73b
    }
}

