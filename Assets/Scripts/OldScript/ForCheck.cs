using UnityEngine;

public class ForCheck : MonoBehaviour
{

    public int number = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            Debug.Log("Yep. Number = " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
