using UnityEngine;
using System.Collections;

public class PlayClass : MonoBehaviour
{
    public MovieTexture movTexture;

    void Start()
    {
        GetComponent<Renderer>().material.mainTexture = movTexture;
        movTexture.Play();
        movTexture.loop = true;
    }

    void Update()
    {

    }
}