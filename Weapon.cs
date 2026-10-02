
class Weapon : Item
{
    public int minDamage;
    public int maxDamage;
    public Weapon()
    {
            name = "Sword";
            Weight = 10;
            minDamage = 5;
            maxDamage = 25;
    }
    
    public int Attack()
    {
        return Random.Shared.Next(minDamage, maxDamage);
    }
}
