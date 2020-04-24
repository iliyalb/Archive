using UnityEngine;
using System.Collections;

public class ShadowScript : MonoBehaviour
{
    //Follow object and name it to myParent
    public GameObject myParent;

    //Init
    void Start()
    {

    }

    void Update()
    {
        transform.position = new Vector3 (
            myParent.transform.position.x, 0, myParent.transform.position.z)
    }
}