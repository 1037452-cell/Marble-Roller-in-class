using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Device;

public class GreenGates : MonoBehaviour
{
    // Reference of player
    public Player player;

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
    public BoxCollider[] greenCollection;

    // Trigger Checks
    public bool isGreenTriggered;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        greenCollection = new[] {g1, g2, g3, g4};
    }

    // Update is called once per frame
    void Update()
    {

    }

}
