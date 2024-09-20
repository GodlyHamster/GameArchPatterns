using UnityEngine;

public class Player : MonoBehaviour
{
    private InputHandler inputHandler = new InputHandler();

    void Start()
    {
        inputHandler.BindKeyToCommand(KeyCode.Space, new CastSpellCommand());
    }

    void Update()
    {
        inputHandler.HandleInput();
    }
}
