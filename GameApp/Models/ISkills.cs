public interface ISkills
{
    public double Mana { get; set; }

    public void Heal(AbstractCharacter character);
    public void Fireball(AbstractCharacter target);
}