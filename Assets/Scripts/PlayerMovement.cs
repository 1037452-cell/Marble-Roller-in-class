using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
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

    // Trigger Type
    public bool isGreen;
    public bool isYellow;
    public bool isRed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myTransform.position = slotR1.position;
        mySlot = 3;
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

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit! " + collision.gameObject.name);
    }


}
