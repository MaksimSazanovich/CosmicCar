using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


public class Charge : MonoBehaviour
{
    //[SerializeField] private Sprite[] sprites;
    [SerializeField] private Image image;
    [SerializeField] private Image bgImage;

    private LevelController levelController;


    [SerializeField] private float charge =1f;
    public static float puplicCharge;
    private float value = 30;
    private float speed = 5;
    Color color = new Color(255, 255, 255, 0f);
    void Start()
    {
        bgImage.color = color;
        image.color = color;
        //image.sprite = sprites[charge];
        levelController = FindObjectOfType<LevelController>();
    }

    void Update()
    {
        image.fillAmount = charge;
        //StartCoroutine(DischargeBattery());
        value -= Time.deltaTime * speed;
        //if (value < 0)
        //{
        charge -= Time.deltaTime * 0.05f;
        puplicCharge = charge;
        if (charge <= 0)
        {
             Debug.Log("lose");
             levelController.ReloadScene();
        }
            //image.sprite = sprites[charge];
        //    value = 30;
        //}

    }

    public void AddCharge()
    { 
        charge = 1f;
        puplicCharge = charge;
        //value = 30;
        if (charge >= 1)
        {
            charge = 1;
            puplicCharge = charge;
        }
        //image.sprite = sprites[charge]; 
    }

    private IEnumerator DischargeBattery()
    { 
        yield return new WaitForSeconds(5f);
        charge--;
        puplicCharge = charge;
        //image.sprite = sprites[charge];
    }

    public void SetColor()
    {
        //Debug.Log("color");
        color = new Color(0, 0.9f, 0, 1f);
        image.color = color;
        color = new Color(0.5f, 0.5f, 0.5f, 1f);
        bgImage.color = color;
    }
}
