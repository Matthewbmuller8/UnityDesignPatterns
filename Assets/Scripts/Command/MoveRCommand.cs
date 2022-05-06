using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRCommand : Command
{
    public IMovable Movable { get; set; }

    public MoveRCommand(IMovable movable)
    {
        Movable = movable;
    }

    public override void Execute()
    {
        Movable.Move(Vector3.right);
    }

    public override void Undo()
    {
        Movable.Move(Vector3.left);
    }
}
