using UnityEngine;
using UnityEngine.InputSystem;

public class Marble : MonoBehaviour
{
	public Rigidbody rb;
	public Vector3 rV;

	private float speed = 250f;

    // Update is called once per frame
    void Update()
    {
	    // The negative is because it rotates the opposite direction, just in the left/right?
	    rV.x = Input.GetAxisRaw("Vertical");
	    rV.z = speed;
       
		if (Keyboard.current.leftArrowKey.isPressed)
        {
            speed -= Time.deltaTime;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            speed -= Time.deltaTime;
        }

        
        // Ground control only version. Actually rotates the sphere
        rb.AddTorque(rV * (speed * Time.deltaTime));


    }
}
