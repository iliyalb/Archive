using System.Collections;
using System.Collections.Genetic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CarCrossPlatformInput : MonoBehaviour
{

    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    private void Update ()
    {
        float translation = CrossPlatformInputManager.GetAxis ("Vertical") * speed;
        float rotation = CrossPlatformInputManager.GetAxis ("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate (0, 0, translation);
        transform.Rotate (0, rotation, 0);
    }
}