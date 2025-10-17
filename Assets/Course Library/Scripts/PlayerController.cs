using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Speed = 20.0f;
    private float sideSpeed = 45f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);

        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, sideSpeed * horizontalInput * Time.deltaTime);
    }
}
