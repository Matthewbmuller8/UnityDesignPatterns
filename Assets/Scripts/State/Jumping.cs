using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : BaseState
{
    private MovementSM sm;
    private bool grounded;
    
    public Jumping(MovementSM stateMachine) : base("Jumping", stateMachine)
    {
        //Casting base StateMachine to MovementSM
        sm = stateMachine;
    }

    public override void Enter()
    {
        base.Enter();

        Vector2 vel = sm.Rb.velocity;
        vel.y += sm.JumpForce;
        sm.Rb.velocity = vel;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (grounded)
        {
            stateMachine.ChangeState(sm.IdleState);
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        //Should also check if the player is touching the ground plane using object layers
        grounded = sm.Rb.velocity.y < Mathf.Epsilon;
    }
}
