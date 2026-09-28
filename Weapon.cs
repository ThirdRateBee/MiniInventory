
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
