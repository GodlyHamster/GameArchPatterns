using UnityEngine;

public class Player : MonoBehaviour
{
    private InputHandler inputHandler = new InputHandler();

    ISpell spell = new Spell(0);

    void Start()
    {
        inputHandler.BindKeyToCommand(KeyCode.Space, new CastSpellCommand(spell));
    }

    void Update()
    {
        inputHandler.HandleInput();
    }
}
