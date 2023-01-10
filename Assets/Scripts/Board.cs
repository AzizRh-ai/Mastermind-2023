using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private GameObject[] PinLine;
    [SerializeField] private Transform[] SpawnOrigin;
    [SerializeField] public int[] secretCode;
    void Start()
    {

        GameObject pin = Instantiate(PinLine[0], SpawnOrigin[0].position, Quaternion.identity);
        Code code = new Code();
        code.combinaison();
        Debug.Log(string.Join(",", "Code Secret :" + code.secretCode));

    }

}
