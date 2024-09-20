using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private InputHandler inputHandler = new InputHandler();

    private CastSpellCommand castSpellCommand;
    private DecorateFireCommand fireDecorator;

    private ObjectPool<ISpell> spellPool = new ObjectPool<ISpell>(new List<ISpell>() {
        new Spell(0),
        new Spell(5),
        new Spell(10)
    });

    void Start()
    {
        castSpellCommand = new CastSpellCommand(spellPool);
        fireDecorator = new DecorateFireCommand(spellPool);

        inputHandler.BindKeyToCommand(KeyCode.Space, castSpellCommand);
        inputHandler.BindKeyToCommand(KeyCode.Q, fireDecorator);
    }

    void Update()
    {
        inputHandler.HandleInput();
    }
}
