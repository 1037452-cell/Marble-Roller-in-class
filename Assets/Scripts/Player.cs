using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public bool isAlive = true;

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

    public Material green;
    public Material red;
    public Material yellow;
    public Material blue;

    
    // Trigger Type
    public bool isGreen = false;
    public bool isYellow = false;
    public bool isRed = false;
    public bool isBlue = false;

    // Slot Colours Reference
    public SlotColour slotColour;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        myTransform.position = slotR1.position;
        mySlot = 3;
        myMeshRenderer.material = CheckColour(); 
    }

    // Update is called once per frame
    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame && isAlive)
        {
            isAlive = false;
        }
        else if (Keyboard.current.escapeKey.wasPressedThisFrame && !isAlive)
        {
            isAlive = true;
        }




        if (Keyboard.current.fKey.wasPressedThisFrame) // move the player left
        {
            myTransform.position = allSlots[mySlot - 1].position;
            mySlot--;
            myMeshRenderer.material = CheckColour();

            if (mySlot == 0) // loop the player over to the right 
            {
                myTransform.position = slotR2.position;
                mySlot = 4;
                myMeshRenderer.material = CheckColour();
            }
        }

        if (Keyboard.current.jKey.wasPressedThisFrame) // move player right
        {
            myTransform.position = allSlots[mySlot + 1].position;
            mySlot++;
            myMeshRenderer.material = CheckColour();

            if (mySlot == 5) // loop the player over to the left 
            {
                myTransform.position = slotL1.position;
                mySlot = 1;
                myMeshRenderer.material = CheckColour();
            }
        }


}

    private void OnTriggerEnter(Collider collision)
    {
            if (collision.gameObject.tag == "Green")
            {
                Debug.Log("Triggered " + collision.gameObject.name);
                
                if (myMeshRenderer.material == green && collision.gameObject.tag == "Green")
                {
                    Debug.Log("WAS ALSO GREEN");
                    isGreen = true;
                    slotColour.ChangeSlotColour();
                }
            }
            else  if (collision.gameObject.tag == "Yellow" && myMeshRenderer.material == yellow)
            {
                isYellow = true;
                slotColour.ChangeSlotColour();

                Debug.Log("Triggered " + collision.gameObject.name);
            }
            else if (collision.gameObject.tag == "Red" && myMeshRenderer.material == red)
            {
                isRed = true;
                slotColour.ChangeSlotColour();

                Debug.Log("Triggered " + collision.gameObject.name);
            }
            else if (collision.gameObject.tag == "Blue" && myMeshRenderer.material == blue)
            {
                isBlue = true;
                slotColour.ChangeSlotColour();

                Debug.Log("Triggered " + collision.gameObject.name);
            }
    }

    public Material CheckColour()
    {
        if (myTransform.position == slotL1.position)
        {
            return slotColour.s1.material;
        }
        else if (myTransform.position == slotL2.position)
        {
            return slotColour.s2.material;
        }
        else if (myTransform.position == slotR1.position)
        {
            return slotColour.s3.material;
        }
        else if (myTransform.position == slotR2.position)
        {
            return slotColour.s4.material;
        }
        else
        {
            return null;
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
