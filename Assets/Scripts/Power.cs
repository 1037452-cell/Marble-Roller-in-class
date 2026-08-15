using System.Collections;
using UnityEngine;

public class Power : MonoBehaviour
{
    public Collider myCollider;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SwitchCollider());
    }

    private IEnumerator SwitchCollider()
    {
        yield return new WaitForSeconds(1);
        myCollider.enabled = true;
    }
    
}
