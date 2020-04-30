using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CubeEnhance : MonoBehaviour {
    [Header("Transform Variables")]

    [Space(10)]

    [Tooltip("Edit the Position of the Cube")]
    public Vector3 Position;
    [Tooltip("Edit the Rotation of the Cube")]
    public Vector3 Rotation;
    [Tooltip("Edit the Size of the Cube")]
    [Range(1f,10f)]
    public float Size;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Position;
        transform.eulerAngles = Rotation;
        transform.localScale = new Vector3(Size, Size, Size);
	}
}
