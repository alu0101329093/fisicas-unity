using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public float force;
    public bool invertDirection;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitLaunch());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator WaitLaunch()
    {
        yield return new WaitForSeconds(0.3f);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(force * (invertDirection ? -1.0f : 1.0f), 0.0f, 0.0f, ForceMode.VelocityChange);
    }
}
