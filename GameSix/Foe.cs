namespace GameSix;

public class Foe
{
    private string Name { get; set; }
    private float Health { get; set; }
    private float Shield { get; set; }
    public Foe(string name)
    {
        this.Name = name;
        Health = 100;
        Shield = 0;
    }

    public string GetName()
    {
        return this.Name;
    }

    public void SetName(string newName)
    {
        newName = newName.Trim();
        this.Name = newName;
        return;
    }

    public float GetHealth()
    {
        return Health;
    }
    
    public float GetShield()
    {
        return Shield;
    }

    public void TakeDamage(int damage)
    {
        Shield -= damage;
        if (Shield < 0)
        {
            float remainingDamage = -Shield;
            Shield = 0;
            Health -= remainingDamage;
            if (Health < 0) Health = 0;
        }
    }
}