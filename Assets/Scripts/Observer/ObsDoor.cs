using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Door that opens when the player stands on a switch
public class ObsDoor : MonoBehaviour
{
    private Transform doorTrans;

    //Set this in the inspector
    public ObsPlatform ActivatingPlatform;

    void Start()
    {
        doorTrans = GetComponent<Transform>();
        ActivatingPlatform.openEvent += OpenCloseDoor;
    }

    private void OpenCloseDoor(bool mustOpen)
    {
        if (mustOpen)
        {
            ChangeRotation(90f);
        } else
        {
            ChangeRotation(-90f);
        }
    }

    private void ChangeRotation(float angle)
    {
        Vector3 oldRotation = doorTrans.rotation.eulerAngles;
        Vector3 newRotation = new Vector3(oldRotation.x, oldRotation.y + angle, oldRotation.z);
        doorTrans.rotation = Quaternion.Euler(newRotation);
    }
}
