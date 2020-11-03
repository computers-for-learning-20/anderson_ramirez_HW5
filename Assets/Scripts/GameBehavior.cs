using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    public string labelText = "Collect all 4 goals to win!";
    public int maxGoals = 4;

    private bool winScreenShow = false;
    private bool loseScreenShow = false;

    private uint health_Marble = 100;
    private uint goals_reached = 0;

    public uint HealthMarble
    {
        get {return health_Marble; }
        set
        {
            health_Marble = value;

            if(health_Marble <= 0)
            {
                labelText = "Oh oh oh no! T_T";
                WinOrLoseScreen("lose");
            }
            else
            {
                labelText = "ouch!";
            }
        }
    }

    public uint Goals
    {
        get { return goals_reached; }
        set
        {
            goals_reached = value;

            if (goals_reached == maxGoals)
            {
                labelText = "You got them all, you winner!";
                WinOrLoseScreen("win");
            }
            else if (goals_reached == 1 || goals_reached == 3)
            {
                labelText = string.Format("Nice! Only {0} left to find!",
                    maxGoals - goals_reached);
            }
            else
            {
                labelText = string.Format("Super! Only {0} left to find!",
                    maxGoals - goals_reached);
            }

        }
    }

    private void OnGUI()
    {
        // adjusting fonts and colors for readablity
        GUI.skin.label.fontSize = 18;
        GUI.skin.label.fontStyle = FontStyle.Bold;
        GUI.skin.box.fontStyle = FontStyle.Normal;
        GUI.skin.box.fontSize = 18;
        GUI.skin.button.fontSize = 24;
        GUI.backgroundColor = new Color(0, 0, 0, 1);

        // doubilng GUI boxes because alpha element doesn't
        // seem to help with opacity and they are hard to read
        GUI.Box(new Rect(20, 20, 250, 30), "");
        GUI.Box(new Rect(20, 20, 250, 30),
            "Marble Health: " + health_Marble);

        GUI.Box(new Rect(20, 55, 250, 30),"");
        GUI.Box(new Rect(20, 55, 250, 30),
            "Goals Collected: " + goals_reached);

        GUI.contentColor = new Color(0, 0, 0);

        GUI.Label(new Rect((Screen.width / 2) - 100,
            Screen.height - 50, 300, 50), labelText);

        GUI.contentColor = new Color(255, 255, 255, 1);

        // Creating win and lose screen buttons
        if(winScreenShow)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 250,
                Screen.height / 2 - 50, 500, 100),
                "You Win!!! (click to restart)"))
            {
                RestartLevel();
            }
        }

        if (loseScreenShow)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 250,
                Screen.height / 2 - 50, 500, 100),
                "Oh no! You've lost! (click to restart)"))
            {
                RestartLevel();
            }
        }
    }

    private void RestartLevel()
    {
        // function for restarting the scene
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    private void WinOrLoseScreen(string cond)
    {
        // function for choosing which freeze
        // screen button to show
        if(cond == "win")
        {
            winScreenShow = true;

        }
        else if (cond == "lose")
        {
            loseScreenShow = true;
        }

        Time.timeScale = 0.0f;
    }

}
