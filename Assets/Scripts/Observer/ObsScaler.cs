using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Changes size when the platform is activated
public class ObsScaler : MonoBehaviour
{
    private Transform objTrans;

    //Set this in the inspector
    public ObsPlatform ActivatingPlatform;

    void Start()
    {
        objTrans = GetComponent<Transform>();
        ActivatingPlatform.scaleEvent += ChangeScale;
    }

    private void ChangeScale (float scaleFact)
    {
        Vector3 oldScale = objTrans.localScale;
        Vector3 newScale = oldScale*scaleFact;
        objTrans.localScale = newScale;
    }
}
