using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class GameManager: MonoBehaviour
{
    public GameObject cactus;
    public GameObject Obstacles_l;
    public GameObject Obstacles_a;
    public GameObject Obstacles_b;
    public GameObject Obstacles_c;
    public GameObject Obstacles_d;
    public float spawnTime = 3f;
    private float timer;
    public Transform cactusSpawnposition;
    public GameObject GameOverScene;
    private float timerCactus = 0f; 
    private float timerObstacle = 0f; 
    private float spawnTimeCactus; 
    private float spawnTimeObstacle; 



    void Start()
    {

        Time.timeScale = 1;
        
    }
    void Update()
    {
        timerCactus += Time.deltaTime;
        if (timerCactus >= spawnTimeCactus)
        {
            Vector3 cactusPosition = new Vector3(cactusSpawnposition.position.x, -1.78f, cactusSpawnposition.position.z);
            Instantiate(cactus, cactusPosition, Quaternion.identity);
            timerCactus = 0f;
            spawnTimeCactus = Random.Range(1f, 5f);
        }

        timerObstacle += Time.deltaTime;
        if (timerObstacle >= spawnTimeObstacle)
        {
            Vector3 obstaclePosition = new Vector3(cactusSpawnposition.position.x, -0.77f, cactusSpawnposition.position.z);
            Instantiate(Obstacles_l, obstaclePosition, Quaternion.identity);
            timerObstacle = 0f;
            spawnTimeObstacle = Random.Range(9f, 12f);
        }

        timerObstacle += Time.deltaTime;
        if (timerObstacle >= spawnTimeObstacle)
        {
            Vector3 obstaclePosition = new Vector3(cactusSpawnposition.position.x, -1.95f, cactusSpawnposition.position.z);
            Instantiate(Obstacles_a, obstaclePosition, Quaternion.identity);
            timerObstacle = 0f;
            spawnTimeObstacle = Random.Range(3f, 100f);
        }
        timerObstacle += Time.deltaTime;
        if (timerObstacle >= spawnTimeObstacle)
        {
            Vector3 obstaclePosition = new Vector3(cactusSpawnposition.position.x, -1.97f, cactusSpawnposition.position.z);
            Instantiate(Obstacles_b, obstaclePosition, Quaternion.identity);
            timerObstacle = 0f;
            spawnTimeObstacle = Random.Range(10f, 102f);
        }
        timerObstacle += Time.deltaTime;
        if (timerObstacle >= spawnTimeObstacle)
        {
            Vector3 obstaclePosition = new Vector3(cactusSpawnposition.position.x, -1.97f, cactusSpawnposition.position.z);
            Instantiate(Obstacles_c, obstaclePosition, Quaternion.identity);
            timerObstacle = 0f;
            spawnTimeObstacle = Random.Range(5f, 102f);
        }
        timerObstacle += Time.deltaTime;
        if (timerObstacle >= spawnTimeObstacle)
        {
            Vector3 obstaclePosition = new Vector3(cactusSpawnposition.position.x, -1.97f, cactusSpawnposition.position.z);
            Instantiate(Obstacles_d, obstaclePosition, Quaternion.identity);
            timerObstacle = 0f;
            spawnTimeObstacle = Random.Range(52f, 105f);
        }
    }


        public void GameOver()
    {
        Time.timeScale = 0;
        GameOverScene.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}