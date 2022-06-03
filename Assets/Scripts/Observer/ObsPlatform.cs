using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Switch that notifies the objects watching it that it has been pressed
//The switch doesn't know what it is activating
public class ObsPlatform : MonoBehaviour
{
    [SerializeField]
    private Transform platformTrans;

    public delegate void BoolDelegate(bool x);
    public delegate void FloatDelegate(float x);

    public event BoolDelegate openEvent;
    public event FloatDelegate scaleEvent;

    public float ScaleValue = 2f;
    public float Offset = 0.2f;

    private void ActivateSwitch()
    {
        openEvent?.Invoke(true);
        scaleEvent?.Invoke(ScaleValue);
    }

    private void DeactivateSwitch()
    {
        openEvent?.Invoke(false);
        scaleEvent?.Invoke(1/ScaleValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Trigger entered");
        ActivateSwitch();
        MovePlatform(-Offset);
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Trigger exited");
        DeactivateSwitch();
        MovePlatform(Offset);
    }

    private void MovePlatform(float offset)
    {
        Vector3 oldPos = platformTrans.position;
        Vector3 newPos = new Vector3(oldPos.x, oldPos.y + offset, oldPos.z);
        platformTrans.position = newPos;
    }
}
