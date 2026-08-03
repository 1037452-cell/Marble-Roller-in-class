using UnityEngine;
using System.Collections.Generic;

public class RandomSpawn : MonoBehaviour
{

    public GameObject green;
    public GameObject red;
    public GameObject yellow;
    public GameObject blue;
    public List<GameObject> colourList;

    public List<Transform> TransfromList;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TransfromList.Add(green.GetComponent<Transform>());
        TransfromList.Add(red.GetComponent<Transform>());
        TransfromList.Add(yellow.GetComponent<Transform>());
        TransfromList.Add(blue.GetComponent<Transform>());

        colourList.Add(green);
        colourList.Add(red);
        colourList.Add(yellow);
        colourList.Add(blue);

        for (int i = 0; i < 3; i++)
        {
            int r = Random.Range(0, TransfromList.Count); // Take one of the transform list
            Debug.Log("Random " + r);
            colourList[i].GetComponent<Transform>().position = TransfromList[r].position; // Assign the random transfrom to each colour
            Debug.Log("Colour now " + colourList[i].GetComponent<Transform>().position);
            TransfromList.RemoveAt(r); // revove that transfrom option
        }

        Destroy(TransfromList[0].gameObject); // Destroy the last gate

        // Assign the new list of transfroms to the colours
        green.transform.position = colourList[0].transform.position;
        red.transform.position= colourList[1].transform.position;
        yellow.transform.position = colourList[2].transform.position;
        blue.transform.position = colourList[3].transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
