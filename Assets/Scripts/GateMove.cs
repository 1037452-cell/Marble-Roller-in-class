using UnityEngine;

public class GateMove : MonoBehaviour
{
    // Movement
    public Transform myTransform;
    public float currentXPosition;
    public float currentYPosition;
    public float currentZPosition;
    public Vector3 moving;

    // Speeds
    public float startSpeed;
    public float boostSpeed;
    public float bigBoostSpeed;
    public float slowDown;
    public float speedOverall;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Transform position
        currentXPosition = myTransform.position.x;
        currentYPosition = myTransform.position.y;
        currentZPosition = myTransform.position.z;

        // Set Speed
        startSpeed = 2;
        speedOverall = startSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // Set Moving
        myTransform.position = new Vector3(currentXPosition += (Time.deltaTime * 2), currentYPosition, currentZPosition);


        // Need to re confifure (working but moved)

        //if (isGreen == false && isYellow == false && isRed == false && isBlue == false)
        //{
        //    if ((player.isGreen == true) && player.GetComponent<SphereCollider>().enabled == true)
        //    {
        //        isGreen = true;
        //        GreenBoost();
        //    }
        //    else if ((player.isYellow == true) && player.GetComponent<SphereCollider>().enabled == true)
        //    {
        //        isYellow = true;
        //        YellowBoost();
        //    }
        //    else if ((player.isRed == true) && player.GetComponent<SphereCollider>().enabled == true)
        //    {
        //        isRed = true;
        //        RedSlow();
        //    }
        //    else if (player.isBlue == true && player.GetComponent<SphereCollider>().enabled == true)
        //    {
        //        isBlue = true;
        //        BlueBoost();
        //    }
        //}
    }

    private void GreenBoost()
    {
        boostSpeed += 1.1f;
        startSpeed *= boostSpeed;
        Debug.Log("Green Boost Active");
    }

    private void YellowBoost()
    {
        bigBoostSpeed += 3;
        startSpeed *= bigBoostSpeed;
        Debug.Log("Yellow Boost Active");
    }


    private void RedSlow()
    {
        slowDown += startSpeed / 2;
        startSpeed -= slowDown;
        if (startSpeed <= 0)
        {
            startSpeed = 2;
        }
        Debug.Log("Red Slow Active");
    }

    private void BlueBoost()
    {
        boostSpeed += 1.1f;
        startSpeed *= boostSpeed;
        Debug.Log("Blue Boost Active");
    }
}
