using UnityEngine;

public partial class Spawner : MonoBehaviour
{

    public int number = 10;
    public GameObject cap;
    public Transform myTransform;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            Debug.Log("Yep. Number = " + i);
            Instantiate(cap, myTransform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
