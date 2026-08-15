using System.Collections;
using UnityEngine;

public class Power : MonoBehaviour
{
    public Collider myCollider;
    public Material myMaterial;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SwitchCollider());
    }

    void Update()
    {
        //myMaterial.color = Color.Lerp(new Color(352, 72, 91, 100), new Color(69, 72, 91, 100), Mathf.PingPong(Time.time, 1));
    }
    

    private IEnumerator SwitchCollider()
    {
        yield return new WaitForSeconds(1);
        myCollider.enabled = true;
    }
    
}
