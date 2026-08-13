using UnityEngine;

public class GateSlotRandom : MonoBehaviour
{
    // Slot in Spawn Position
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;

    // Coloue Gates
    public GameObject green;
    public GameObject red;
    public GameObject yellow;
    public GameObject blue;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        green.transform.position = s1.transform.position;
        red.transform.position = s3.transform.position;
        yellow.transform.position = s2.transform.position;
        blue.transform.position = s3.transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
