using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedExample : MonoBehaviour
{
    public speed = 0.0f;
    public distance = 0.0f;
    public float time = 0.0f;

    public float maxSpeedLimit = 70.0f;
    public float minSpeedLimit = 40.0f;

    private int destId = 0;

    void Start ()
    {
        destId = Random.Range (1, 5);

        switch (destId)
        {
            case 1:
                print ("You decided to go North");
                break;
            case 2:
                print ("You decided to go East");
                break;
            case 3:
                print ("You decided to go South");
                break;
            case 4:
                print ("You decided to go West");
                break;
            default:
                print ("You decided to go Nowhere!");
                break;
        }
    }

    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            SpeedCheck ();
        }

    }

    void SpeedCheck ()
    {
        speed = distance / time;

        if (speed > maxSpeedLimit)
        {
            print ("You are exceeding the speed limit.");
        }
        else if (speed < minSpeedLimit)
        {
            print ("You are not going fast enough!");
        }
        else
        {
            print ("You are within the speed limit.");
        }

        //print ("You are traveling at " + speed + " MPH.");
    }
}