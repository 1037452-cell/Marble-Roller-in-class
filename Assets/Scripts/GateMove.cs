using UnityEngine;

public class GateMove : MonoBehaviour
{
    // Movement
    public Transform myTransform;
    public float currentXPosition;
    public float currentYPosition;
    public float currentZPosition;

    // Speeds
    public float startSpeed = 2;
    public float boostSpeed;
    public float bigBoostSpeed;
    public float slowDown;
    public float speedOverall;
    
    // Spawn group Ref
    public SpawnGroup spawnGroup;
    
    // Ref
    public UI uI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       spawnGroup = GameObject.Find("GateSpawn").GetComponent<SpawnGroup>();
       uI = GameObject.Find("UI").GetComponent<UI>();
        
        // Transform position
        currentXPosition = myTransform.position.x;
        currentYPosition = myTransform.position.y;
        currentZPosition = myTransform.position.z;

        // Set Speed
        speedOverall = startSpeed;
        uI.speedText.text = "Speed: " + speedOverall.ToString();
        
        // Boost speed set
        boostSpeed = 1;
        bigBoostSpeed = 5;
        slowDown = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Set Moving and Speed
        myTransform.position = new Vector3(currentXPosition += (Time.deltaTime * speedOverall), currentYPosition, currentZPosition);

        if (speedOverall > 10)
        {
            spawnGroup.setSpawnSpeed = 4;
            Debug.Log("New Speed Set: " + spawnGroup.setSpawnSpeed);
        }
        
    }

}
