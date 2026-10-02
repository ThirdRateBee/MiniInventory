
class Inventory
{
    List<Item> Items; 
    public Weapon mainWeapon = new Weapon();
    public Consumable Apple = new Consumable();
    public Inventory()
    {
        Items.Add(mainWeapon);
        Items.Add(Apple);
    }
    public void Display()
    {
        foreach (Item item in Items)
        {
            Console.WriteLine(item.name);
        }
    }
}
