using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public float cooldown;
    private float initial_cooldown;
    public float current_cooldown;
    private int spawned_obstacles;

    public GameObject obstacle;
    public GameObject score_manager;

    private void Start()
    {
        initial_cooldown = cooldown;
        current_cooldown = initial_cooldown;
        spawned_obstacles = 0;
    }

    private void FixedUpdate()
    {
        SpawnObstacle();
        cooldown_manager();
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
            cooldown = current_cooldown;
            spawned_obstacles += 1;
        }
    }

    private void cooldown_manager()
    {
        current_cooldown = (initial_cooldown - score_manager.GetComponent<ScoreManager>().score/1000f - spawned_obstacles/60f);
    }

}
