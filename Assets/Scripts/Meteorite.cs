using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    private int dir;

    private Battery battery;
    void Start()
    {
        battery = FindObjectOfType<Battery>();
        transform.Rotate(Vector3.forward  * Random.Range(0, 360));
        transform.position += Vector3.right * Random.Range(-1, 1);
        dir = Random.Range(-4, 4);

        //if (Time.timeScale == 1f)
        //{          
        //    //battery.SetNumberOfBatteries(); 
        //}
        transform.Rotate(Vector3.forward * dir * Time.deltaTime);
    }

    private void Update()
    {

        
    }

}
