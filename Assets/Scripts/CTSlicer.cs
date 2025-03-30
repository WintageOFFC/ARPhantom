using UnityEngine;
using UnityEngine.UI;
using UnityVolumeRendering;

public class CTSlicer : MonoBehaviour
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
            volumeObject.SetVisibilityWindow(slicer.value, 1);
        }
    }
}
