using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunawayPlayer : MonoBehaviour
{
    public float runawaySpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Transform tf = GetComponent<Transform>().parent;
            Vector3 directionToPlayer = tf.transform.position - other.transform.position;
            directionToPlayer.y = 0;
            tf.Translate(directionToPlayer.normalized * runawaySpeed);

        }
    }
}
