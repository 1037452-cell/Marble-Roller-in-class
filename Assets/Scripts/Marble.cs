using UnityEngine;

public class Marble : MonoBehaviour
{
	public Rigidbody rb;
	
	public Vector3 rotationalVelocity;
	
	[SerializeField]
	private float speed = 250f;

    // Update is called once per frame
    void Update()
    {
	    // The negative is because it rotates the opposite direction, just in the left/right?
	    rotationalVelocity.x = Input.GetAxisRaw("Vertical");
	    rotationalVelocity.z = -Input.GetAxisRaw("Horizontal");
        
	    // Air control version. Just pushes it around
        // rb.AddForce(rotationalVelocity * (speed * Time.deltaTime));
        
        // Ground control only version. Actually rotates the sphere
        rb.AddTorque(rotationalVelocity * (speed * Time.deltaTime));
    }
}
