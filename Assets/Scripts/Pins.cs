using UnityEngine;

public class Pins : MonoBehaviour
{
    [SerializeField] private GameObject[] Obj;
    [SerializeField] private Material[] PinsColor;

    public Material[] CombinaisonActu()
    {
        Material[] result = new Material[4];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = Obj[i].GetComponent<MeshRenderer>().material;
        }
        return result;
    }

    public void GenAleatoire()
    {
        for (int i = 0; i < Obj.Length; i++)
        {
            int data = Random.Range(0, PinsColor.Length);
            Material cal = PinsColor[data];
            Obj[i].GetComponent<MeshRenderer>().material = cal;
        }
    }

}
