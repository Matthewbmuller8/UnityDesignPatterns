using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : Grounded
{
    //private MovementSM sm;
    private float horizontalInput;

    public Moving(MovementSM stateMachine) : base("Moving", stateMachine)
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
        if (Mathf.Abs(horizontalInput) < Mathf.Epsilon)
        {
            stateMachine.ChangeState(sm.IdleState);
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        Vector2 vel = sm.Rb.velocity;
        vel.x = horizontalInput * sm.Speed;
        sm.Rb.velocity = vel;
    }

}
