using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBCommand : Command
{
    public IMovable Movable { get; set; }

    public MoveBCommand(IMovable movable)
    {
        Movable = movable;
    }

    public override void Execute()
    {
        Movable.Move(Vector3.back);
    }
}
