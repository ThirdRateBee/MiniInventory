
class Inventory
{
    public List<Item> Items = new List<Item>();
    public Weapon mainWeapon = new Weapon();
    public Consumable Apple = new Consumable();
    public Inventory()
    {
        Items.Add(mainWeapon);
        Items.Add(Apple);
    }
    public void Display()
    {
        foreach (Item e in Items)
        {
            Console.WriteLine(e.name);
        }
    }
}
