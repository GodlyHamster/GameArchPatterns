using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    private List<KeyCommand> keyCommands = new List<KeyCommand>();

    public void HandleInput()
    {
        foreach (KeyCommand bind in keyCommands)
        {
            if (Input.GetKeyDown(bind.keyCode))
            {
                bind.command.Execute();
            }
        }
    }

    public void BindKeyToCommand(KeyCode key, ICommand command)
    {
        keyCommands.Add(new KeyCommand
        {
            keyCode = key,
            command = command
        });
    }

    public void UnbindKey(KeyCode key)
    {
        var items = keyCommands.FindAll(x => x.keyCode == key);
        items.ForEach(x => keyCommands.Remove(x));
    }

    private class KeyCommand
    {
        public KeyCode keyCode;
        public ICommand command;
    }
}
