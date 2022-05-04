using UnityEngine;

//Need the interface so we know we are commanding something that moves
public interface IMovable
{
    void Move(Vector3 direction);
}
