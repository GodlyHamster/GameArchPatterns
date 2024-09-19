using System.Collections.Generic;
using UnityEngine;

public enum SpellTypes
{
    Normal,
    Fire,
    Ice,
    Thunder,
    Earth
}

public interface ISpell
{
    int damage { get; set; }

    List<SpellTypes> spellTypes { get; set; }

    void Decorate(SpellDecorator decorator);

    void Cast();
}

public class Spell : ISpell
{
    public int damage { get; set; }
    public List<SpellTypes> spellTypes { get; set; } = new List<SpellTypes>();

    public Spell(int damage)
    {
        this.damage = damage;
    }

    public void Decorate(SpellDecorator decorator)
    {
        decorator.Decorate(this);
    }

    public void Cast()
    {
        Debug.Log("Cast [" + string.Join(", ", spellTypes) + "] spell dealing [" + damage + "] damage");
    }
}
