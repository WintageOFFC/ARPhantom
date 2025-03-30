using UnityEngine;
using UnityEngine.UI;

public class AnatomySlicer : MonoBehaviour
{
    [SerializeField] private Slider slicer;
    [SerializeField] private GameObject[] objects;

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
        int state = Mathf.Clamp(Mathf.RoundToInt(value), 0, 6);

        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i] != null)
            {
                objects[i].SetActive(i >= state);
            }
        }
    }
}
