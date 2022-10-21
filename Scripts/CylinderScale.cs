using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScale : MonoBehaviour
{
    public float growthFactor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            Transform tf = GetComponent<Transform>();
            tf.localScale *= growthFactor;
        }
    }
}
