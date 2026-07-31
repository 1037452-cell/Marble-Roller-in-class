using UnityEngine;
using UnityEngine.InputSystem;

public class ScopeExample : MonoBehaviour
{
    public float baseSpeed = 5f;
    public float totalDistance = 0f;
    public float totalDistanceSprinted = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        baseSpeed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = baseSpeed;

        if (Keyboard.current.leftShiftKey.isPressed)
        {
            Debug.Log("Sprinting");

            float sprintMultiplier = 2f;

            currentSpeed *= sprintMultiplier;
            totalDistanceSprinted += currentSpeed * Time.deltaTime;
        }

        totalDistance += currentSpeed * Time.deltaTime;
    }

}
