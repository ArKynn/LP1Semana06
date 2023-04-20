namespace GameSix;

public class Foe
{
    private string Name { get; }
    private int Health { get; set; }
    private int Shield { get; set; }
    public Foe(string name)
    {
        this.Name = name;
        Health = 100;
        Shield = 0;
    }
}