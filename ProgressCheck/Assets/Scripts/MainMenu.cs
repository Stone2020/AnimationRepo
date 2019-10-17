using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int Lives = 5;


     public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("Lives", 5);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    }
