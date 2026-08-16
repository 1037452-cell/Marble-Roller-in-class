using UnityEngine;
using System.Collections.Generic;

public class SlotColour : MonoBehaviour
{
    public Player player;
    
    // Material Colours
    public Material green;
    public Material yellow;
    public Material red;
    public Material blue;
    public List<Material> colourCollection;
    
    // Slots
    public MeshRenderer s1;
    public MeshRenderer s2;
    public MeshRenderer s3;
    public MeshRenderer s4;
    public List<MeshRenderer> slotCollection;

    // Colour Reference
    public Material colour1;
    public Material colour2;
    public Material colour3;
    public Material colour4;
    public List<Material> colourRefCollection;
    
   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      colourCollection = new List<Material>();
      slotCollection = new List<MeshRenderer>();
      
      slotCollection.Add(s1);
      slotCollection.Add(s2);
      slotCollection.Add(s3);
      slotCollection.Add(s4);
      
      MakeColourList();
      
      colourRefCollection.Add(colour1);
      colourRefCollection.Add(colour2);
      colourRefCollection.Add(colour3);
      colourRefCollection.Add(colour4);
      
      RollColours();
      SetColours();
    }

    private void RollColours()
    {
        if (colourCollection != null)
        {
            for (int i = 0; i < 4; i++)
            {
                int r = Random.Range(0, colourCollection.Count);
                colourRefCollection[i] = colourCollection[r];
                colourCollection.RemoveAt(r);
            }
        }
        
    }

    private void AssignColours()
    {
        colour1 = colourRefCollection[0];
        colour2 = colourRefCollection[1];
        colour3 = colourRefCollection[2];
        colour4 = colourRefCollection[3];
    }

    private void MakeColourList()
    {
        if (colourCollection.Count != 4)
        {
            colourCollection.Add(green);
            colourCollection.Add(yellow);
            colourCollection.Add(red);
            colourCollection.Add(blue);
        }
    }
    
    
    private void SetColours()
    {
        AssignColours();
        
        s1.material = colour1;
        s2.material = colour2;
        s3.material = colour3;
        s4.material = colour4;
        
        GetMesh(); // Show Mesh again
        
        MakeColourList();
    }

    private void GetMesh()
    {
        s1.enabled = true;
        s2.enabled = true;
        s3.enabled = true;
        s4.enabled = true;
    }

    // Executes a bunch of functions that randomise the slot colours
    public void ChangeSlotColour()
    {
        RollColours();
        SetColours();
        
        // Update player colour
        if (player.mySlot == 1)
        {
            player.myMeshRenderer.material = player.slotColour.s1.material;
        }
        else if (player.mySlot == 2)
        {
            player.myMeshRenderer.material = player.slotColour.s2.material;
        }
        else if (player.mySlot == 3)
        {
            player.myMeshRenderer.material = player.slotColour.s3.material;
        }
        else if (player.mySlot == 4)
        {
            player.myMeshRenderer.material = player.slotColour.s4.material;
        }
    }
    
}
