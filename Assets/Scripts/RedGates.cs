using UnityEngine;

public class RedGates : MonoBehaviour
{
    // Reference of player
    public Player player;

    // Reference of moving plane
    public PlaneMovement plane;
    
    // Objects
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;

    // Green Gates Position
    public Transform redGate1;
    public Transform redGate2;
    public Transform redGate3;
    public Transform redGate4;

    // Green Colliders 
    public BoxCollider r1;
    public BoxCollider r2;
    public BoxCollider r3;
    public BoxCollider r4;
    
    public int number;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject1.gameObject.SetActive(false);
        gameObject2.gameObject.SetActive(false);
        gameObject3.gameObject.SetActive(false);
        gameObject4.gameObject.SetActive(false);
        RandomeGate();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject1.gameObject == false || gameObject2.gameObject == false || gameObject3.gameObject == false || gameObject4.gameObject == false)
        {
            RandomeGate();
        }
    }

    private void RandomeGate()
    {
        number = Random.Range(0, 3);
        Debug.Log("Yellow Random gate = " + number);

        if (number == 0)
        {
            gameObject1.gameObject.SetActive(true);
        }
        else if (number == 1)
        {
            gameObject2.gameObject.SetActive(true);
        }
        else if (number == 2)
        {
            gameObject3.gameObject.SetActive(true);
        }
        else
        {
            gameObject4.gameObject.SetActive(true);
        }
    }
}
