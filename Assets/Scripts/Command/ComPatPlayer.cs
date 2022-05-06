using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ComPatPlayer : MonoBehaviour, IMovable
{
    private CharacterController charController;
    [SerializeField]
    private float moveSpeed = 5f;

    private void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    /*private void Update()
    {
        Move();
    }*/

    public void Move(Vector3 direction)
    {
        //Using fixed delta time so execute and undo commands align
        charController.Move(moveSpeed * Time.fixedDeltaTime * direction);
    }
}
