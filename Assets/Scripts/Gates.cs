using Unity.VisualScripting;
using UnityEngine;

public class Gates : MonoBehaviour
{
    // Reference of player
    public PlayerMovement player;

    // Reference of moving plane
    public PlaneMovement plane;

    // Green Gates Position
    public Transform greenGate1;
    public Transform greenGate2;
    public Transform greenGate3;
    public Transform greenGate4;

    // Green Colliders 
    public BoxCollider g1;
    public BoxCollider g2;
    public BoxCollider g3;
    public BoxCollider g4;

    // Trigger Checks
    public bool isGreenTriggered;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnCollisionEnter(Collision collision)
    {
    Debug.Log("Hit! " + collision.gameObject.name);
    }

}
