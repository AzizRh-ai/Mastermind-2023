using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private GameObject[] PinLine;
    [SerializeField] private Transform[] SpawnOrigin;
    [SerializeField] public int[] secretCode;
    void Start()
    {
        // Instantiate PinLine
        // GameObject pin = Instantiate(PinLine[0], SpawnOrigin[0].position, Quaternion.identity);
        //ChangeColor(pin);
        /*   for (int i = 0; i < PinLine.Length; i++)
           {
               Instantiate(PinLine[i], SpawnOrigin[i].position, Quaternion.identity);
           }*/
        // compareResult();

    }


    private void Update()
    {
        /*        if (Input.GetMouseButtonDown(0))
                {
                    RaycastHit hit;
                    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Pin"))
                    {
                        Debug.Log(hit.collider.name);
                        ChangeColor(hit.collider);
                    }
                }*/
    }

    public void ChangeColor(Collider mat)
    {
        mat.GetComponent<Renderer>().material.color = Color.red;
    }

    // récuperer le code secret & les valeurs utilisateur.
    private bool compareResult()
    {
        // Get secret Code
        Code code = new Code();
        code.combinaison();
        Debug.Log("Code Secret: " + string.Join(",", code.secretCode));

        return true;
    }

}
