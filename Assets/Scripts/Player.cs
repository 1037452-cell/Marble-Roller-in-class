using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

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
        Debug.Log("Enter " + collision.gameObject.name);
        isGreen = true;
    }

    

}
