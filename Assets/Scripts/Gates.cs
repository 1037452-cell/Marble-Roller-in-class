using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using UnityEngine.Animations;

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
    public float speedOverall;

    // Gate Type
    public GreenGates green;
    public YellowGates yellow;
    public RedGates red;
    public BlueGates blue;

    // Trigger Type
    public bool isGreen = false;
    public bool isYellow  = false;
    public bool isRed   = false;
    public bool isBlue  = false;
    
    // Groups
    public GameObject greens;
    public GameObject yellows;
    public GameObject reds;
    public GameObject blues;
    public GameObject colourGroup;
    public List<GameObject> colourGatesSpawned = new List<GameObject>();

    // Spawn 
    public int spawnX = 44;
    public float spawnY = 1.76f;
    public float spawnZ = 0.71f;
    public Transform parent;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
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
    private void Update()
    {
        if (isGreen == false && isYellow == false && isRed == false && isBlue == false)
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
            else if (player.isBlue == true && player.GetComponent<SphereCollider>().enabled == true)
            {
                isBlue = true;
                BlueBoost();
            }
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(colourGroup, parent);
            {
                colourGatesSpawned.Add(colourGroup);
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

    private void BlueBoost()
    {
        boostSpeed += 1.1f;
        startSpeed *= boostSpeed;
        Debug.Log("Blue Boost Active");
    }
    
}
