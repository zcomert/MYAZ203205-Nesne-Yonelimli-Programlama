public class PlayerCharacter : AbstractCharacter, ISkills
{
    public PlayerCharacter(string name, double health, double mana, int power, int defense)
    : base(name, health, mana, power, defense)
    {
    }

    public void Fireball(AbstractCharacter target)
    {
        if (Mana > 0)
        {
            target.Hit(25);
            Mana -= 20;
        }
        else
        {
            System.Console.WriteLine("Fireball can't be used!");
        }
    }

    public void Heal(AbstractCharacter character)
    {
        if (Mana > 0)
        {
            Health += 20;
            Mana -= 10;
        }
        else
        {
            System.Console.WriteLine("Heal can't be used!");
        }
    }
}