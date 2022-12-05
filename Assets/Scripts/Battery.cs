using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private BoxCollider2D boxCollider2D;

    public static  int number;
    //public static float timeBetweenSpawnBatteries;

    [SerializeField] private Charge charge;

    private void Start()
    {


        number++;
        Debug.Log("number: " + number);
        if (number == 7)
        {
            ActivateSpriteRendererAndCollider(true);
            number = 0;
            Debug.Log("batteryTrue");
        }
        else
        {
            ActivateSpriteRendererAndCollider(false);
            Debug.Log("batteryFalse");
        }
    }

    private void Update()
    {

    }

    public void ActivateSpriteRendererAndCollider(bool isEguals)
    {
        spriteRenderer.enabled = isEguals;
        boxCollider2D.enabled = isEguals;
        Debug.Log($": {isEguals} :");
    }

    public void CheckNumberOfBattery()
    {

        //else if (number > 5 && Charge.puplicCharge == 1f)
        //{
        //    number = 0;
        //    ActivateSpriteRendererAndCollider(false);
        //    Debug.Log("batteryFalse");
        //}
        //else if (number < 5 && Charge.puplicCharge == 1f)
        //{
        //    ActivateSpriteRendererAndCollider(false);
        //    Debug.Log("batteryFalse");
        //}
    }


    //public void SetNumberOfBatteries()
    //{
    //    number++;
    //    Debug.Log($"number {number}");
    //    if (number >= 1)
    //    {
    //        //ActivateSpriteRendererAndCollider(true);
    //        spriteRenderer.enabled = true;
    //        boxCollider2D.enabled = true;
    //        number = 0;
    //        Debug.Log($"number {number}");
    //    }
    //    //else
    //    ////ActivateSpriteRendererAndCollider(false);
    //    //{ 
    //    //    spriteRenderer.enabled = false;
    //    //    boxCollider2D.enabled = false;
    //    //}
    //}
}
