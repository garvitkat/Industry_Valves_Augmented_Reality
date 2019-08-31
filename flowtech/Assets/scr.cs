using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class scr : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbButtonObject;
    // Start is called before the first frame update
    void Start()
    {
        vbButtonObject = GameObject.Find("one");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void  OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Application.OpenURL("https://flowtechvalvesfittings.000webhostapp.com");
        Debug.Log("Website Button Down");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Website Button released");
    }

}

