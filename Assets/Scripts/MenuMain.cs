using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMain : MonoBehaviour
{
    LevelController levelController;
    [SerializeField] private GameObject tutorial;
    [SerializeField] private GameObject wr;
    [SerializeField] private Animator nameTextAnimator;
    [SerializeField] private Animator playButtonAnimator;

    private void Start()
    {
        levelController = FindObjectOfType<LevelController>();
        tutorial.SetActive(false);
        wr.SetActive(true);
        //PlayAnimations();
    }

    public void NextLevel()
    {
        levelController.NextLevel();
    }

    public void OnTutorialButtonDown()
    { 
        tutorial.SetActive(true);
        wr.SetActive(false);
    }

    public void OnTutorDown()
    {
        tutorial.SetActive(false);
        wr.SetActive(true);
    }

    //public void PlayAnimations()
    //{
    //    nameTextAnimator.Play("NameGame");
    //    playButtonAnimator.Play("PlayIdle");
    //}
}
