using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int health = 70;
    public int score = 120;
    public int coins = 0;

    public string playerName = "Alex";
    public string playerClass = "Wizard";

    public bool hasKey = true;
    public bool doorIsLocked = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (health > 0)
            Debug.Log("Health is greater than 0, player is alive");

        if (health <= 0)
            Debug.Log("Health is 0 or less, player is dead");

        if (score >= 100)
            Debug.Log("Your score is above 100");

        if (score < 100)
            Debug.Log("Your score is less than 100");

        if (coins == 0)
            Debug.Log("You have no coins");

        if (coins != 0)
            Debug.Log("You have coins");

        if (playerName == "Alex")
            Debug.Log("Hi Alex :)");

        if (playerName != "Alex")
            Debug.Log("wait... you're not Alex... hello " +  playerName);

        if (playerClass == "Warrior")
            Debug.Log("Brave Warrior");

        if (playerClass == "Wizard")

            if (playerName != "Harry")
                Debug.Log("Brave Wizard");

            if (playerName == "Harry")
                Debug.Log("You're a Wizard Harry!");

        if (hasKey == true)
            Debug.Log("You have a key");

        if (hasKey == false)
            Debug.Log("You don't have a key");

        if (doorIsLocked == true)
            Debug.Log("Door is locked");

        if (doorIsLocked == false)
            Debug.Log("Door is unlocked");

        if (hasKey == false)
            Debug.Log("You should find a key");

        if (hasKey == true)
            Debug.Log("You may use the key");
            
            if (doorIsLocked == true)
                Debug.Log("That key fits this door!");
                doorIsLocked = false;
                Debug.Log("The door is now unlcoked");
                hasKey = false;
            
            if (doorIsLocked == false)
                Debug.Log("This door is already unlocked");

       

        }
    // Update is called once per frame
    void Update()
    {

    }

}
