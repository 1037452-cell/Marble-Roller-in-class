using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Randomly removes one of the gates ready to be spawned
/// Colour remains the same for now but plans to randomise positon in the future, had lots of trouble trying to get it to work as prefabs
/// </summary>

public class GateSlotRandom : MonoBehaviour
{
    public GameObject green;
    public GameObject red;
    public GameObject yellow;
    public GameObject blue;
    public List<GameObject> Colours;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Colours.Add(green);
        Colours.Add(red);
        Colours.Add(yellow);
        Colours.Add(blue);
        
        int r = Random.Range(0, Colours.Count);
        
        Debug.Log(r);
        Debug.Log(Colours[r]);
        Colours.RemoveAt(r);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
