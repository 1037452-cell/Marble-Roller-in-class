using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnGroup : MonoBehaviour
{
    public Transform myTransform;
    public GameObject groupAllColours;

    public Player player;

   
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
            Instantiate(groupAllColours);

            yield return new WaitForSeconds(3);
        }
        
    }

}
