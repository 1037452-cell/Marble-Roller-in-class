using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Player player;
    public GameMaster gameMaster;
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI multiText;
    
    public Image greenImage;
    public Image redImage;
    public Image yellowImage;
    public Image blueImage;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        greenImage.enabled = false;
        redImage.enabled = false;
        yellowImage.enabled = false;
        blueImage.enabled = false;
        
        scoreText.text = "Score: " + gameMaster.score.ToString();
        multiText.text = "Muti: x" + gameMaster.bonusMultiplier.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
