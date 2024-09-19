using UnityEngine;

public interface ICommand
{
    void Execute();
}

public class CastSpellCommand : ICommand
{
    ISpell spellToCast = null;

    public CastSpellCommand(ISpell spell)
    {
        spellToCast = spell;
    }

    public void Execute()
    {
        if (spellToCast != null)
        {
            Cast();
        }
    }

    private void Cast()
    {
        spellToCast.Cast();
    }
}
