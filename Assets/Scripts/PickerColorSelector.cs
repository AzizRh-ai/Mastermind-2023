using UnityEngine;

public class PickerColorSelector : MonoBehaviour
{
    private Material _color;
    public PickerColor pinSelect;

    private void Awake()
    {
        _color = GetComponent<MeshRenderer>().material;
    }

    private void OnMouseDown()
    {
        pinSelect.pinSelected.GetComponent<Pin>().ChangeColor(_color);
    }
}
