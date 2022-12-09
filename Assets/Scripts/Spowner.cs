using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spowner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private Transform[] spawnPoints;
    //Randomazer randomazer;
    //private Battery battery;
    [SerializeField] private Battery battery;


    private int nowSprite;

    [SerializeField] private float timeBetweenSpawns;
    private float nextSpawnTime;
    public static float enemySpeed;

    private void Awake()
    {
        enemySpeed = 4f;
    }

    private void Start()
    {
        
    }
    private void FixedUpdate()
    {
        if (Time.time > nextSpawnTime)
        {
            Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
            battery.CheckNumberOfBattery();
            nextSpawnTime = Time.time + timeBetweenSpawns;
            //Debug.Log("SetTimer");
            //battery = FindObjectOfType<Battery>();
            //battery.SetBattery();
            //randomazer = FindObjectOfType<Randomazer>();
            //randomazer.GetRandom();
        }
    }

    public void SetEnemySpeed()
    {
        enemySpeed = Enemy.speed;
    }

    public void SetTimeBetweenSpawns()
    {
        timeBetweenSpawns = timeBetweenSpawns / Enemy.speed +1.4f;
        //Battery.timeBetweenSpawnBatteries = timeBetweenSpawns;
        //Battery.number++;
    }
}

