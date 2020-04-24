using UnityEngine;
using System.Collections;
using Vuforia;

public class AugmentedImageController : MonoBehaviour
{
    [SerializeField] private AugmentedImageVisualizer _augmentedImageVisualizer;

    private readonly Dictionary<int, AugmentedImageVisualizer> _visualizers =
        new Dictionary<int, AugmentedImageVisualizer>();
    
    private readonly List<AugmentedImage> _images = new List<AugmentedImage>();

    public void Update()
    {
        if(Session.Status != SessionStatus.Tracking)
        {
            return;
        }

        Session.GetTrackables(_images, TrackableQueryFilter.Updated);
        VisualizeTrackables();
    }

    private void VisualizeTrackables()
    {
        foreach (var image in _images)
        {
            var visualizer = GetVisualizer(image);

            if(image.TrackingState == TrackingState.Tracking && visualizer == null)
            {
                AddVisualizer(image);
            }
            else if (image.TrackingState == TrackingState.Stopped && visualizer != null)
            {
                RemoveVisualizer(image, visualizer);
            }
        }
    }

    private void RemoveVisualizer(AugmentedImage image, AugmentedImageVisualizer visualizer)
    {
        _visualizers.Remove(image.DatabaseIndex);
        Destroy(visualizer.gameObject);
    }

    private void AddVisualizer(AugmentedImage image)
    {
        var anchor = image.CreateAnchor(image.CenterPose);
        var visualizer = Instantiate(_augmentedImageVisualizer, anchor.transform);
        visualizer.Image = image;
        _visualizers.Add(image.DatabaseIndex, visualizer);
    }

    private AugmentedImageVisualizer GetVisualizer(AugmentedImage image)
    {
        AugmentedImageVisualizer visualizer;
        _visualizers.TryGetValue(image.DatabaseIndex, out visualizer);
        return visualizer;
    }
}