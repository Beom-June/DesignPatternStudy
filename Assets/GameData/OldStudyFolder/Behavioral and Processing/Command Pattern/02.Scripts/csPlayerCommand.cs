using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class csPlayerCommand : MonoBehaviour 
{
	Stack<CommandKey> stack = new Stack<CommandKey>();

    public void MoveForward()
    {
        CommandKey command = new CommandMoveForward();
        stack.Push(command);
        command.Execute(transform, new Vector3(0f, 0f, 1f));
    }

    public void MoveRight()
    {
        CommandKey command = new CommandMoveRight();
        stack.Push(command);
        command.Execute(transform, new Vector3(1f, 0f, 0f));
    }

    public void MoveUndo()
    {
        if (stack.Count > 0)
        {
            CommandKey command = stack.Pop();
            command.Undo(transform);
        }
    }

}
