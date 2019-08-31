
using UnityEngine;

public class scr : MonoBehaviour
{
    public string Url;
    public void Open()
    {
        Application.OpenURL(Url);
    }



}
