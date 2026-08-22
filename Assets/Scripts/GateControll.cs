using UnityEngine;

public class GateControll : MonoBehaviour
{
    // Movement
    public Transform myTransform;
    public float currentXPosition;
    public float currentYPosition;
    public float currentZPosition;

    // Speeds
    public float startSpeed;
    public float boostSpeed;
    public float bigBoostSpeed;
    public float slowDown;
    public float speedOverall;
    public float updateSpeed;
    
    // Ref
    public UI uI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       uI = GameObject.Find("UI").GetComponent<UI>();
        
        // Transform position
        currentXPosition = myTransform.position.x;
        currentYPosition = myTransform.position.y;
        currentZPosition = myTransform.position.z;

        // Set Speed
        startSpeed = 2;
        speedOverall = startSpeed;
        updateSpeed = startSpeed;
        uI.speedText.text = "Speed: " + speedOverall.ToString();

        // Boost speed set
        boostSpeed = 1;
        bigBoostSpeed = 5;
        slowDown = 1;
    }

    // Update is called once per frame
    void Update()
    {
        speedOverall = updateSpeed;
    }

}
