using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Canvas StopCanvas;
    public Text Point;
    public Text GameOverPoint;


    private void Update()
    {
        GameOverPoint.text = Point.text;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (StopCanvas.enabled == false)
            {
                StopCanvas.enabled = true;
                Time.timeScale = 0;
            }
            else
            {
                StopCanvas.enabled = false;
                Time.timeScale = 1;
            }
        }
    }

    public void YesClick()
    {
        Application.Quit();
    }

    public void NoClick()
    {
        StopCanvas.enabled = false;
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
