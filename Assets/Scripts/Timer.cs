using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public float timeAdd;
    public int startTime;

    public Player player;
    public UI uI;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startTime = 30;
        timeAdd = 2;
        timeRemaining = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isAlive == true)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0)
            {
                player.GameOver();
                timeRemaining = 0;
                uI.timeRemainingText.color = Color.red;
            }
        }
      
    }
}
