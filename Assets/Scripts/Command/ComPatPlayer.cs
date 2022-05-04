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
        /*Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
        direction = direction.normalized;*/
        charController.Move(direction * moveSpeed * Time.deltaTime);
    }
}
