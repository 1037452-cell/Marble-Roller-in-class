using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlaneMovement : MonoBehaviour
{
    // Positions
    public Transform myTransform;
    public float currentXPosition;
    public float currentYPosition;
    public float currentZPosition;

    // Speeds
    public float startSpeed;
    public float boostSpeed;
    public float bigBoostSpeed;
    public float slowDown;

    // Trigger Type
    public bool isGreen;
    public bool isYellow;
    public bool isRed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentXPosition = myTransform.position.x;
        currentYPosition = myTransform.position.y;
        currentZPosition = myTransform.position.z;
        startSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlane();


        //if (Keyboard.current.spaceKey.isPressed)
        //{
        //    MovePlane();
        //}
    }

    private void MovePlane()
    {
        myTransform.position = (new Vector3(currentXPosition += (Time.deltaTime * startSpeed), 0f, currentZPosition));
    }

}
