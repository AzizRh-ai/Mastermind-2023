using UnityEngine;

public class PickerColor : MonoBehaviour
{
    [SerializeField] private GameObject[] PinColor;
    public bool showPicker = false;
    public GameObject pinSelected;
    // Start is called before the first frame update

    private void OnMouseExit()
    {
        hidePickerPinColor();
    }

    public void showPickerPinColor(GameObject pin)
    {
        transform.position = pin.transform.position;
        pinSelected = pin;
        for (int i = 0; i < PinColor.Length; i++)
        {
            PinColor[i].SetActive(true);
        }
        showPicker = true;
    }

    public void hidePickerPinColor()
    {
        for (int i = 0; i < PinColor.Length; i++)
        {
            PinColor[i].SetActive(false);
        }
        showPicker = false;
    }
}
