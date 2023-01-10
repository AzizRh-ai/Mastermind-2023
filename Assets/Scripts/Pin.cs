using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField] Material[] PinColor;
    public int[] pinResult;
    public int[] data;
    [SerializeField] private GameObject actualObj;
    //[SerializeField] GameObject Pine;

    private void Start()
    {
        data = new int[4];
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Pin"))
            {
                Debug.Log(hit.collider.name);
                hit.collider.GetComponent<Renderer>().material = ChangeColor();
            }
            //Debug.Log(Pine.name);
        }

    }

    public Material ChangeColor()
    {
        var value = Random.Range(0, 6);
        pinResult[0] = value;
        for (int i = 0; i < pinResult.Length; i++)
        {
            pinResult[i] = value;
            //actualObj.GetComponent<LineCombinaison>().datra[i] = value;
        }

        return PinColor[pinResult[0]];
    }
}
