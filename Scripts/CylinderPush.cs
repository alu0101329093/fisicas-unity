using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderPush : MonoBehaviour
{
    public float pushForce;
    Vector3 pushMovement;
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
        if (pushMovement.magnitude > 0)
        {
            Transform tf = GetComponent<Transform>();
            tf.Translate(pushMovement * Time.deltaTime);
            pushMovement *= 0.1f;
        }
        if (pushMovement.magnitude < pushForce * 0.1f)
        {
            pushMovement = Vector3.zero;
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.collider.tag == "Player" && Input.GetAxisRaw("Push") == 1)
        {
            Vector3 pushDirection = other.collider.transform.forward;
            pushMovement = pushDirection * pushForce;
        }
    }
}
