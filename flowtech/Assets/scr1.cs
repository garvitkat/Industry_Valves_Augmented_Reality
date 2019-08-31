using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class scr1 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbButtonObject;
    // Start is called before the first frame update
    void Start()
    {
        vbButtonObject = GameObject.Find("two");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Application.OpenURL("https://www.youtube.com/watch?v=C0D12KZE7PY");
        Debug.Log("Video Button Down");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Video Button released");
    }

}

