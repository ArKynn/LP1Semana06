namespace GameSixFriday;

public class Foe
{
    private string Name { get; set; }
    private float Health { get; set; }
    private float Shield { get; set; }
    private static int _pickedPowerUps;

    static Foe()
    {
        _pickedPowerUps = 0;
    }
    
    public Foe(string name)
    {
        SetName(name);
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

    public void PickupPowerUp(PowerUp powerUp, float amount)
    {
        if (powerUp == PowerUp.Health)
        {
            float oldHp = this.Health;
            
            this.Health += amount;
            if (Health > 100) Health = 100;
            Console.WriteLine($"Health restored: {Health - oldHp}");
        }
        if (powerUp == PowerUp.Shield)
        {
            float oldShield = this.Shield;
            
            this.Shield += amount;
            if (Shield > 100) Shield = 100;
            Console.WriteLine($"Shield Restored: {Shield - oldShield}");
        }

        _pickedPowerUps++;
    }

    public static int GetPickedPowerUps()
    {
        return _pickedPowerUps;
    }
}