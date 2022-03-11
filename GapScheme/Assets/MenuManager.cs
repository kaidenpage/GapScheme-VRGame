using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Panel currentPanel = null;

    private List<Panel> panelHistory = new List<Panel>();

    private void start()
    {
        SetupPanels();
    }



    public void SetupPanels()
    {
        Panel[] panels = GetComponentsInChildren<Panel>();

        foreach(Panel panel in panels)
        {
            panel.Setup(this);
        }

        currentPanel.Show();
    }

    public void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GoToPrevious();
        }
    }

    public void GoToPrevious()
    {

        if(panelHistory.Count == 0)
        {
            return;
        }

        int lastIndex = panelHistory.Count -1;
        SetCurrent(panelHistory[lastIndex]);
        panelHistory.RemoveAt(lastIndex);

    }

    public void SetCurrentWithHistory(Panel newPanel)
    {
        panelHistory.Add(currentPanel);
        SetCurrent(newPanel);
    }

    public void SetCurrent(Panel newPanel)
    {
        currentPanel.Hide();

        currentPanel = newPanel;
        currentPanel.Show();

    }


public void level1()
    {
        SceneManager.LoadScene(1);
    }

    public void level2()
    {
        SceneManager.LoadScene(2);
    }

    public void level3()
    {
        SceneManager.LoadScene(3);
    }

    public void level4()
    {
        SceneManager.LoadScene(4);
    }

    public void level5()
    {
        SceneManager.LoadScene(5);
    }

    public void level6()
    {
        SceneManager.LoadScene(6);
    }

    public void level7()
    {
        SceneManager.LoadScene(7);
    }

    public void level8()
    {
        SceneManager.LoadScene(8);
    }

    public void Credit()
    {
        SceneManager.LoadScene(9);
    }

}

