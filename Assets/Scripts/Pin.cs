using UnityEngine;

public class Pin : MonoBehaviour
{
    public PickerColor pinSelect;
    private void OnMouseOver()
    {
        pinSelect.showPickerPinColor(gameObject);
    }

    public void ChangeColor(Material mat)
    {
        GetComponent<MeshRenderer>().material = mat;
    }
}
