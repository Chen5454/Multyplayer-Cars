using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour
{
    Rigidbody rb;
    public float movementSpeed = 15;
    public float rotationSpeed = 4;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + transform.forward * movementSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}