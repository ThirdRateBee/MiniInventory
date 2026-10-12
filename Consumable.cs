
class Consumable : Item
{
    public int usesMax = 5;
    public int usesCurrent;
    public Consumable()
    {
        name = "Apple";
        Weight = 1;
    }
    public void Use(Character Hp)
    {
        Hp.Hp += 10;
    }
}
