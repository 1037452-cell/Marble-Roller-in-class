using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
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

    // Rigid Body
    public Rigidbody myRigidbody;

    // Trigger Type
    public bool isGreen = false;
    public bool isYellow = false;
    public bool isRed = false;

    // Gate Reference
    public GreenGates greenGates;
    public YellowGates yellowGates;
    public RedGates redGates;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myTransform.position = slotR1.position;
        mySlot = 3;
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
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

        if (Keyboard.current.dKey.wasPressedThisFrame || Keyboard.current.jKey.wasPressedThisFrame)
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

}

    private void OnTriggerEnter(Collider collision)
    {
        if (isGreen == false && isYellow == false && isRed == false)
        {
            if (collision.gameObject.GetComponent<BoxCollider>() == (greenGates.g1 || greenGates.g2 || greenGates.g3 || greenGates.g4))
            {
                isGreen = true;
                Debug.Log("Enter " + collision.gameObject.name);
            }
            else if (collision.gameObject.GetComponent<BoxCollider>() == (yellowGates.y1 || yellowGates.y2 || yellowGates.y3 || yellowGates.y4))
            {
                isYellow = true;
                Debug.Log("Enter " + collision.gameObject.name);
            }
            else if (collision.gameObject.GetComponent<BoxCollider>() == (redGates.r1 || redGates.r2 || redGates.r3 || redGates.r4))
            {
                isRed = true;
                Debug.Log("Enter " + collision.gameObject.name);
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
            Debug.Log("Exit " + collision.gameObject.name);
            
        }
        else if (isYellow == true)
        {
            isYellow = false;
            Debug.Log("Exit " + collision.gameObject.name);
        }
        else if (isRed == true)
        {
            isRed= false;
            Debug.Log("Exit " + collision.gameObject.name);
        }
    }
}
