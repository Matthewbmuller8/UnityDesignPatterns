using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLCommand : Command
{
    public IMovable Movable { get; set; }

    public MoveLCommand(IMovable movable)
    {
        Movable = movable;
    }

    public override void Execute()
    {
        Movable.Move(Vector3.left);
    }
}
