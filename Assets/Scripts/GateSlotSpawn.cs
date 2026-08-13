using System.Collections;
using UnityEngine;

public class GateSlotSpawn : MonoBehaviour
{
    public Player player;

    // Slot in Spawn Position
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;

    // Coloue Gates
    public GameObject green;
    public GameObject red;
    public GameObject yellow;
    public GameObject blue;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawningSequence());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawningSequence()
    {
        while (player.isAlive)
        {
           // Instantiate();

            yield return new WaitForSeconds(3);
        }

    }
}
