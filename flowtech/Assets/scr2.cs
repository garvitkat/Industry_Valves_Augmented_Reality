using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class scr2 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbButtonObject;
    // Start is called before the first frame update
    void Start()
    {
        vbButtonObject = GameObject.Find("three");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Application.OpenURL("tel://[9911147112]");
        Debug.Log("Call Button Down");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Call Button released");
    }

}

