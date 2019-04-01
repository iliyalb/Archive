using UnityEngine;
using System.Collections;
using Vuforia;

public class AugmentedImageVisualizer : MonoBehaviour
{
    [SerializeField] private VideoClip[] _videoClips;
    private VideoPlayer _videoPlayer;


    void Start()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
        _videoPlayer.loopPointReached += OnStop;
    }

    private void OnStop(VideoPlayer source)
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if (Image == null || Image.TrackingState != TrackingState.Tracking)
        {
            return;
        }

        if (!_videoPlayer.isPlaying)
        {
            _videoPlayer.clip = _videoClips[Image.DatabaseIndex];
            _videoPlayer.Play();
        }

        transform.localScale = new Vector3(Image.ExtentX, Image.ExtentZ, 1);
    }
}