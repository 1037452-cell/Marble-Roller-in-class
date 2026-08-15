using UnityEngine;

public class GameMaster : MonoBehaviour
{
    // Script Ref
    public Player player;
    public GateMove move;
    
    // Scoring
    public int score;
    public int bonus;
    public int bonusMultiplier;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        bonus = 10;
        bonusMultiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
