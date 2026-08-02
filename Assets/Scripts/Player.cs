using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    // Rails
    public Transform slotOffL;
    public Transform slotL1;
    public Transform slotL2;
    public Transform slotR1;
    public Transform slotR2;
    public Transform slotOffR;
    public Transform[] allSlots = new Transform[6];


    // Player Position
    public Transform myTransform;
    public int mySlot;
    
    // Player Material
    public MeshRenderer myMeshRenderer;

    // Rigid Body
    public Rigidbody myRigidbody;

    // Trigger Type
    public bool isGreen = false;
    public bool isYellow = false;
    public bool isRed = false;
    public bool isBlue = false;

    // Gate Reference
    public Gates gatesSpawned; 
    public GreenGates greenGates;
    public YellowGates yellowGates;
    public RedGates redGates;
    public BlueGates blueGates;
    
    // Slot Colours Reference
    public SlotColour slotColour;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        myTransform.position = slotR1.position;
        mySlot = 3;
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame || Keyboard.current.fKey.wasPressedThisFrame) // move the player left
        {
            myTransform.position = allSlots[mySlot - 1].position;
            mySlot--;
            Debug.Log("Postion " + mySlot);

            if (mySlot == 0) // loop the player over to the right 
            {
                myTransform.position = slotR2.position;
                mySlot = 4;
                Debug.Log("Postion " + mySlot);
            }
        }

        if (Keyboard.current.dKey.wasPressedThisFrame || Keyboard.current.jKey.wasPressedThisFrame) // move player right
        {
            myTransform.position = allSlots[mySlot + 1].position;
            mySlot++;
            Debug.Log("Postion " + mySlot);

            if (mySlot == 5) // loop the player over to the left 
            {
                myTransform.position = slotL1.position;
                mySlot = 1;
                Debug.Log("Postion " + mySlot);
            }
        }

        if (myTransform.position == slotL1.position)
        {
            myMeshRenderer.material.color = slotColour.s1.material.color;
        }
        else if (myTransform.position == slotL2.position)
        {
            myMeshRenderer.material.color = slotColour.s2.material.color;
        }
        else if (myTransform.position == slotR1.position)
        {
            myMeshRenderer.material.color = slotColour.s3.material.color;
        }
        else if (myTransform.position == slotR2.position)
        {
            myMeshRenderer.material.color = slotColour.s4.material.color;
        }

}

    private void OnTriggerEnter(Collider collision) // get the colour of the collided gate
    {
        if (isGreen == false && isYellow == false && isRed == false &&  isBlue == false)
        {
            if (collision.gameObject.tag == "Green")
            {
                isGreen = true;
                Debug.Log("Triggered " + collision.gameObject.name);
            }
            else  if (collision.gameObject.tag == "Yellow")
            {
                isYellow = true;
                Debug.Log("Triggered " + collision.gameObject.name);
            }
            else if (collision.gameObject.tag == "Red")
            {
                isRed = true;
                Debug.Log("Triggered " + collision.gameObject.name);
            }
            else if (collision.gameObject.tag == "Blue")
            {
                isBlue = true;
                Debug.Log("Triggered " + collision.gameObject.name);
            }
        }
        

        //if ((isGreen == false) && collision.gameObject.GetComponent<BoxCollider>() == (greenGates.g1 || greenGates.g2 || greenGates.g3 || greenGates.g4))
        //{
        //    isGreen = true;
        //    Debug.Log("Enter " + collision.gameObject.name);
        //}
        //else if ((isYellow == false) && collision.gameObject.GetComponent<BoxCollider>() == (yellowGates.y1 || yellowGates.y2 || yellowGates.y3 || yellowGates.y4))
        //{
        //    isYellow = true;
        //    Debug.Log("Enter " + collision.gameObject.name);
        //}
        //else if ((isRed == false) && collision.gameObject.GetComponent<BoxCollider>() == (redGates.r1 || redGates.r2 || redGates.r3 || redGates.r4))
        //{
        //    isRed = true;
        //    Debug.Log("Enter " + collision.gameObject.name);
        //}
    }

    private void OnTriggerExit(Collider collision)
    {
        if (isGreen == true)
        {
            isGreen = false;
            gatesSpawned.isGreen = false;
            Debug.Log("Exit " + collision.gameObject.name);
            
        }
        else if (isYellow == true)
        {
            isYellow = false;
            gatesSpawned.isYellow = false;
            Debug.Log("Exit " + collision.gameObject.name);
        }
        else if (isRed == true)
        {
            isRed= false;
            gatesSpawned.isRed = false;
            Debug.Log("Exit " + collision.gameObject.name);
        }
        else if  (isBlue == true)
        {
            isBlue = false;
            gatesSpawned.isBlue = false;
            Debug.Log("Exit " + collision.gameObject.name);
        }
    }

}
