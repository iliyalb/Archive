using UnityEngine;
using System.Collections;
using Vuforia;

public class VuforiaButton : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject VButtonObject;
    private GameObject obj;

    void Start()
    {
        VButtonObject = GameObject.Find ("RotateButton");
        VButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        obj = GameObject.Find("objName");
    }

    public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button Pressed");
        obj.transform.Rotate(new Vector3(0,Time.deltaTime * 1000,0));

    }

    public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button Released");
    }
}