using System.Collections;
using UnityEngine;

public class SpawnGroup : MonoBehaviour
{
    public GameObject groupAllColours;

    public Player player;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawningSequence());
    }


    private IEnumerator SpawningSequence()
    {
      while (player.isAlive)
        {
            Instantiate(groupAllColours);

            yield return new WaitForSeconds(3);
        }
        
    }

}
