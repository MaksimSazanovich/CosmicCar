using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    public static float speed;
    private float timeToDestroy = 5f;

    private Spowner spowner;
    private BackGround backGround;
    private void Start()
    {
        spowner = FindObjectOfType<Spowner>();
        backGround = FindObjectOfType<BackGround>();
        speed = Spowner.enemySpeed;
        
        StartCoroutine(Destroy());
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.fixedDeltaTime;
        speed += 0.0005f;
        spowner.SetEnemySpeed();
        spowner.SetTimeBetweenSpawns();
        backGround.SetSpeed();
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);
    }
}
