using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class DebuggingAndOpperations : MonoBehaviour
{
    public string openingMessage = "Adventure Begins";

    public int enemyCount = 8;
    public int gold = 53;
    public int partyMembers = 4;

    public int bonusGold = 20;
    public int costOfSword = 35;

    public int baseDamage = 10;
    public int comboHits = 3; // Number of hits to form a combo

    // Float values
    public float criticalMultiplier = 1.5f;
    public float distanceToChest = 30f;
    public float timeToReach = 5f;

    void Start()
    {
        Debug.Log("Adventure Starts");
        Debug.Log(openingMessage);

        // Current Stats
        Debug.Log("Enemies in area " + enemyCount);
        Debug.Log("Starting gold is " + gold);
        Debug.Log("Party member count is " + partyMembers);

        // Addition
        Debug.Log("You found bonus " +  bonusGold + " gold");
        gold = gold + bonusGold;
        // a better way of adding to the value is gold += bonusGold; 
        // is you want to just add 1 unit, use gold++
        Debug.Log("You now have " + gold + " gold");

        // Subtraction
        Debug.Log("You buy a sword for " + costOfSword + " gold");
        gold -= costOfSword; // short hand for subtraction, can also be written as gold = gold - costOfSword; 
        Debug.Log("Gold left after purchase: " + gold);

        // Multiplication
        Debug.Log("Base damage " + baseDamage);
        Debug.Log("Combo hits done " + comboHits);
        Debug.Log("Total combo damage (multiplied by combo hits): " + (baseDamage * comboHits));

        // Intiger Division
        Debug.Log("Shares " + gold + " gold equally by " + partyMembers + " party members");
        Debug.Log("Each party member recieves: " + (gold / partyMembers) + " gold");

        // Modulo %
        Debug.Log("Left over gold from divide: " + (gold % partyMembers) + " gold");

        // Floar Divistion
        Debug.Log("Distance to the chest is " + distanceToChest + 'm');
        Debug.Log("Time to reach chest remaining: " + timeToReach + 's');
        Debug.Log("Travel speed (distance/time: " + (distanceToChest / timeToReach) + "m/s");

        Debug.Log("Critical hit multiplier: " + criticalMultiplier);
        Debug.Log("Critical hit damage (base damage * citical multiplier): " + (baseDamage * criticalMultiplier));

        Debug.Log("This chapeter ends :) But is only the begginging!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
