using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class ColouredGates : MonoBehaviour
{
    // Slot Position
    public Transform s1;
    public Transform s2;
    public Transform s3;
    public Transform s4;
    public List<Transform> positionCollection;
    
    // Slot New
    public Transform newS1;
    public Transform newS2;
    public Transform newS3;
    public Transform newS4;
    public List<Transform> newTransform; 
    
    // Gate Type
    public Transform green;
    public Transform red;
    public Transform yellow;
    public Transform blue;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetPositions();
        SetNewTransforms();
        SetNewGates();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            RandomGates();
            GetPositions();
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

    private void GetPositions()
    {
        positionCollection.Add(s1);
        positionCollection.Add(s2);
        positionCollection.Add(s3);
        positionCollection.Add(s4);
        
        PositionSet();
    }
    
    private void PositionSet()
    {
        s1.position = positionCollection[0].position;
        s2.position = positionCollection[1].position;
        s3.position = positionCollection[2].position;
        s4.position = positionCollection[3].position;
    }
    
    private void SetNewGates()
    {
        green = newTransform[0];
        red = newTransform[1];
        yellow = newTransform[2];
        blue = newTransform[3];
    }

    private void SetNewTransforms()
    {
        newTransform.Add(newS1);
        newTransform.Add(newS2);
        newTransform.Add(newS3);
        newTransform.Add(newS4);
    }
    

   
    
}
