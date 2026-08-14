using UnityEngine;

public class DeSpawnGates : MonoBehaviour
{
    public BoxCollider otherCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (otherCollider == null)
        {
            Debug.Log("HTF do I make this work???");
        }
        
        Debug.Log(other.gameObject.name + " destroy");
        Destroy(otherCollider.gameObject);

    }
    
}
