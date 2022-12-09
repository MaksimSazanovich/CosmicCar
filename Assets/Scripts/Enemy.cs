using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    public static float speed;
    private float timeBetwwenSpeedAdd = 5f;
    private float timeToDestroy = 5f;

    private Spowner spowner;
    private BackGroundSpowner backGroundSpowner;
    private BackGrounMovement backGroundMovement;

    private void Start()
    {
        spowner = FindObjectOfType<Spowner>();
        backGroundMovement = FindObjectOfType<BackGrounMovement>();
        backGroundSpowner = FindObjectOfType<BackGroundSpowner>();
        speed = Spowner.enemySpeed;
        
        StartCoroutine(Destroy());
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.fixedDeltaTime;
        spowner.SetEnemySpeed();
        spowner.SetTimeBetweenSpawns();
        //backGroundSpowner.SetTimeBetweenSpawns();
        backGroundMovement.SetSpeed();
    }

    private void Update()
    {
        timeBetwwenSpeedAdd -= Time.deltaTime * 0.05f;
        if (timeBetwwenSpeedAdd <= 0)
        {
            speed += 0.05f;
            timeBetwwenSpeedAdd = 5f;
        }

        if (transform.position.x <= -7)
        {
            Destroy(gameObject);
        }

    }
    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);
    }
}
