using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public float cooldown;
    public GameObject obstacle;
    private float initial_cooldown;

    private void Start()
    {
        initial_cooldown = cooldown;
    }

    private void FixedUpdate()
    {
        SpawnObstacle();
    }

    private void SpawnObstacle()
    {
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
        else
        {
            Instantiate(obstacle, new Vector3(5, Random.Range(-2.5f, 2.5f), 0), Quaternion.identity);
            cooldown = initial_cooldown;
        }
    }
}
