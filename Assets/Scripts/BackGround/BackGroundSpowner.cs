using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSpowner : MonoBehaviour
{

    [SerializeField] private float timeBetweenSpawns;
    private float nextSpawnTime;

    [SerializeField] private float backGroundLenth;
    [SerializeField] private float spawnPos = 5.12999f;

    [SerializeField] private GameObject backGround;
    private GameObject myBackGround;
    [SerializeField] private Transform parent;

    void Start()
    {

    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Time.time > nextSpawnTime)
        {
            myBackGround = Instantiate(backGround, transform.right * spawnPos, Quaternion.identity) as GameObject;
            //spawnPos += backGroundLenth;
            //Debug.Log(spawnPos);
            myBackGround.transform.SetParent(parent, true);
            nextSpawnTime = Time.time + timeBetweenSpawns;
        }
    }

    public void SetTimeBetweenSpawns()
    {
        timeBetweenSpawns = timeBetweenSpawns / Enemy.speed + 1.4f;
    }
}
