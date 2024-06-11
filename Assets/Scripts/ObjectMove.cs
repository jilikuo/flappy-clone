using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float obj_speed;

    void Start()
    {
        Destroy(this.gameObject, 15);

    }

    void FixedUpdate()
    {

        transform.position += new Vector3(-obj_speed, 0, 0);

    }
}
