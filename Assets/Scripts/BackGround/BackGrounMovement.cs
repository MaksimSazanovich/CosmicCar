using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGrounMovement : MonoBehaviour
{
    private static float speed;
    [SerializeField] private float speedCount = 1;

    [SerializeField] private Transform player;
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.fixedDeltaTime;
    }

    //private void Update()
    //{
    //    if (transform.position.x + 20 < player.transform.position.x)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    public void SetSpeed()
    {
        speed = Enemy.speed - speedCount;
    }
}
