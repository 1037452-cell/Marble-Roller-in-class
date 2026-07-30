using UnityEngine;

public class Camera : MonoBehaviour
{

    public Marble theMarble;
    public Transform myTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myTransform = theMarble.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
