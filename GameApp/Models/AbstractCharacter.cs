public abstract class AbstractCharacter : ICharacters
{
    private double health;
    private double mana;

    public string Name { get; set; }
    public double Health
    {
        get => health;
        set => health = HealthManaCheck(value);
    }
    public double Mana
    {
        get => mana;
        set => mana = HealthManaCheck(value);
    }
    public int Power { get; set; }
    public int Defense { get; set; }

    public AbstractCharacter(string name, double health, int power, int defense)
    {
        Name = name;
        Health = health;
        Power = power;
        Defense = defense;
    }

    public AbstractCharacter(string name, double health, double mana, int power, int defense)
    : this(name, health, power, defense)
    {
        Mana = mana;
    }

    public void Attack(AbstractCharacter target)
    {
        var damage = Power - target.Defense;
        if (damage > 0)
        {
            target.Hit(damage);
        }
        else
        {
            System.Console.WriteLine($"{target.Name} blocked attack!");
        }
    }

    public void Hit(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            System.Console.WriteLine($"{Name} is defeated!");
        }
        else
        {
            System.Console.WriteLine($"{Name} take {damage} damage!");
        }
    }

    public double HealthManaCheck(double value)
    {
        if (value > 100)
            return 100;
        if (value <= 0)
            return 0;
        return value;
    }
}