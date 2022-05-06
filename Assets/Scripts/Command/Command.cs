using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the abstract class for a command
//We can include a constructor with the receiver here
//Instead, I include the receiver in the concrete implementation
public abstract class Command
{
    public abstract void Execute();
    //Undo functionality needs to be oppposite of Execute command
    public abstract void Undo();
}
