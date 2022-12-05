using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject restartAndMenuInPauseScreen;

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text timerText;
    //[SerializeField] private GameObject button;

    public static bool isJump;
    private int timerTime;
    
    


    private LevelController levelController;
    private Charge charge;
    private PlayerController playerController;

    private void Start()
    {
        restartAndMenuInPauseScreen.SetActive(false);
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
        levelController = FindObjectOfType<LevelController>();
        playerController = FindObjectOfType<PlayerController>();
        charge = FindObjectOfType<Charge>();
        pauseButton.SetActive(true);
        isJump = false;
        timerTime = 3;

    }

    public void Win()
    {
        isJump = false;
        winScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ReloadScene()
    { 
    levelController.ReloadScene();
    }

    public void OnPauseButtonDown()
    { 
        isJump = false;
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
        pauseScreen.SetActive(true);
        restartAndMenuInPauseScreen.SetActive(true);
    }

    public void GetScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void OnPauseScreenDown()
    {
        StartCoroutine(Timer());
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);
        //button.SetActive(true);
        pauseButton.SetActive(true);
        restartAndMenuInPauseScreen.SetActive(false);
        charge.SetColor();
        isJump = true;
    }

    private IEnumerator Timer()
    {
        for (int i = 3; i >= timerTime; i--)
        {
        timerText.text = timerTime.ToString();
        yield return new WaitForSeconds(1f);
        }
        timerTime = 3;
    }

    public void Lose()
    {
        isJump = false;
        Time.timeScale = 0f;
        loseScreen.SetActive(true);
    }

    public void OnMenuButtonDown()
    { 
    levelController.LoadMenu();
    }

 
}
