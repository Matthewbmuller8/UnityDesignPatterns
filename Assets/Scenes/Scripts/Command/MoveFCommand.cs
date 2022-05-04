using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFCommand : Command
{
    public IMovable Movable { get; set; }

    public MoveFCommand(IMovable movable)
    {
        Movable = movable;
    }

    public override void Execute()
    {
        Movable.Move(Vector3.forward);
    }
}
