using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSM : StateMachine
{
    //Movement variables
    public Rigidbody Rb;
    public float Speed = 4f;
    public float JumpForce = 10f;
    //public bool Grounded;

    //States
    [HideInInspector]
    public Idle IdleState;
    [HideInInspector]
    public Moving MovingState;
    [HideInInspector]
    public Jumping JumpingState;

    private void Awake()
    {
        IdleState = new Idle(this);
        MovingState = new Moving(this);
        JumpingState = new Jumping(this);

        Rb = this.GetComponent<Rigidbody>();
    }

    protected override BaseState GetInitialState()
    {
        //Want to be idle by default
        return IdleState;
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 1 << 6)
        {
            Grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 1 << 6)
        {
            Grounded = false;
        }
    }
    */
}
