using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private InputHandler inputHandler = new InputHandler();

    private ObjectPool<ISpell> spellPool = new ObjectPool<ISpell>(new List<ISpell>() {
        new Spell(0),
        new Spell(5),
        new Spell(10)
    });

    void Start()
    {
        inputHandler.BindKeyToCommand(KeyCode.Space, new CastSpellCommand(spellPool.RequestObject()));
    }

    void Update()
    {
        inputHandler.HandleInput();
    }
}
