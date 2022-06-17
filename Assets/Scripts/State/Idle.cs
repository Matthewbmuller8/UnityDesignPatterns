using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : Grounded
{
    //private MovementSM sm;
    private float horizontalInput;

    public Idle(MovementSM stateMachine) : base("Idle", stateMachine)
    {
        //Casting base StateMachine to MovementSM
        sm = stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        horizontalInput = 0f;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        horizontalInput = Input.GetAxis("Horizontal");
        //Accounting for possible float aprroximation errors
        if (Mathf.Abs(horizontalInput) > Mathf.Epsilon)
        {
            stateMachine.ChangeState(sm.MovingState);
        }
    }


}
