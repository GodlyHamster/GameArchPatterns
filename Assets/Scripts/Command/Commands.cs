using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    void Execute();
}

public class CastSpellCommand : ICommand
{
    private ObjectPool<ISpell> spellPool = new ObjectPool<ISpell>(new List<ISpell>() {
        new Spell(0),
        new Spell(5),
        new Spell(10)
    });

    public CastSpellCommand()
    {
    }

    public void Execute()
    {
        Cast();
    }

    private void Cast()
    {
        spellPool.RequestObject()?.Cast();
    }
}
