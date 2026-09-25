
class Item
{
    public string Name;
    public float Weight;
}

class Weapond : Item
{
    public int minDamage;
    public int maxDamage;
    
    public static int Attack(int minDamage, int maxDamage)
    {
        int damage = Random.Shared.Next(minDamage, maxDamage);
        return damage;
    }
}

class Armor : Item
{
    float Protection;
}

class Consumable : Item
{
    public int usesMax;
    public int usesCurrent;
    
    public void Use(Character Hp)
    {
        Hp.Hp += 10;
    }
}