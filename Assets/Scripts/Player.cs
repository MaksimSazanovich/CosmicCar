using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private LevelController levelController;
    private Main main;
    private Battery battery;
    private Charge charge;

    private int score;

    private void Start()
    {
        levelController = FindObjectOfType<LevelController>();
        main = FindObjectOfType<Main>();
        battery = FindObjectOfType<Battery>();
        charge = FindObjectOfType<Charge>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Meteorite>())
        {
            main.Lose();
        }

        if (other.gameObject.GetComponent<Death>())
        {
            main.Lose();
        }

        if (other.gameObject.GetComponent<Finish>())
        {
            main.Win();
        }

        if (other.gameObject.GetComponent<Battery>())
        {
            //score++;
            //main.GetScore(score);
            charge.AddCharge();
            Destroy(other.gameObject);
        }
    }
}
