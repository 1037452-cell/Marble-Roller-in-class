using UnityEngine;
using UnityEngine.UIElements;

public class Gates : MonoBehaviour
{
    // Player Reference
    public Player player;

    // Plane Reference
    public PlaneMovement plane;

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

    // Gate Tyoe
    public GreenGates green;
    public YellowGates yellow;
    public RedGates red;

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
        startSpeed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = (new Vector3(currentXPosition += (Time.deltaTime * startSpeed), currentYPosition, currentZPosition));

        if (player.isGreen == true)
        {
            GreenBoost();
        }
        else if (player.isYellow == true)
        {
            YellowBoost();
        }
        else if (player.isRed == true)
        {
            RedSlow();
        }
        else
        {
            return;
        }

    }

    private void GreenBoost()
    {
        boostSpeed = 3;
        isGreen = true;
        Debug.Log("Green Boost Active");
    }

    private void YellowBoost()
    {
        bigBoostSpeed = 10;
        isYellow = true;
        Debug.Log("Yellow Boost Active");
    }


    private void RedSlow()
    {
        slowDown = -3;
        isRed = true;
        Debug.Log("Red Slow Active");
    }
}
