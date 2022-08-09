using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{

    private bool gameEnded;
    public GameObject CompleteLevelUI;
    public GameObject LoseLevelUI;
    public AudioSource touchdown;

    public void WinLevel()
    {
        if (!gameEnded)
        {

            Debug.Log("You made the Stop, you win!");
            CompleteLevelUI.SetActive(true);
            gameEnded = true;
        }
        
    }


    public void LoseLevel()
    {
        if (!gameEnded)
        {
            Debug.Log("They scored a Touchdown, you lose!");
            touchdown.Play();
            LoseLevelUI.SetActive(true);
            gameEnded = true;
        }
    }

    


}
