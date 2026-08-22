using UnityEngine;

public class GameMaster : MonoBehaviour
{
    // Script Ref
    public UI uI;
    public GateControll controlll;
    
    
    // Scoring
    public int score;
    public int bonus;
    public int bonusMultiplier;
    public bool isWinner;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isWinner = false;
        score = 0;
        bonus = 10;
        bonusMultiplier = 1;
        uI.scoreText.text = "Score: " + score.ToString();
        uI.multiText.text += bonusMultiplier.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
