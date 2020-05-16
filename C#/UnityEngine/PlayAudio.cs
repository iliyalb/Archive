using System.Collections;
using System.Collections.Genetic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    AudioSource audio;

    private void Start ()
    {
        audio = GetComponent<AudioSource> ();
    }

    public void playAudio ()
    {
        audio.Play ();
    }
}