using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    SavePlayerPos playerPosData;

     void Start()
    {
        playerPosData = FindObjectOfType<SavePlayerPos>();
    
    }

    private void awake()
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 == 9 || SceneManager.GetActiveScene().buildIndex + 1 == 10)
        {
        playerPosData = FindObjectOfType<SavePlayerPos>();
        playerPosData.PlayerPosLoad();
        }
    }
    
    public void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 9 || SceneManager.GetActiveScene().buildIndex == 10)
        {
            playerPosData.PlayerPosSav();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
