using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float push_strenght;
    public GameObject game_over;
    public GameObject score_manager;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PushUp();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            this.enabled = false;
            game_over.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal" && this.enabled == true)
        {
            score_manager.GetComponent<ScoreManager>().score += 1;
        }
    }

    void PushUp()
    {
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * push_strenght, ForceMode2D.Impulse);
    }
}
