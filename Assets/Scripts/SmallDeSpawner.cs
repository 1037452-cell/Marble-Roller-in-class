using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SmallDeSpawner : MonoBehaviour
{
    public Transform myTransform;
    public List<Transform> moveSpot;
    public Transform s1;
    public Transform s2;
    public Transform s3;
    public Transform s4;
    
    public Player player;

    public GameObject power;

    public SpawnGroup speedUpdate;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveSpot.Add(s1);
        moveSpot.Add(s2);
        moveSpot.Add(s3);
        moveSpot.Add(s4);
        
        StartCoroutine(waitMove());
    }


    private void moveSmallBoy()
    {
        int r = Random.Range(0, moveSpot.Count);
        myTransform.position = moveSpot[r].position;
    }

    private void spawnPower()
    {
        Instantiate(power, new Vector3(-45, 0.7f, myTransform.position.z) , Quaternion.identity);
    }
    
    
    
    private IEnumerator waitMove()
    {
        while (player.isAlive)
        {
            moveSmallBoy();
            yield return new WaitForSeconds(speedUpdate.speed);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnPower();
    }
    
    
}
