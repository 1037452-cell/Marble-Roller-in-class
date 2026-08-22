using UnityEngine;

public class GateMover : MonoBehaviour
{
    public GateControll controll;
    public Transform myTransform;
    public float currentXPosition;
    public float currentYPosition;
    public float currentZPosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentXPosition = myTransform.position.x;
        currentYPosition = myTransform.position.y;
        currentZPosition = myTransform.position.z;
        controll = GameObject.Find("GateControll").GetComponent<GateControll>();
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = new Vector3(currentXPosition += (Time.deltaTime * controll.speedOverall), currentYPosition, currentZPosition);
    }
}
