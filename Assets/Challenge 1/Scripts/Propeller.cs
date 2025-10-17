using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class Propeller : MonoBehaviour
{
    public GameObject propeller;
    public Vector3 offset;
    public float rotationSpeed;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Rotate(Vector3.forward, rotationSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
