using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class SpawnGates : MonoBehaviour
{
    public Transform myTransform;
    
    
    // Reference to gates in ALLGATES prefab
    public GameObject green;
    public GameObject red;
    public GameObject yellow;
    public GameObject blue;

    public bool isGreen;
    public bool isRed;
    public bool isYellow;
    public bool isBlue; 
    
    
    // Collections for randomise
    public float[] colourCollectionTransforms;
    public List<float> zPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Make Array
        zPosition.Add(green.transform.position.z);
        zPosition.Add(red.transform.position.z);
        zPosition.Add(yellow.transform.position.z);
        zPosition.Add(blue.transform.position.z);
        
        colourCollectionTransforms = new[] {green.transform.position.z, red.transform.position.z, yellow.transform.position.z, blue.transform.position.z };
        

        // Assign new transform with loop 
        for (int i = 0; i < 4; i++)
        {
            int r = Random.Range(0, zPosition.Count);
            colourCollectionTransforms[i] = zPosition[r];
            zPosition.RemoveAt(r);
            Debug.Log("is now " + colourCollectionTransforms[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(green);
            Instantiate(red);
            Instantiate(yellow);
            Instantiate(blue);
        }
    }
}

