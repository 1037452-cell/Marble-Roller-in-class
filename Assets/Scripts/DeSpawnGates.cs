using UnityEngine;

public class DeSpawnGates : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
    }
    
}
