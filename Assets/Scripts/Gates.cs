using UnityEngine;

public class Gates : MonoBehaviour
{
    // Gate Groups
    public GreenGates green;
    public YellowGates yellow;
    public RedGates red;

    // Children
    public Transform greenMove;
    public Transform yellowMove;
    public Transform redMove;

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

    // Trigger Type
    public bool isGreen;
    public bool isYellow;
    public bool isRed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentXPosition = myTransform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GreenBoost()
    {

    }

    private void YellowBoost()
    {

    }


    private void RedSlow()
    {

    }
}
