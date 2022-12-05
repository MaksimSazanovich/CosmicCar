using System.Collections;
using System.Collections.Generic;
using UnityEditor;
//using UnityEditor.U2D;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject fires;
    [SerializeField] private ParticleSystem fire1;
    [SerializeField] private ParticleSystem fire2;
    [SerializeField] private Rigidbody2D rigidbody2d;

    private LevelController levelController;
    void Start()
    {
        Time.timeScale = 0f;
        fires.SetActive(false);
        levelController = FindObjectOfType<LevelController>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Main.isJump == true)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                speed = 4f;
                rigidbody2d.velocity = Vector2.up * speed;
                StartCoroutine(Fire());
            }
        }
    }

    private IEnumerator Fire()
    {
        fires.SetActive(true);
        fire1.Play();
        fire2.Play();
        yield return new WaitForSeconds(2f);
        fires.SetActive(false);
    }

    public void Lose() 
    {
        speed = 0f;
    }

    public void ResetSpeed()
    {
        speed = 0f;
        rigidbody2d.velocity = Vector2.up * 0f;
    }

}