using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObsPlayer : MonoBehaviour
{
    private CharacterController charController;
    [SerializeField]
    private float moveSpeed = 5f;

    private void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(x, 0, z);
        charController.Move(moveSpeed * Time.fixedDeltaTime * direction);
    }
}
