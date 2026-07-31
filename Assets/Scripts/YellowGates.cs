using UnityEngine;

public class YellowGates : MonoBehaviour
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
    public Transform yellowGate1;
    public Transform yellowGate2;
    public Transform yellowGate3;
    public Transform yellowGate4;

    // Green Colliders 
    public BoxCollider y1;
    public BoxCollider y2;
    public BoxCollider y3;
    public BoxCollider y4;
    
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
