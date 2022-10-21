using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ScaleCube : MonoBehaviour
{
    public float maxScale;
    public float minScale;
    public float growthFactor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform tf = GetComponent<Transform>();
    }

    void OnCollisionEnter(Collision other)
    {
        ExtraTags extraTags = other.collider.GetComponent<ExtraTags>();
        if (extraTags == null) return;

        Transform tf = GetComponent<Transform>();
        if (extraTags.tags.Contains("Sphere")) tf.localScale /= growthFactor;
        if (extraTags.tags.Contains("Cube")) tf.localScale *= growthFactor;

        if (tf.localScale.x < minScale)
        {
            tf.localScale = Vector3.one * minScale;
        }
        if (tf.localScale.x > maxScale)
        {
            tf.localScale = Vector3.one * maxScale;
        }
    }
}
