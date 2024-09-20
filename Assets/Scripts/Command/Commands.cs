using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    void Execute();
}

public class CastSpellCommand : ICommand
{
    private ObjectPool<ISpell> spellPool;

    public CastSpellCommand(ObjectPool<ISpell> spellPool) {
        this.spellPool = spellPool;
    }

    public void Execute()
    {
        Cast();
    }

    private void Cast()
    {
        spellPool.ActivateItem(spellPool.RequestObject())?.Cast();
    }
}

public class DecorateFireCommand : ICommand
{
    private ObjectPool<ISpell> spellPool;

    public DecorateFireCommand(ObjectPool<ISpell> spellPool)
    {
        this.spellPool = spellPool;
    }

    public void Execute()
    {
        DecorateSpell();
    }

    private void DecorateSpell()
    {
        spellPool.RequestObject()?.Decorate(new ElementDecorator(SpellTypes.Fire));
        Debug.Log("Decorated spell with fire");
    }
}
