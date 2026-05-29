using UnityEngine;

public class rotater : MonoBehaviour
{
    // variaables
    // speed 
    public float speed;
    public Transform speed_of_transform;

    // functions
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed_of_transform.Rotate(0, speed, 0);
    }
}
