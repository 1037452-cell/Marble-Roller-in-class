using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameMaster gameMaster;
    public GateControll controll;
    public Timer timer;
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI multiText;
    
    public TextMeshProUGUI winnerText;
    public TextMeshProUGUI gameOver;
    
    public TextMeshProUGUI speedText;
    
    public TextMeshProUGUI timeRemainingText;
    
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
        gameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeRemainingText.text = timer.timeRemaining.ToString("00.00");
    }
}
