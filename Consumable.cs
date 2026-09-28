
class Consumable : Item
{
    public int usesMax;
    public int usesCurrent;
    
    public void Use(Character Hp)
    {
        Hp.Hp += 10;
    }
}
