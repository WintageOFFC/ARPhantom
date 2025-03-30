using UnityEngine;
using UnityEngine.UI;
using UnityVolumeRendering;

public class MRISlicer : MonoBehaviour
{
    [SerializeField] private Slider slicer;
    [SerializeField] private VolumeRenderedObject volumeObject;

    private void Start()
    {
        if (slicer != null)
        {
            slicer.onValueChanged.AddListener(UpdateVisibility);
            UpdateVisibility(slicer.value);
        }
    }
    private void UpdateVisibility(float value)
    {
        if (volumeObject != null)
        {
            volumeObject.SetVisibilityWindow(0, 1-slicer.value);
        }
    }
}
