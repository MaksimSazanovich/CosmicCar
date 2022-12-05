using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private int sceneIndex;
    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(sceneIndex+1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
