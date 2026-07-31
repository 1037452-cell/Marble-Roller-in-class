using UnityEditor;
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

    // Gate Type
    public GreenGates green;
    public YellowGates yellow;
    public RedGates red;

    // Trigger Type
    public bool isGreen = false;
    public bool isYellow  = false;
    public bool isRed   = false;
    
    // Groups
    public GameObject greens;
    public GameObject yellows;
    public GameObject reds;

    // Spawn 
    public int spawnX = 44;
    public float spawnY = 1.76f;
    public float spawnZ = 0.71f;
    public Transform parent;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        currentXPosition = myTransform.position.x;
        currentYPosition = myTransform.position.y;
        currentZPosition = myTransform.position.z;
        startSpeed = 2;
        
        Instantiate(greens, parent); // CAN SPAWN THE PREFABS LIKE THIS
        // Can set up a coroutine to spawn a group every couple seconds perhaps 
    }

    // Update is called once per frame
    private void Update()
    {
        myTransform.position = (new Vector3(currentXPosition += (Time.deltaTime * startSpeed), currentYPosition, currentZPosition));
        
        if (isGreen == false && isYellow == false && isRed == false)
        {
            if ((player.isGreen == true) && player.GetComponent<SphereCollider>().enabled == true)
            {
                isGreen = true;
                GreenBoost();
            }
            else if ((player.isYellow == true) &&  player.GetComponent<SphereCollider>().enabled == true)
            {
                isYellow = true;
                YellowBoost();
            }
            else if ((player.isRed == true) && player.GetComponent<SphereCollider>().enabled == true)
            {
                isRed = true;
                RedSlow();
            }
        }


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
   
}
