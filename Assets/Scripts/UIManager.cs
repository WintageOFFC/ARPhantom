using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject[] sliders;
    [SerializeField] private GameObject[] slisers;
    [SerializeField] private GameObject notification;

    public void ToggleSlider(int index)
    {
        for (int i = 0; i < sliders.Length; i++)
        {
            if (sliders[i] != null)
            {
                sliders[i].SetActive(i == index ? !sliders[i].activeSelf : false);
                slisers[i].SetActive(i == index ? !slisers[i].activeSelf : false);
            }
        }
    }

    public void notificationVisible(bool state)
    {
        notification.SetActive(state);
    }
}
