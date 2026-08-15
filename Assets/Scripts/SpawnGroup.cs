using System.Collections;
using UnityEngine;

public class SpawnGroup : MonoBehaviour
{
    public GameObject groupAllColours;

    public Player player;

    public GateMove move;
    public int setSpawnSpeed;
    
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        setSpawnSpeed = 3;
        StartCoroutine(SpawningSequence());
    }


    private IEnumerator SpawningSequence()
    {
      while (player.isAlive)
        {
            Instantiate(groupAllColours);

            yield return new WaitForSeconds(setSpawnSpeed);
        }
        
    }

}
