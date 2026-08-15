using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public bool isAlive = true;
    public GameObject myGameObject;

    // Game Ref
    public GameMaster gameMaster;

    // UI Ref
    public UI uI;
    
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
    public int slot1 = 1;
    public int slot2 = 2;
    public int slot3 = 3;
    public int slot4 = 4;
    
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
        // Start player in position 3
        myTransform.position = slotR1.position;
        mySlot = slot3;
        myMeshRenderer.material = CheckColour(); 
    }

    // Update is called once per frame
    private void Update()
    {
        // Dead and Alive checks
        if (Keyboard.current.escapeKey.wasPressedThisFrame && isAlive)
        {
            isAlive = false;
        }
        else if (Keyboard.current.escapeKey.wasPressedThisFrame && !isAlive)
        {
            isAlive = true;
        }


        // Player Movement 
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            myTransform.position = allSlots[mySlot - 1].position;
            mySlot--; // update slot number
            myMeshRenderer.material = CheckColour();

            if (mySlot == 0) // loop the player over to the right 
            {
                myTransform.position = slotR2.position;
                mySlot = slot4;
                myMeshRenderer.material = CheckColour();
            }
        }
        if (Keyboard.current.jKey.wasPressedThisFrame) // move player right
        {
            myTransform.position = allSlots[mySlot + 1].position;
            mySlot++; // update slot number
            myMeshRenderer.material = CheckColour();

            if (mySlot == 5) // loop the player over to the left 
            {
                myTransform.position = slotL1.position;
                mySlot = slot1;
                myMeshRenderer.material = CheckColour();
            }
        }


}

    private void OnTriggerEnter(Collider collision)
    {
            if (collision.gameObject.tag == "Green") // Slot is green
            {
                if (myMeshRenderer.material.color == green.color) // Player is also green
                {
                Debug.Log("WAS ALSO GREEN");
                isGreen = true;
                uI.greenImage.enabled = true;
                slotColour.ChangeSlotColour();
                gameMaster.score++; // +1 to score
                uI.scoreText.text = "Score: " + gameMaster.score.ToString();
                }
                else // Player is not green
                {
                    isAlive = false;
                    Destroy(myGameObject);
                    Debug.Log("GAME OVER");
                }
            }
            else  if (collision.gameObject.tag == "Yellow")
            {
                if (myMeshRenderer.material.color == yellow.color) 
                {
                    Debug.Log("WAS ALSO YELLOW");
                    isYellow = true;
                    uI.yellowImage.enabled = true;
                    slotColour.ChangeSlotColour();
                    gameMaster.score++; // +1 to score
                    uI.scoreText.text = "Score: " + gameMaster.score.ToString();
                }
                else // Player is not yellow
                {
                    isAlive = false;
                    Destroy(myGameObject);
                    Debug.Log("GAME OVER");
                }
            }
            else if (collision.gameObject.tag == "Red")
            {
                Debug.Log("Triggered " + collision.gameObject.name);
                
                if (myMeshRenderer.material.color == red.color) 
                {
                    Debug.Log("WAS ALSO RED");
                    isRed = true;
                    uI.redImage.enabled = true;
                    slotColour.ChangeSlotColour();
                    gameMaster.score++; // +1 to score
                    uI.scoreText.text = "Score: " + gameMaster.score.ToString();
                }
                else // Player is not red
                {
                    isAlive = false;
                    Destroy(myGameObject);
                    Debug.Log("GAME OVER");
                }
            }
            else if (collision.gameObject.tag == "Blue")
            {
                Debug.Log("Triggered " + collision.gameObject.name);
                
                if (myMeshRenderer.material.color == blue.color) 
                {
                    Debug.Log("WAS ALSO BLUE");
                    isBlue = true;
                    uI.blueImage.enabled = true;
                    slotColour.ChangeSlotColour();
                    gameMaster.score++; // +1 to score
                    uI.scoreText.text = "Score: " + gameMaster.score.ToString();
                }
                else // Player is not blue
                {
                    isAlive = false;
                    Destroy(myGameObject);
                    Debug.Log("GAME OVER");
                }
            }
            else if (collision.gameObject.tag == "power")
            {
                Debug.Log("Triggered " + collision.gameObject.name);
                slotColour.ChangeSlotColour();
                Destroy(collision.gameObject);
            }

            AllGatesScored(); // Checking if bonus is triggered

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
        return null;
    }
    
    // Gives the player bonus score for scoring at least one of each gate
    public void AllGatesScored()
    {
        if (isGreen == true && isRed == true && isYellow == true && isBlue == true)
        {
            gameMaster.bonus *= gameMaster.bonusMultiplier;
            gameMaster.score += gameMaster.bonus;
            Debug.Log("Bonus Score " + gameMaster.bonus + " added");
            gameMaster.bonusMultiplier++; // Add 1 to multi 
            uI.multiText.text = "Muti: x" + gameMaster.bonusMultiplier.ToString(); // UI Update

            isGreen = false;
            uI.greenImage.enabled = false;
            isRed = false;
            uI.redImage.enabled = false;
            isYellow = false;
            uI.yellowImage.enabled = false;
            isBlue = false;
            uI.blueImage.enabled = false;
        }
    }
    
}
