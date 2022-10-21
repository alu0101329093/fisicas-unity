using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public int points;
    public int axisId;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Transform tf = GetComponent<Transform>();
        float horizontalAxis = Input.GetAxis("Horizontal" + axisId);
        float verticalAxis = Input.GetAxis("Vertical" + axisId);
        float rotationAxis = Input.GetAxis("Rotation" + axisId);

        Vector3 movementVector = (Vector3.forward * verticalAxis + Vector3.right * horizontalAxis);
        tf.Translate(movementVector * Time.deltaTime * movementSpeed);
        Vector3 rotationVector = Vector3.up * rotationAxis;
        tf.Rotate(rotationVector * Time.deltaTime * rotationSpeed, Space.World);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Cylinder")
        {
            points += 1;
        }
    }
}
