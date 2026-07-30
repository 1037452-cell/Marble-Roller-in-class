using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlaneMovement : MonoBehaviour
{
    public Transform myTransform;
    public float currentXPosition;
    public float currentYPosition;
    public float currentZPosition;
    public float startSpeed;


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

    public void MovePlane()
    {
        myTransform.position = (new Vector3(currentXPosition += (Time.deltaTime * startSpeed), 0f, currentZPosition));
    }

}
