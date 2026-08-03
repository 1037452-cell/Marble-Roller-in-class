using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class ColouredGates : MonoBehaviour
{
    // Gate Spawn Reference
    public Gates gateSpawn;

    // Slot Position
    public Vector3 s1;
    public Vector3 s2;
    public Vector3 s3;
    public Vector3 s4;
    public List<Vector3> positionCollection;
    
    // Slot New
    public Vector3 newS1;
    public Vector3 newS2;
    public Vector3 newS3;
    public Vector3 newS4;
    public List<Vector3> newTransform; 
    
    // Gate Type
    public GameObject green;
    public GameObject red;
    public GameObject yellow;
    public GameObject blue;

    // Movement
    public Transform myTransform;
    public float currentXPosition;
    public float currentYPosition;
    public float currentZPosition;

    // Spawn 
    public int spawnX = 44;
    public float spawnY = 1.76f;
    public float spawnZ = 0.71f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Set Up Movement
        currentXPosition = myTransform.position.x;
        currentYPosition = myTransform.position.y;
        currentZPosition = myTransform.position.z;


        // Set Up Spawner
        s1 = green.GetComponent<Transform>().position;
        s2 = red.GetComponent<Transform>().position;
        s3 = yellow.GetComponent<Transform>().position;
        s4 = blue.GetComponent<Transform>().position;
        GetNewTransforms();
        GetPositions();
        PositionSet();
        RandomGates();
        SetNewGates();
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = (new Vector3(currentXPosition += (Time.deltaTime * 2), currentYPosition, currentZPosition));

        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            GetPositions();
            RandomGates();
            SetNewGates();
        }
    }
    
    private void RandomGates()
    {
        for (int i = 0; i < 4; i++)
        {
            int r = Random.Range(0, positionCollection.Count);
            newTransform[i] = positionCollection[r];
            positionCollection.RemoveAt(r);
        }
    }

    private void PositionSet()
    {
        s1 = positionCollection[0];
        s2 = positionCollection[1];
        s3 = positionCollection[2];
        s4 = positionCollection[3];
    }

    private void GetPositions()
    {
        positionCollection.Add(s1);
        positionCollection.Add(s2);
        positionCollection.Add(s3);
        positionCollection.Add(s4);
    }
    
    
    private void GetNewTransforms()
    {
        newTransform.Add(newS1);
        newTransform.Add(newS2);
        newTransform.Add(newS3);
        newTransform.Add(newS4);
    }

    private void SetNewGates()
    {
        green.GetComponent<Transform>().position = newTransform[0];
        red.GetComponent<Transform>().position = newTransform[1];
        yellow.GetComponent<Transform>().position = newTransform[2];
        blue.GetComponent<Transform>().position = newTransform[3];
    }


}
