using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class scrr : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbButtonObject;
    // Start is called before the first frame update
    void Start()
    {
        vbButtonObject = GameObject.Find("one");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Application.OpenURL("tel://[9911147112]");
        Debug.Log("one Button Down");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("one Button released");
    }

}

