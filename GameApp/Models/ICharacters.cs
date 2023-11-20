public interface ICharacters
{
    public string Name { get; set; }
    public double Health { get; set; }
    public int Power { get; set; }
    public int Defense { get; set; }

    public void Attack(AbstractCharacter target);
    public void Hit(int damage);

    public void Method() { }
}