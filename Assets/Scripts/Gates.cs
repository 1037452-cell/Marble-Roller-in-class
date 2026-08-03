using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Gates : MonoBehaviour
{
    // Player Reference
    public Player player;

    // Plane Reference
    public PlaneMovement plane;

    // Colour Gates Reference
    public SpawnRandom spawnRandomGates;

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
        
    }

    // Update is called once per frame
    private void Update()
    {
      
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            colourGroup.GetComponent<MonoBehaviour>().enabled = true;
            Instantiate(colourGroup);
        }
    }
   
}
