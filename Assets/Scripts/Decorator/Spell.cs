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

public interface ISpell : IPoolable
{
    int damage { get; set; }

    HashSet<SpellTypes> spellTypes { get; set; }

    void Decorate(SpellDecorator decorator);

    void Cast();
}

public class Spell : ISpell
{
    public int damage { get; set; }
    public HashSet<SpellTypes> spellTypes { get; set; } = new HashSet<SpellTypes>() { SpellTypes.Normal };
    public bool active { get; set; }

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

    public void OnEnableObject()
    {
        Debug.Log("Render spell in players hand");
    }

    public void OnDisableObject()
    {
        Debug.Log("Stop rendering the spell");
    }
}
