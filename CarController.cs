using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarController : MonoBehaviour
{
public float speed = 10f; // Speed of the car
public float turnSpeed = 5f; // Turning speed of the car
private float horizontalInput; // Horizontal input from the player
private float verticalInput; // Vertical input from the player
private Rigidbody carRigidbody; // Reference to the car's Rigidbody component
void Start() {
   carRigidbody = GetComponent<Rigidbody>();
}
void Update() {
   horizontalInput = Input.GetAxis("Horizontal");
   verticalInput = Input.GetAxis("Vertical");
}
void FixedUpdate() {
   carRigidbody.AddRelativeForce(0f, 0f, verticalInput * speed);
   transform.Rotate(0f, horizontalInput * turnSpeed, 0f);
}
}
