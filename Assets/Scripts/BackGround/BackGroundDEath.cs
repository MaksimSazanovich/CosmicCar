using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundDEath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<BackGround>())
        {
            Destroy(other.gameObject);
        }
    }
}

