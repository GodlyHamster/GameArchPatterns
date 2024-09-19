public abstract class SpellDecorator
{
    public int damage { get; set; }

    public SpellDecorator()
    {
    }

    public abstract ISpell Decorate(ISpell spell);
}

public class ElementDecorator : SpellDecorator
{
    private SpellTypes spellType;
    public ElementDecorator(SpellTypes spelltype) 
    {
        this.spellType = spelltype;
    }

    public override ISpell Decorate(ISpell spell)
    {
        spell.spellTypes.Add(spellType);
        spell.damage += damage;
        return spell;
    }
}
