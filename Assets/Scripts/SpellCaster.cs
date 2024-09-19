using UnityEngine;

public class SpellCaster : MonoBehaviour
{
    private void Start()
    {
        ISpell spell = new Spell(0);

        spell.Decorate(new ElementDecorator(SpellTypes.Fire));
        spell.Decorate(new ElementDecorator(SpellTypes.Ice));

        spell.Cast();
    }
}
