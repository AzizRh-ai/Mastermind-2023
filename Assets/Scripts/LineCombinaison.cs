using UnityEngine;

public class LineCombinaison : MonoBehaviour
{
    public int[] datra;
    [SerializeField] private GameObject[] pion;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < pion.Length; i++)
        {
            datra[i] = pion[i].GetComponent<Pin>().pinResult[0];

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
