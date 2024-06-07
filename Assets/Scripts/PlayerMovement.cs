using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float push_strenght;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PushUp();
        }
    }

    void PushUp()
    {
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * push_strenght, ForceMode2D.Impulse);
    }
}
